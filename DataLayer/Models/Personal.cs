using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Personal
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(200)]
        public string Name { get; set; }
        [MaxLength(200)]
        public string CompanyName { get; set; }
        [MaxLength(20)]
        public string Phone { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public List<Order> Orders { get; set; }

    }
}
