using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int PersonalId { get; set; }
        [Required]
        public int Number { get; set; }
        public DateTime Date  { get; set; }
        public Personal Personal { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
