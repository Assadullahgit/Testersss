using System.Collections;
using System.Collections.Generic;

namespace WebApplication3.Models
{
    public class Location
    {
        public int LocationID { get; set; }
        public string LocationName { get; set; }

        public virtual ICollection<Stock> Stocks { get; set; }
    }
}