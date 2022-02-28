using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CartApi2.Models
{
    public class Cart
    {
        [Key]
        public int CartID { get; set; }
        public string OrderStatus { get; set; }
        public int OrderID { get; set; }

        [NotMapped]
        public int CustomerID { get; set; }
    }
}
