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
            CreateMap<CreateCarViewModel, Car>()
                .ForMember(d => d.CarId, (o) => o.MapFrom(src => src.CarId))
                .ForMember(d => d.ImageName, (o) => o.MapFrom(src => src.ImageName))
                .ForMember(d => d.ImageFile, (o) => o.MapFrom(src => src.Image));

            CreateMap<Car, CarViewModel>()
                .ForMember(d => d.CarId, (o) => o.MapFrom(src => src.CarId))
                .ForMember(d => d.CarBrand, (o) => o.MapFrom(src => src.Brand))
                .ForMember(d => d.CarModel, (o) => o.MapFrom(src => src.Model));
            //.ForMember(d => d.ImageName, (o) => o.MapFrom(src => src.ImageName))
            //.ForMember(d => d.ImageFile, (o) => o.MapFrom(src => src.Image));

            CreateMap<Car, UpdateCarViewModel>()
                .ForMember(d => d.CarId, (o) => o.MapFrom(src => src.CarId))
                .ForMember(d => d.ImageName, (o) => o.MapFrom(src => src.ImageName));

            CreateMap<UpdateCarViewModel, Car>()
                .ForMember(d => d.CarId, (o) => o.MapFrom(src => src.CarId))
                .ForMember(d => d.ImageName, (o) => o.MapFrom(src => src.ImageName))
                .ForMember(d => d.ImageFile, (o) => o.MapFrom(src => src.Image));
        }
    }
}
