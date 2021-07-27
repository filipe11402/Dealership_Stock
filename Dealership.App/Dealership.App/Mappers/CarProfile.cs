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
                .ForMember(d => d.CarId, (o) => o.MapFrom(src => src.CarId))
                .ForMember(d => d.ImageName, (o) => o.MapFrom(src => src.ImageName))
                .ForMember(d => d.ImageFile, (o) => o.MapFrom(src => src.Image));
        }
    }
}
