using Core.Entities.Abstract;

namespace Core.Entities
{
    public class CustomerDetailsDto : IDto
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public int CustomerAge { get; set; }
        public string CustomerCompanyName { get; set; }
        public int CarID { get; set; }
        public string CarModel { get; set; }
    }
}