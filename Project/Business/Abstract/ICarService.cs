using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using Core.Entities;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICarService
    {
        IResult Add(Car car);
        IDataResult<Car> Get(Car car);
        IDataResult<List<Car>> getByCarOwnerID(int id);
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetAllByID(int id);
        IDataResult<List<Car>> GetAllByUnitsInStock(decimal min, decimal max);
        IDataResult<List<Car>> GetByUnitPrice(float min, float max);
        IDataResult<List<CarDetailsDto>> GetCarDetails();
    }
}