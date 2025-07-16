using Core.DataAccess.EntityFramework;
using Core.Entities;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCarDal : EFentityRepositoryBase<Car, Database>, ICarDal
    {
        public List<CarDetailsDto> GetCarDetails()
        {
            using (Database context = new Database())
            {
                var result = from car in context.Cars
                             join cus in context.Customers
                             on car.CarOwnerID equals cus.CustomerID
                             select new CarDetailsDto
                             {
                                 CarID = car.CarID,
                                 CarModel = car.CarModel,
                                 CarOwnerID = cus.CustomerID,
                                 CarOwnerName = cus.CustomerName, 
                                 CarProductionYear = car.CarProductionYear,
                                 CarPrice = car.CarPrice
                             };


                return result.ToList();
            }
        }
    }
}