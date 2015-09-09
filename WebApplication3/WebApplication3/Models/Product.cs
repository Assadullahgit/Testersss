using System.Collections.Generic;

namespace WebApplication3.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string NameProduct { get; set; }

        public virtual ICollection<Stock> Stocks { get; set; }
    }
}