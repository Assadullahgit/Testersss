namespace WebApplication3.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public virtual ApplicationUser User { get; set; }
        public string ApplicationUserId { get; set; }
    }
}