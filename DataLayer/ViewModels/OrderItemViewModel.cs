using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.ViewModels
{
    public class OrderItemViewModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int PersonalId { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public double SumPrice { get; set; }
    }
}
