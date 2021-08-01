using AutoMapper;
using Dealership.App.Models.CarModel;
using Dealership.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dealership.App.Mappers
{
    public class CarModelProfile : Profile
    {
        public CarModelProfile()
        {
            CreateMap<CarModel, CarModelViewModel>()
                .ForMember(d => d.CarModelId, (o) => o.MapFrom(src => src.CarModelId))
                .ForMember(d => d.CarModelName, (o) => o.MapFrom(src => src.CarModelName));

            CreateMap<CreateCarModelViewModel, CarModel>()
                .ForMember(d => d.CarModelName, (o) => o.MapFrom(src => src.CarModelName));

            CreateMap<CarModelViewModel, CarModel>()
                .ForMember(d => d.CarModelId, (o) => o.MapFrom(src => src.CarModelId))
                .ForMember(d => d.CarModelName, (o) => o.MapFrom(src => src.CarModelName));

            CreateMap<CarModel, UpdateCarModelViewModel>()
                .ForMember(d => d.CarModelId, (o) => o.MapFrom(src => src.CarModelId))
                .ForMember(d => d.CarModelName, (o) => o.MapFrom(src => src.CarModelName));

            CreateMap<UpdateCarModelViewModel, CarModel>()
                .ForMember(d => d.CarModelId, (o) => o.MapFrom(src => src.CarModelId))
                .ForMember(d => d.CarModelName, (o) => o.MapFrom(src => src.CarModelName));
        }
    }
}
