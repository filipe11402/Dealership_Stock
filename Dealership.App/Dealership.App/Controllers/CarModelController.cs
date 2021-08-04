using AutoMapper;
using Dealership.App.Mediator.Commands;
using Dealership.App.Mediator.Queries;
using Dealership.App.Models.CarModel;
using Dealership.Domain.Entities;
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
        private readonly IMapper _mapper;

        public CarModelController(IMediator mediator, IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._mediator = mediator;
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
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

            if (ModelState.IsValid) 
            {
                if (response)
                {
                    this._unitOfWork.Commit();
                    return RedirectToAction("Index");
                }
            }

            return View("Create");
        }

        public async Task<IActionResult> Update(int Id) 
        {
            CarModel carModel = await this._mediator.Send(new GetCarModelQuery(Id));
            if (carModel == null) 
            {
                return RedirectToAction("Index");
            }
            UpdateCarModelViewModel carModelToUpdate = this._mapper.Map<UpdateCarModelViewModel>(carModel);

            return View(carModelToUpdate);
        }

        [HttpPost]
        public async Task<IActionResult> UpdatePost(UpdateCarModelViewModel updatedCarModel)
        {
            var response = await this._mediator.Send(new UpdateCarModelCommand(updatedCarModel));

            if (ModelState.IsValid) 
            {
                if (response)
                {
                    this._unitOfWork.Commit();
                    return RedirectToAction("Index");
                }
            }

            return View("Update");
        }

        public async Task<IActionResult> Delete(int Id)
        {
            CarModel carModel = await this._mediator.Send(new GetCarModelQuery(Id));
            if (carModel == null) 
            {
                return RedirectToAction("Index");
            }
            CarModelViewModel carModelToDelete = this._mapper.Map<CarModelViewModel>(carModel);

            return View(carModelToDelete);
        }

        [HttpPost]
        public async Task<IActionResult> DeletePost(int CarModelId) 
        {
            var response = await this._mediator.Send(new DeleteCarModelCommand(CarModelId));
            this._unitOfWork.Commit();

            return RedirectToAction("Index");
        }
    }
}
