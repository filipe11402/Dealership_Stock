using Dealership.App.Models.CarBrand;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dealership.App.FluentValidation.CarBrand
{
    public class CreateCarBrandValidator : AbstractValidator<CreateCarBrandViewModel>
    {
        public CreateCarBrandValidator()
        {
            RuleFor(brand => brand.CarBrandName).NotNull()
                .WithMessage("Car brand name cant be empty");
        }
    }
}
