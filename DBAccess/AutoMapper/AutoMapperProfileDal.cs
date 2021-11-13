using AutoMapper;
using DBAccess.Entities;
using DomainService.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAccess.AutoMapper
{
    public class AutoMapperProfileDal : Profile    
    {
        public AutoMapperProfileDal()
        {
            CreateMap<UserDto, User>();
            CreateMap<User, UserDto>();
        }
        
    }
}
