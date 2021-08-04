using Dealership.App.Models.Car;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dealership.App.FluentValidation.Car
{
    public class CreateCarValidator : AbstractValidator<CreateCarViewModel>
    {
        public CreateCarValidator()
        {
            RuleFor(car => car.CarBrandId).Equal(0)
                .WithMessage("You need to choose a car brand");

            RuleFor(car => car.CarModelId).Equal(0)
                .WithMessage("You need to choose a car model");

            RuleFor(car => car.Image).NotNull()
                .WithMessage("You need to choose an image");
        }
    }
}
