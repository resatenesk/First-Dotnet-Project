using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI;

public class Program
{
    static void Main(string[] args)
    {
        // Elle ICarDal nesnesi veriyoruz
        CarManager carManager = new CarManager(new EFCarDal());

        var result = carManager.GetCarDetails();
        if (result.Success)
        {
            foreach (var car in result.Data)
            {
                Console.WriteLine(car.CarOwnerName + " adlı kişi " + car.CarModel + " modelinde arabaya sahip.");
            }
        }
        else
        {
            Console.WriteLine(result.Message);
        }
    }
}
