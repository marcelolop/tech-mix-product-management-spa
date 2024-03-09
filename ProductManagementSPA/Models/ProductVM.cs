using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductManagementSPA.Models
{
    /// <summary>
    /// This class is responsible for representing the product view model.
    /// </summary>
    public class ProductVM
    {
        //Properties
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }
        public string Supplier { get; set; }
    }
}