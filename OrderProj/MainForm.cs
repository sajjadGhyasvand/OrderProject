using DataLayer.Context;

namespace OrderProj
{
    public partial class MainForm : Form
    {
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
             OrderAddAndEdit orderForm = new OrderAddAndEdit();
            orderForm.ShowDialog();
        }
    }
}