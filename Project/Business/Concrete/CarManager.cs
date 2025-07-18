using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofec.Validation;
using Core.Entities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;


namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _IcarDal;

        public CarManager(ICarDal dal)
        {
            _IcarDal = dal;
        }

        [SecuredOperation("product.add,admin")]
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            _IcarDal.Add(car);
            return new SuccessResult(Messages.CarAddedMessage);
        }

        public IDataResult<Car> Get(Car car)
        {
            return new SuccessDataResult<Car>(_IcarDal.Get(p => car.CarID == p.CarID));
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_IcarDal.GetAll());
        }

        public IDataResult<List<Car>> GetAllByID(int id)
        {
            return new SuccessDataResult<List<Car>>(_IcarDal.GetAll(p => p.CarID == id));
        }

        public IDataResult<List<Car>> GetAllByUnitsInStock(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>(_IcarDal.GetAll(p => p.CarUnitsInStock >= min && p.CarUnitsInStock <= max));
        }

        public IDataResult<List<Car>> getByCarOwnerID(int id)
        {
            return new SuccessDataResult<List<Car>>(_IcarDal.GetAll(p => p.CarOwnerID == id));



        }

        public IDataResult<List<Car>> GetByUnitPrice(float min, float max)
        {
            return new SuccessDataResult<List<Car>>(_IcarDal.GetAll(p => p.CarPrice >= min && p.CarPrice <= max));
        }

        public IDataResult<List<CarDetailsDto>> GetCarDetails()
        {
            if (DateTime.Now.Hour == 17)
            {
                return new ErrorDataResult<List<CarDetailsDto>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<CarDetailsDto>>(_IcarDal.GetCarDetails());
        }
    }
}