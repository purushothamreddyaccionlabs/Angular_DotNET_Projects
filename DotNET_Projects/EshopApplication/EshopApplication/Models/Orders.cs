using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Orders
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TotalItems { get; set; }
        public int OrderTotal { get; set; }
        public string OrderStatus { get; set; }
    }
}
