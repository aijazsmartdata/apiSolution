using APIProject.Models;
using AutoMapper;
using DomainService.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIProject.Automapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<SignupRequestModel, UserDto>();
        }
    }
}
