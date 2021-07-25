using Dealership.App.Mediator.Commands;
using Dealership.App.Mediator.Queries;
using Dealership.App.Models.CarModel;
using Dealership.Domain.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dealership.App.Controllers
{
    public class CarModelController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;

        public CarModelController(IMediator mediator, IUnitOfWork unitOfWork)
        {
            this._mediator = mediator;
            this._unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<CarModelViewModel> models = await this._mediator.Send(new GetCarModelsQuery());

            return View(models);
        }

        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreatePost(CreateCarModelViewModel newCarModel) 
        {
            var response = await this._mediator.Send(new CreateCarModelCommand(newCarModel));
            if (response) 
            {
                this._unitOfWork.Commit();
                return RedirectToAction("Index");
            }

            return RedirectToAction("Create", new { newCarModel = newCarModel });
        }

        public async Task<IActionResult> Update(int Id) 
        {
            CarModelViewModel carModelToUpdate = await this._mediator.Send(new GetCarModelQuery(Id));
            if (carModelToUpdate == null) 
            {
                return RedirectToAction("Index");
            }

            return View(carModelToUpdate);
        }
    }
}
