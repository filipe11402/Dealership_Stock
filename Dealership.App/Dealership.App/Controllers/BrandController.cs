using Dealership.App.Mediator.Commands;
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
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Create(CreateBrandViewModel newBrand) 
        {
            var response = await _mediator.Send(new CreateBrandCommand(newBrand));
            if(response) 
            {
                this._unitOfWork.Commit();
            }

            return RedirectToAction("Index");
        }
    }
}
