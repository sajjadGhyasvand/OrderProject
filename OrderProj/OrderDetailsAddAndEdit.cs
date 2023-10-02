using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderProj
{
    public partial class OrderDetailsAddAndEdit : Form
    {
        public OrderDetailsAddAndEdit()
        {
            InitializeComponent();
        }

        private void txt_UnitPrice_TextChanged(object sender, EventArgs e)
        {
            var NormalText = txt_UnitPrice.Text;
            if (txt_UnitPrice.Text == "" || txt_UnitPrice.Text == "0") return;
            txtPriceSum.Text = txt_UnitPrice.Text;
            decimal price;
            price = decimal.Parse(txt_UnitPrice.Text, System.Globalization.NumberStyles.Currency);
            txt_UnitPrice.Text = price.ToString("#,#");
            txt_UnitPrice.SelectionStart = txt_UnitPrice.Text.Length;

            txtPriceSum.Text = (Convert.ToInt32(NormalText) * Convert.ToInt32(txt_Count.Text)).ToString();
        }

        private void txtPriceSum_TextChanged(object sender, EventArgs e)
        {
            if (txtPriceSum.Text == "" || txtPriceSum.Text == "0") return;
            decimal price;
            price = decimal.Parse(txtPriceSum.Text, System.Globalization.NumberStyles.Currency);
            txtPriceSum.Text = price.ToString("#,#");
            txtPriceSum.SelectionStart = txtPriceSum.Text.Length;
        }

        private void txt_Count_TextChanged(object sender, EventArgs e)
        {
         /*   txtPriceSum.Text = (Convert.ToInt32(txt_Count.Text) * Convert.ToInt32(txt_UnitPrice.Text)).ToString();*/         
        }
    }
}
