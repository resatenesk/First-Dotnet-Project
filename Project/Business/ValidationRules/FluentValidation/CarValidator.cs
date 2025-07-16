using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator: AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.CarModel).NotEmpty();
            RuleFor(c => c.CarPrice).GreaterThan(100000);
            RuleFor(c => c.CarProductionYear).Must(YearIsGreaterThan1900).WithMessage("Yıl 1900'den fazla girilmeli");
        }
        private bool YearIsGreaterThan1900(int arg)
        {
            return arg >= 1900;
        }
    }
}
