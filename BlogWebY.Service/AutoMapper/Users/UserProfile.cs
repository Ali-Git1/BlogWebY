using AutoMapper;
using BlogWebY.Entity.DTOs.Categories;
using BlogWebY.Entity.DTOs.Users;
using BlogWebY.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebY.Service.AutoMapper.Users
{
    public class UserProfile:Profile
    {
        public UserProfile()
        {
            CreateMap<AppUser, UserDto>().ReverseMap();
            CreateMap<AppUser, UserAddDto>().ReverseMap();
            CreateMap<AppUser, UserUpdateDto>().ReverseMap();
            CreateMap<AppUser, UserProfileDto>().ReverseMap();
          
        }
    }
}
