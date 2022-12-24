using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly_2nd_try.Dtos;
using Vidly_2nd_try.Models;

namespace Vidly_2nd_try.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDtos>();
            //Mapper.CreateMap<CustomerDtos, Customer>();

            Mapper.CreateMap<Movie, MovieDto>();


            // Dto to Domain
            Mapper.CreateMap<CustomerDtos, Customer>()
                .ForMember(c => c.Id, opt => opt.Ignore());

            Mapper.CreateMap<MovieDto, Movie>()
                .ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}