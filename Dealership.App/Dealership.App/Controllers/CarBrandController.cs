using AutoMapper;
using Dealership.App.FluentValidation;
using Dealership.App.Mediator.Commands;
using Dealership.App.Mediator.Queries;
using Dealership.App.Models.CarBrand;
using Dealership.Domain.Entities;
using Dealership.Domain.Interfaces;
using FluentValidation.AspNetCore;
using FluentValidation.Results;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dealership.App.Controllers
{
    public class CarBrandController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CarBrandController(IMediator mediator, IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._mediator = mediator;
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<CarBrandViewModel> carBrands = await this._mediator.Send(new GetCarBrandsQuery());

            return View(carBrands);
        }

        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreatePost(CreateCarBrandViewModel newBrand) 
        {
            if(ModelState.IsValid)
            {
                var response = await _mediator.Send(new CreateCarBrandCommand(newBrand));
                if (response)
                {
                    this._unitOfWork.Commit();
                }

                return RedirectToAction("Index");
            }

            return View("Create");
        }

        public async Task<IActionResult> Update(int? Id)
        {
            CarBrand brand = await this._mediator.Send(new GetCarBrandQuery(Id));
            UpdateCarBrandViewModel brandToView = this._mapper.Map<UpdateCarBrandViewModel>(brand);

            return View(brandToView);
        }

        [HttpPost]
        public async Task<IActionResult> UpdatePost(UpdateCarBrandViewModel updatedBrand) 
        {
            var response = await this._mediator.Send(new UpdateCarBrandCommand(updatedBrand));

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
            CarBrand brand = await this._mediator.Send(new GetCarBrandQuery(Id));
            CarBrandViewModel brandToDelete = this._mapper.Map<CarBrandViewModel>(brand);

            return View(brandToDelete);
        }

        [HttpPost]
        public async Task<IActionResult> DeletePost(int CarBrandId) 
        {
            var deleteResponse = await this._mediator.Send(new DeleteCarBrandCommand(CarBrandId));

            if (deleteResponse) 
            {
                this._unitOfWork.Commit();
            }

            return RedirectToAction("Index");
        }
    }
}
