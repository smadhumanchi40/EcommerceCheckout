﻿using CheckoutSys.Web.Areas.Admin.Models;
using AutoMapper;
using Microsoft.AspNetCore.Identity;

namespace CheckoutSys.Web.Areas.Admin.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<IdentityRole, RoleViewModel>().ReverseMap();
        }
    }
}