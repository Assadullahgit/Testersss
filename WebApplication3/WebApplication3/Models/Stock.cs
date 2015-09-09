namespace WebApplication3.Models
{
    public class Stock
    {
        public int ID { get; set; }
        public int LocationID { get; set; }
        public int ProductID { get; set; }

        public virtual Location Location { get; set; }
        public virtual Product Product { get; set; }
    }
}

        