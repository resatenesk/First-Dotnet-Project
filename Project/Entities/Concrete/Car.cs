using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        public int CarID { get; set; }
        public string? CarModel { get; set; }
        public float CarPrice { get; set; }
        public string? CarColor { get; set; }
        public int CarProductionYear { get; set; }
        public int CarUnitsInStock { get; set; }
        public int CarOwnerID { get; set; }
    }
}