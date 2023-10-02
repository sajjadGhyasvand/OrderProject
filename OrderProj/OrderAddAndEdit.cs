using DataLayer.Context;
using DataLayer.Models;
using DataLayer.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderProj
{
    public partial class OrderAddAndEdit : Form
    {
        private OrderContext _context = new OrderContext();
        private DataGridView _dgGrideView;
        private int _orderId;
        int rowIndex;
        List<OrderItemViewModel> orderDetails;
        public OrderAddAndEdit(DataGridView dgGrideView, int orderId)
        {
            InitializeComponent();
            _dgGrideView=dgGrideView;
            _orderId=orderId;
        }

        private void Refuse_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            OrderDetailsAddAndEdit orderDetails = new OrderDetailsAddAndEdit(this.dgOrderItem, null);
            orderDetails.ShowDialog();
        }

        private void OrderAddAndEdit_Load(object sender, EventArgs e)
        {
            var customer = _context.Personals.Select(x => x.Name).ToList();
            cbCustomer.DataSource = customer;
            if (_orderId != 0)
            {
                var Orders = _context.Orders.Where(o => o.Id == _orderId).Include(x => x.Personal).Include(x => x.OrderDetails).ThenInclude(p=>p.Product).FirstOrDefault();
                cbCustomer.SelectedItem = Orders.Personal.Name;
                DPDate.Value = Orders.Date;
                foreach (var order in Orders.OrderDetails)
                {
                    object[] row = new object[] { order.Product.Name, order.Product.Code,order.Price, order.Count, order.SumPrice };
                    dgOrderItem.Rows.Add(row);
                }
            }
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            if (rowIndex >= 0 && dgOrderItem.RowCount >= 1)
            {
                OrderDetailViewModel orderDetail = new()
                {
                    SelectedRow = rowIndex,
                    ProductName = dgOrderItem.CurrentRow.Cells[0].Value.ToString(),
                    Count = Convert.ToInt32(dgOrderItem.CurrentRow.Cells[3].Value.ToString())
                };
                OrderDetailsAddAndEdit orderDatailsForm = new OrderDetailsAddAndEdit(dgOrderItem, orderDetail);
                orderDatailsForm.ShowDialog();
            }
        }

        private void dgOrderItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (rowIndex >= 0 && dgOrderItem.RowCount >= 1)
            {
                dgOrderItem.Rows.RemoveAt(rowIndex);
                rowIndex = -1;
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {

            var personalId = _context.Personals.Where(x => x.Name == cbCustomer.SelectedValue.ToString()).FirstOrDefault().Id;
            var orderitem = _context.Orders.OrderBy(x => x.Number).LastOrDefault();
            int orderId = 0;
            if (orderitem == null)
            {

                Order order = new()
                {
                    PersonalId = personalId,
                    Number = 101,
                    Date = DPDate.Value,
                };
                _context.Add(order);
                _context.SaveChanges();
                orderId = order.Id;
            }
            else
            {
                int number = orderitem.Number + 1;
                Order order = new()
                {
                    PersonalId = personalId,
                    Number = number,
                    Date = DPDate.Value,
                };
                _context.Add(order);
                _context.SaveChanges();
                orderId = order.Id;
            }
            foreach (DataGridViewRow row in dgOrderItem.Rows)
            {
                OrderDetail product = new()
                {
                    ProductId = _context.Products.Where(p => p.Code == Convert.ToInt32(row.Cells[1].Value)).Select(x => x.Id).FirstOrDefault(),
                    OrderId = orderId,
                    Price = Convert.ToInt32(row.Cells[2].Value),
                    Count = Convert.ToInt32(row.Cells[3].Value),
                    SumPrice = Convert.ToInt32(row.Cells[4].Value),
                };
                _context.Add(product);
                _context.SaveChanges();
            }
            DialogResult result = MessageBox.Show("با موفقیت ثبت شد", "ثبت اطلاعات", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                _dgGrideView.Rows.Clear();
                var data = _context.Orders.Include(x => x.Personal).Include(x => x.OrderDetails).ToList();
                foreach (var order in data)
                {
                    double priceSum = 0;
                    foreach (var orderDetail in order.OrderDetails)
                    {
                        priceSum += orderDetail.SumPrice;
                    }
                    object[] row = new object[] { order.Id, order.Personal.Name, order.Date, priceSum };
                    _dgGrideView.Rows.Add(row);
                }
                this.Close();
            }
        }
    }
}
