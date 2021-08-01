using AutoMapper;
using Dealership.App.Models.CarBrand;
using Dealership.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dealership.App.Mappers
{
    public class CarBrandProfile : Profile
    {
        public CarBrandProfile()
        {
            CreateMap<CarBrandViewModel, CarBrand>()
                .ForMember(d => d.CarBrandId, (o) => o.MapFrom(o => o.CarBrandId))
                .ForMember(d => d.CarBrandName, (o) => o.MapFrom(o => o.CarBrandName));

            CreateMap<CarBrand, CarBrandViewModel>()
                .ForMember(d => d.CarBrandId, (o) => o.MapFrom(o => o.CarBrandId))
                .ForMember(d => d.CarBrandName, (o) => o.MapFrom(o => o.CarBrandName));

            CreateMap<CreateCarBrandViewModel, CarBrand>()
                .ForMember(d => d.CarBrandName, (o) => o.MapFrom(o => o.CarBrandName));

            CreateMap<CarBrand, UpdateCarBrandViewModel>()
                .ForMember(d => d.CarBrandId, (o) => o.MapFrom(src => src.CarBrandId))
                .ForMember(d => d.CarBrandName, (o) => o.MapFrom(src => src.CarBrandName));

            CreateMap<UpdateCarBrandViewModel, CarBrand>()
                .ForMember(d => d.CarBrandId, (o) => o.MapFrom(src => src.CarBrandId))
                .ForMember(d => d.CarBrandName, (o) => o.MapFrom(src => src.CarBrandName));
        }
    }
}
