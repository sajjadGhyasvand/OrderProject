using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.ViewModels
{
    public class OrderDetailViewModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int ProductCode { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public double SumPrice { get; set; }
        public int SelectedRow { get; set; }
    }
}
