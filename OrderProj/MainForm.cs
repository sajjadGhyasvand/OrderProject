using DataLayer.Context;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Windows.Forms;

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
        private void MainForm_Load(object sender, EventArgs e)
        {
            InitData();
            var data = _context.Orders.Where(x => !x.IsDelete).Include(x => x.Personal).Include(x => x.OrderDetails).ToList();
            AddOrderToDataGrid(dgOrder, data);
        }
        private void Create_Click(object sender, EventArgs e)
        {
            OrderAddAndEdit orderForm = new OrderAddAndEdit(dgOrder, 0);
            orderForm.ShowDialog();
        }
        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var Person = _context.Personals.FirstOrDefault(p => p.Name == cbCustomer.Text);
            var Orders = _context.Orders.Where(o => o.PersonalId == Person.Id && o.Date >= pdFromDate.GeorgianDate.Value.Date && o.Date <= pdToDate.GeorgianDate.Value.Date && !o.IsDelete).Include(x => x.Personal).Include(x => x.OrderDetails).ToList();
            dgOrder.Rows.Clear();
            AddOrderToDataGrid(dgOrder, Orders);
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (rowIndex >= 0 && dgOrder.RowCount >= 1)
            {
                var OrderNumber = dgOrder.CurrentRow.Cells[0].Value.ToString();
                var OrderId = _context.Orders.FirstOrDefault(o => o.Number == Convert.ToInt32(OrderNumber)).Id;
                OrderAddAndEdit orderAndEdit = new OrderAddAndEdit(dgOrder,OrderId);
                orderAndEdit.ShowDialog();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var OrderNumber = dgOrder.CurrentRow.Cells[0].Value.ToString();
            var Order = _context.Orders.Where(o => o.Number == Convert.ToInt32(OrderNumber)).FirstOrDefault();
            Order.IsDelete = true;
            _context.SaveChanges();
            dgOrder.Rows.RemoveAt(rowIndex);
            rowIndex = -1;
        }
        private void dgOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
        }



        #region Fuctions
        //اطلاعات اولیه 
        private void InitData()
        {
            cbCustomer.DataSource = _context.Personals.Select(x => x.Name).ToList();
            pdFromDate.GeorgianDate = DateTime.Now.AddMonths(-1);
            pdToDate.GeorgianDate = DateTime.Now;
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
        //تبدیل تاریخ میلادی به شمسی
        public string ToShamsi(DateTime date)
        {
            if (date == new DateTime()) return "";
            var pc = new PersianCalendar();
            return $"{pc.GetYear(date)}/{pc.GetMonth(date):00}/{pc.GetDayOfMonth(date):00}";
        }
        #endregion
    }
}