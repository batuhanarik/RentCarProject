using Entities;
using FluentValidation;
using System;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.CarName).NotEmpty();
            RuleFor(c => c.CarName).MinimumLength(2);
            RuleFor(c => c.CarName).Must(StartWithM).WithMessage("Car Name Must Start With A"); // "M"odel X & "M"odel G vb.


            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThan(50);
            RuleFor(c => c.DailyPrice).GreaterThan(100).When(c=>c.BrandId==4); //Tesla ucuz olamaz!!!

            RuleFor(c => c.Description).NotEmpty();
            RuleFor(c => c.Description).MinimumLength(10);

            RuleFor(c => c.BrandId).NotEmpty();
            RuleFor(c => c.ColorId).NotEmpty();

            RuleFor(c => c.ModelYear).NotEmpty();
            RuleFor(c => c.ModelYear).GreaterThan(2000);

            






        }

        private bool StartWithM(string arg)
        {
            return arg.StartsWith("M");
        }
    }
}
