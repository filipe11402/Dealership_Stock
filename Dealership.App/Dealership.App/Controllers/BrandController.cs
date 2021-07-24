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
    public class BrandController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;

        public BrandController(IMediator mediator, IUnitOfWork unitOfWork)
        {
            this._mediator = mediator;
            this._unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<BrandViewModel> carBrands = await this._mediator.Send(new GetBrandsQuery());

            return View(carBrands);
        }

        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreatePost(CreateBrandViewModel newBrand) 
        {
            var response = await _mediator.Send(new CreateBrandCommand(newBrand));
            if (response)
            {
                this._unitOfWork.Commit();
            }

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int? Id)
        {
            BrandViewModel brand = await this._mediator.Send(new GetBrandQuery(Id));

            return View(brand);
        }

        [HttpPost]
        public async Task<IActionResult> UpdatePost(BrandViewModel updatedBrand) 
        {
            var response = await this._mediator.Send(new UpdateBrandCommand(updatedBrand));
            if (response) 
            {
                this._unitOfWork.Commit();
                return RedirectToAction("Index");
            }

            return RedirectToAction("Update");
        }
    }
}
