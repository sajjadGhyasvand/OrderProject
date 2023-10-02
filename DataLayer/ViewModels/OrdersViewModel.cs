using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.ViewModels
{
    public class OrdersViewModel
    {
        public int OrderId { get; set; }
        public int InvoiceNumber { get; set; }
        public string PersonalName { get; set; }
        public DateTime Date { get; set; }
        public double SumPrice { get; set; }
    }
}
