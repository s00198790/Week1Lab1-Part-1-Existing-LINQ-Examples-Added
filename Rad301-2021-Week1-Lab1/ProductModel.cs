using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rad301_2021_Week1_Lab1
{
    public class ProductModel
    {
        public static Random r = new Random();


        // Supplier
        public class Supplier
        {
            public int SupplierID { get; set; }
            public string SupplierName { get; set; }
            public string SupplierAddressLine1 { get; set; }
            public string SupplierAddressLine2 { get; set; }
        }

        // Product
        public class Product
        {
            public int ProductID { get; set; }
            public string Description { get; set; }
            public int QuantityInStock { get; set; }
            public float UnitPrice { get; set; }
            public int CategoryID { get; set; }
        }

        // Category
        public class Category
        {
            public int id { get; set; }
            public int description { get; set; }
        }

        // SupplierProduct
        public class SupplierProduct
        {
            public int supplierID { get; set; }
            public int productID { get; set; }
            public DateTime DateFirstSupplied { get; set; }
        }

    }
}
