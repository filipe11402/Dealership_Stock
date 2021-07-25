using AutoMapper;
using Dealership.App.Mediator.Queries;
using Dealership.App.Models.CarModel;
using Dealership.Domain.Entities;
using Dealership.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Dealership.App.Mediator.Handlers
{
    public class GetCarModelsQueryHandler : IRequestHandler<GetCarModelsQuery, IEnumerable<CarModelViewModel>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public GetCarModelsQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this._mapper = mapper;
            this._unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<CarModelViewModel>> Handle(GetCarModelsQuery request, CancellationToken cancellationToken)
        {
            IEnumerable<CarModel> carModels = await this._unitOfWork.Models.GetAll();
            IEnumerable<CarModelViewModel> carModelsToView = this._mapper.Map<IEnumerable<CarModelViewModel>>(carModels);

            return carModelsToView;
        }
    }
}
