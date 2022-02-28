using System.Collections.Generic;

namespace OrderApi2.Models
{
    public class CartOrder
    {
        public int OrderID { get; set; }
        public int CartID { get; set; }
        public int CustomerID { get; set; }
        public List<Product> Products { get; set; }
    }

    public class Product
    {
        public int ProductID { get; set; }
        public double ProductPrice { get; set; }
        public int Quantity { get; set; }
        public double Total { get; set; }
    }
}
