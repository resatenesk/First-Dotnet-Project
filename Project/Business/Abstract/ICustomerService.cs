using Core.Entities;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetByName(string CustomerName);
        IDataResult<Customer> GetByCompanyName(string CompanyName);
        IDataResult<List<Customer>> GetAll();
        IDataResult<Customer> GetAllByID(int CustomerID);
        IDataResult<Customer> GetAllByAge(decimal min, decimal max);

        IResult Add(Customer customer);

        IDataResult<List<CustomerDetailsDto>> GetCustomerDetails();
    }
}