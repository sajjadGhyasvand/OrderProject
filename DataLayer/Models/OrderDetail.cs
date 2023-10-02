using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class OrderDetail
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int OrderId { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public double SumPrice { get; set; }
        public Product Product { get; set; }
        public Order Order { get; set; }
    }
}
