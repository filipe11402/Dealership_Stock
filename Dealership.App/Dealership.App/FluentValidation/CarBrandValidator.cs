using Dealership.App.Models.CarBrand;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dealership.App.FluentValidation
{
    public class CarBrandValidator : AbstractValidator<CreateCarBrandViewModel>
    {
        public CarBrandValidator()
        {
            RuleFor(brand => brand.CarBrandName).NotNull()
                .WithMessage("Car Brand needs to have a name");
        }
    }
}
