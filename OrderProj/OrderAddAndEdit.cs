using DataLayer.Context;
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
    public partial class OrderAddAndEdit : Form
    {
        private OrderContext _context = new OrderContext();

        public OrderAddAndEdit()
        {
            InitializeComponent();
        }

        private void Refuse_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            OrderDetailsAddAndEdit orderDetails = new OrderDetailsAddAndEdit();
            orderDetails.ShowDialog();
        }

        private void OrderAddAndEdit_Load(object sender, EventArgs e)
        {
            var customer = _context.Personals.Select(x=>x.Name).ToList();
            cbCustomer.DataSource = customer;
        }
    }
}
