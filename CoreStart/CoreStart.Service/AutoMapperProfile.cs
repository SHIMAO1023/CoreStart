using AutoMapper;
using CoreStart.Domain.Model;
using CoreStart.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreStart.Service
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserDto, User>().ReverseMap();
        }
    }
}
