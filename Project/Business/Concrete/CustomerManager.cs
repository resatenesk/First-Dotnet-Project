using Business.Abstract;
using Business.Constants.Messages;
using Core.Entities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal dal)
        {
            _customerDal = dal;
        }

        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Messages.CustomerAddedMessage);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll());
        }

        public IDataResult<Customer> GetAllByAge(decimal min, decimal max)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(p => p.CustomerAge >= min && p.CustomerAge <= max));
        }

        public IDataResult<Customer> GetAllByID(int CustomerID)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(p => p.CustomerID == CustomerID));
        }

        public IDataResult<Customer> GetByCompanyName(string CompanyName)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(p => p.CustomerCompanyName.Equals(CompanyName)));
        }

        public IDataResult<List<Customer>> GetByName(string CustomerName)
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(p => p.CustomerName.Equals(CustomerName)));
        }

        public IDataResult<List<CustomerDetailsDto>> GetCustomerDetails()
        {
            return new SuccessDataResult<List<CustomerDetailsDto>>(_customerDal.GetProductDetails());
        }
    }
}