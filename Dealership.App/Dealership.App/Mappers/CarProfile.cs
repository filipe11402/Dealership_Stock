using AutoMapper;
using Dealership.App.Models.Car;
using Dealership.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dealership.App.Mappers
{
    public class CarProfile : Profile
    {
        public CarProfile()
        {
            CreateMap<CarViewModel, Car>()
                .ForMember(d => d.Brand, (o) => o.MapFrom(src => src.CarBrand))
                .ForMember(d => d.Model, (o) => o.MapFrom(src => src.CarModel))
                .ForMember(d => d.ImageName, (o) => o.MapFrom(src => src.ImageName))
                .ForMember(d => d.ImageFile, (o) => o.MapFrom(src => src.Image));
        }
    }
}
