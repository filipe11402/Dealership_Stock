using AutoMapper;
using Dealership.App.Models;
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
            CreateMap<BrandViewModel, CarBrand>()
                .ForMember(d => d.CarBrandId, (o) => o.MapFrom(o => o.CarBrandId))
                .ForMember(d => d.CarBrandName, (o) => o.MapFrom(o => o.CarBrandName));

            CreateMap<CarBrand, BrandViewModel>()
                .ForMember(d => d.CarBrandId, (o) => o.MapFrom(o => o.CarBrandId))
                .ForMember(d => d.CarBrandName, (o) => o.MapFrom(o => o.CarBrandName));

            CreateMap<CreateBrandViewModel, CarBrand>()
                .ForMember(d => d.CarBrandName, (o) => o.MapFrom(o => o.CarBrandName));
        }
    }
}
