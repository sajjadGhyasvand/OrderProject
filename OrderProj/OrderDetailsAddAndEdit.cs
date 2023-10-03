using DataLayer.Context;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderProj;
using DataLayer.ViewModels;

namespace OrderProj
{
    public partial class OrderDetailsAddAndEdit : Form
    {
        private OrderContext _context = new OrderContext();
        private DataGridView _dgGrideView;
        private OrderDetailViewModel _orderDetailViewModel;
        public OrderDetailsAddAndEdit(DataGridView dgGrideView, OrderDetailViewModel orderDetailViewModel)
        {
            InitializeComponent();
            _dgGrideView=dgGrideView;
            _orderDetailViewModel=orderDetailViewModel;
        }
        Product selectedProduct = new();
        private void txt_Count_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_Count.Text))
            {
                txtPriceSum.Text = "0";
            }
            else
            {
                var sum = (selectedProduct.Price * (Convert.ToInt32(txt_Count.Text))).ToString();
                ChangeDigit(sum, txtPriceSum);
            }
        }
        List<Product> products = new();
        private void OrderDetailsAddAndEdit_Load(object sender, EventArgs e)
        {
            products = _context.Products.ToList();
            cbProduct.DataSource = products.Select(x => x.Name).ToList();
            if (_orderDetailViewModel != null)
            {
                cbProduct.SelectedItem = products.Where(x => x.Name == _orderDetailViewModel.ProductName).Select(x => x.Name).FirstOrDefault();
                txt_Count.Text = _orderDetailViewModel.Count.ToString();
            }
        }
        private void cbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProduct = products.Where(x => x.Name == cbProduct.SelectedValue.ToString()).FirstOrDefault();
            /*txt_UnitPrice.Text = selectedProduct.Price.ToString();*/
            ChangeDigit(selectedProduct.Price.ToString(), txt_UnitPrice);
            var sum = (selectedProduct.Price * (Convert.ToInt32(txt_Count.Text))).ToString();
            ChangeDigit(sum, txtPriceSum);
        }
        
        private void btnSubmitOrderDetail_Click(object sender, EventArgs e)
        {
            var sum = (selectedProduct.Price * (Convert.ToInt32(txt_Count.Text))).ToString();
            if (_orderDetailViewModel != null)
            {
                _dgGrideView.Rows[_orderDetailViewModel.SelectedRow].Cells[0].Value = selectedProduct.Name;
                _dgGrideView.Rows[_orderDetailViewModel.SelectedRow].Cells[1].Value = selectedProduct.Code;
                _dgGrideView.Rows[_orderDetailViewModel.SelectedRow].Cells[2].Value = selectedProduct.Price;
                _dgGrideView.Rows[_orderDetailViewModel.SelectedRow].Cells[3].Value = txt_Count.Text;
                _dgGrideView.Rows[_orderDetailViewModel.SelectedRow].Cells[4].Value = sum;
            }
            else
            {
                object[] row = new object[] { selectedProduct.Name, selectedProduct.Code, selectedProduct.Price, txt_Count.Text, sum };
                _dgGrideView.Rows.Add(row);
            }

        }

        private void btnRefuse_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ChangeDigit(string enter, TextBox exit)
        {
            decimal dcPrice;
            dcPrice = decimal.Parse(enter, System.Globalization.NumberStyles.Currency);
            exit.Text = dcPrice.ToString("#,#");
            exit.SelectionStart = txtPriceSum.Text.Length;
        }
    }
}
