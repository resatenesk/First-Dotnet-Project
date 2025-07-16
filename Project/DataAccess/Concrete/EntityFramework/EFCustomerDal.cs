using Core.DataAccess.EntityFramework;
using Core.Entities;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCustomerDal : EFentityRepositoryBase<Customer, Database>, ICustomerDal
    {
        public List<CustomerDetailsDto> GetProductDetails()
        {
            using (Database context = new Database())
            {
                var result = from car in context.Cars
                             join cus in context.Customers
                             on car.CarOwnerID equals cus.CustomerID
                             select new CustomerDetailsDto
                             {
                                 CustomerName = cus.CustomerName,
                                 CustomerAge = cus.CustomerAge,
                                 CarID = car.CarID,
                                 CustomerCompanyName = cus.CustomerCompanyName,
                                 CustomerID = car.CarOwnerID,
                                 CarModel = car.CarModel
                             };

                return result.ToList();
            }
        }


    }
}