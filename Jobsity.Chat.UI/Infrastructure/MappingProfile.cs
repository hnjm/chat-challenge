﻿using AutoMapper;
using Jobsity.Chat.Contracts.DTOs;
using Jobsity.Chat.DataContext.Models;

namespace Jobsity.Chat.UI.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ApplicationUser, UserDto>()
                .ForMember(m => m.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(m => m.UserName, opt => opt.MapFrom(src => src.UserName))
                .ForMember(m => m.Email, opt => opt.MapFrom(src => src.Email))
                .ReverseMap();
        }
    }
}
