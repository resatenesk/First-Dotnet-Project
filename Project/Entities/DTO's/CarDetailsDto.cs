namespace Core.Entities
{
    public class CarDetailsDto : IDto
    {
        public int CarID { get; set; }
        public float CarPrice { get; set; }
        public string CarModel { get; set; }
        public int CarProductionYear { get; set; }
        public string CarOwnerName { get; set; }
        public int CarOwnerID { get; set; }
    }
}