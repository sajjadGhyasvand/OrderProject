using DataLayer.Context;
using DataLayer.Models;
using DataLayer.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Globalization;

namespace OrderProj
{
    public partial class OrderAddAndEdit : Form
    {
        #region Parameters
        private OrderContext _context = new OrderContext();
        private DataGridView _dgGrideView;
        private int _orderId;
        int rowIndex;
        #endregion

        #region Constructor
        public OrderAddAndEdit(DataGridView dgGrideView, int orderId)
        {
            InitializeComponent();
            _dgGrideView=dgGrideView;
            _orderId=orderId;
        }
        #endregion


        private void OrderAddAndEdit_Load(object sender, EventArgs e)
        {
            InitData();
            if (_orderId != 0)
            {
                var Orders = _context.Orders.Where(o => o.Id == _orderId).Include(x => x.Personal).Include(x => x.OrderDetails).ThenInclude(p => p.Product).FirstOrDefault();
                cbCustomer.SelectedItem = Orders.Personal.Name;
                pdDate.GeorgianDate = Orders.Date;

                foreach (var order in Orders.OrderDetails)
                {
                    object[] row = new object[] { order.Product.Name, order.Product.Code, order.Price, order.Count, order.SumPrice };
                    dgOrderItem.Rows.Add(row);
                }
            }
            else
            {
                pdDate.GeorgianDate = DateTime.Now;
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            OrderDetailsAddAndEdit orderDetails = new OrderDetailsAddAndEdit(this.dgOrderItem, null);
            orderDetails.ShowDialog();
        }
        private void Refuse_Click(object sender, EventArgs e)
        {
            this.Close();
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

            int personalId = _context.Personals.FirstOrDefault(x => x.Name == cbCustomer.SelectedValue.ToString()).Id;
            var orderitem = _context.Orders.OrderBy(x => x.Number).LastOrDefault();
            int orderId = 0;
            if (orderitem == null)
            {
                Order order = new()
                {
                    PersonalId = personalId,
                    Number = 101,
                    Date = pdDate.GeorgianDate.Value.Date,
                    IsDelete = false,
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
                    Date = pdDate.GeorgianDate.Value.Date,
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
                var data = _context.Orders.Where(o => !o.IsDelete).Include(x => x.Personal).Include(x => x.OrderDetails).ToList();
                AddOrderToDataGrid(_dgGrideView, data);
                this.Close();
            }
        }
        private void dgOrderItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
        }
        #region Functions
        public string ToShamsi(DateTime date)
        {
            if (date == new DateTime()) return "";
            var pc = new PersianCalendar();
            return $"{pc.GetYear(date)}/{pc.GetMonth(date):00}/{pc.GetDayOfMonth(date):00}";
        }

        private void InitData()
        {
            var customer = _context.Personals.Select(x => x.Name).ToList();
            cbCustomer.DataSource = customer;
        }
        //ثبت اطلاعات در دیتاگرید
        private void AddOrderToDataGrid(DataGridView dgView, List<Order> orders)
        {
            foreach (var order in orders)
            {
                double priceSum = 0;
                foreach (var orderDetail in order.OrderDetails)
                {
                    priceSum += orderDetail.SumPrice;
                }
                object[] row = new object[] { order.Number, order.Personal.Name, ToShamsi(order.Date), priceSum };
                dgView.Rows.Add(row);
            }
        }
        #endregion
    }
}
