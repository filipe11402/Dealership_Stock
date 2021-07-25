using Dealership.App.Mediator.Commands;
using Dealership.App.Mediator.Queries;
using Dealership.App.Models;
using Dealership.Domain.Interfaces;
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

        public CarBrandController(IMediator mediator, IUnitOfWork unitOfWork)
        {
            this._mediator = mediator;
            this._unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<CarBrandViewModel> carBrands = await this._mediator.Send(new GetBrandsQuery());

            return View(carBrands);
        }

        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreatePost(CreateCarBrandViewModel newBrand) 
        {
            var response = await _mediator.Send(new CreateCarBrandCommand(newBrand));
            if (response)
            {
                this._unitOfWork.Commit();
            }

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int? Id)
        {
            CarBrandViewModel brand = await this._mediator.Send(new GetBrandQuery(Id));

            return View(brand);
        }

        [HttpPost]
        public async Task<IActionResult> UpdatePost(CarBrandViewModel updatedBrand) 
        {
            var response = await this._mediator.Send(new UpdateCarBrandCommand(updatedBrand));
            if (response) 
            {
                this._unitOfWork.Commit();
                return RedirectToAction("Index");
            }

            return RedirectToAction("Update");
        }

        public async Task<IActionResult> Delete(int Id) 
        {
            CarBrandViewModel brandToDelete = await this._mediator.Send(new GetBrandQuery(Id));

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
