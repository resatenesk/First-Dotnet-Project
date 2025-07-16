using Core.Entities;

namespace Entities.Concrete
{
    public class Customer : IEntity
    {
        public int CustomerID { get; set; }
        public string? CustomerName { get; set; }
        public int CustomerAge { get; set; }
        public string? CustomerCompanyName { get; set; }
        public int CarID { get; set; }
    }
}