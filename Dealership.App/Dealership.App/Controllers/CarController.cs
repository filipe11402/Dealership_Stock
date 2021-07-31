using AutoMapper;
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
        private readonly IMapper _mapper;


        public CarController(IMediator mediator, IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._mediator = mediator;
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<CarViewModel> carsToView = await this._mediator.Send(new GetCarsQuery());

            return View(carsToView);
        }

        public async Task<IActionResult> Create() 
        {
            CreateCarViewModel carModelToCreate = new()
            {
                CarBrands = await this._mediator.Send(new GetCarBrandsQuery()),
                CarModels = await this._mediator.Send(new GetCarModelsQuery())
            };
            return View(carModelToCreate);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePost(CreateCarViewModel newCar) 
        {
            var response = await this._mediator.Send(new CreateCarCommand(newCar));

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int Id) 
        {
            var carToView = await this._mediator.Send(new GetCarQuery(Id));
            UpdateCarViewModel updateCarModel = this._mapper.Map<UpdateCarViewModel>(carToView);
            updateCarModel.CarBrands = await this._mediator.Send(new GetCarBrandsQuery());
            updateCarModel.CarModels = await this._mediator.Send(new GetCarModelsQuery());

            return View(updateCarModel);
        }

        [HttpPost]
        public async Task<IActionResult> UpdatePost(UpdateCarViewModel updatedCar) 
        {
            var updateResponse = await this._mediator.Send(new UpdateCarCommand(updatedCar));

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int Id) 
        {
            var car = await this._mediator.Send(new GetCarQuery(Id));
            CarViewModel carToDelete = this._mapper.Map<CarViewModel>(car);
            if (carToDelete == null) 
            {
                return RedirectToAction("Index");
            }

            return View(carToDelete);
        }

        [HttpPost]
        public async Task<IActionResult> DeletePost(int carToDeleteId) 
        {
            var deleteResponse = await this._mediator.Send(new DeleteCarCommand(carToDeleteId));

            return RedirectToAction("Index");
        }
    }
}
