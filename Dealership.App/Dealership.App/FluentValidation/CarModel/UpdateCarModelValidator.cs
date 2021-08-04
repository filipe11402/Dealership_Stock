using Dealership.App.Models.CarModel;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dealership.App.FluentValidation.CarModel
{
    public class UpdateCarModelValidator : AbstractValidator<UpdateCarModelViewModel>
    {
        public UpdateCarModelValidator()
        {
            RuleFor(model => model.CarModelName).NotNull()
                .WithMessage("Car model name cant be empty");
        }
    }
}
