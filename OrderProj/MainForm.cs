using DataLayer.Context;
using DataLayer.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace OrderProj
{
    public partial class MainForm : Form
    {
        private OrderContext _context = new OrderContext();
        int rowIndex;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            OrderAddAndEdit orderForm = new OrderAddAndEdit(dgOrder,0);
            orderForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cbCustomer.DataSource = _context.Personals.Select(x => x.Name).ToList();
            dpFromDate.Value = DateTime.Now.AddMonths(-1);
            dpToDate.Value = DateTime.Now;
            var data = _context.Orders.Include(x => x.Personal).Include(x => x.OrderDetails).ToList();
            foreach (var order in data)
            {
                double priceSum = 0;
                foreach (var orderDetail in order.OrderDetails)
                {
                    priceSum += orderDetail.SumPrice;
                }
                object[] row = new object[] { order.Number, order.Personal.Name, order.Date, priceSum };
                dgOrder.Rows.Add(row);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var Person = _context.Personals.Where(p => p.Name == cbCustomer.Text).FirstOrDefault();
            var Orders = _context.Orders.Where(o => o.PersonalId == Person.Id && o.Date >= dpFromDate.Value && o.Date <= dpToDate.Value).Include(x => x.Personal).Include(x => x.OrderDetails).ToList();
            dgOrder.Rows.Clear();
            foreach (var order in Orders)
            {
                double priceSum = 0;
                foreach (var orderDetail in order.OrderDetails)
                {
                    priceSum += orderDetail.SumPrice;
                }
                object[] row = new object[] { order.Id, order.Personal.Name, order.Date, priceSum };
                dgOrder.Rows.Add(row);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (rowIndex >= 0 && dgOrder.RowCount >= 1)
            {
                var OrderNumber = dgOrder.CurrentRow.Cells[0].Value.ToString();
                var OrderId = _context.Orders.Where(o=>o.Number == Convert.ToInt32(OrderNumber)).FirstOrDefault().Id;
                OrderAddAndEdit orderAndEdit = new OrderAddAndEdit(dgOrder,OrderId);
                orderAndEdit.ShowDialog();
            }
        }

        private void dgOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
        }
    }
}