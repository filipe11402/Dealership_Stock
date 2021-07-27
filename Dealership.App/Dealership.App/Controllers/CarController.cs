using Dealership.App.Mediator.Commands;
using Dealership.App.Mediator.Queries;
using Dealership.App.Models.Car;
using Dealership.Domain.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dealership.App.Controllers
{
    public class CarController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;

        public CarController(IMediator mediator, IUnitOfWork unitOfWork)
        {
            this._mediator = mediator;
            this._unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Create() 
        {
            CarViewModel carModelToCreate = new()
            {
                CarBrands = await this._mediator.Send(new GetCarBrandsQuery()),
                CarModels = await this._mediator.Send(new GetCarModelsQuery())
            };
            return View(carModelToCreate);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePost(CarViewModel newCar) 
        {
            var response = await this._mediator.Send(new CreateCarCommand(newCar));

            return RedirectToAction("Index");
        }
    }
}
