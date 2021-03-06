﻿using System;
using PhotoContest.App.Models.Photos.Contests;

namespace PhotoContest.App
{
    using System.Collections.Generic;

    using AutoMapper;
    using PhotoContest.App.Models.Photos.Users;
    using PhotoContest.App.Models.ViewModels;
    using PhotoContest.Models.Models;
    using PhotoContest.App.Models.Photos.BindingModels;
    using PhotoContest.App.Models.BindingModels.Contests;
    using PhotoContest.App.Models.ViewModels.Contests;

    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.CreateMap<Contest, ContestViewModel>();
            Mapper.CreateMap<User, ProfileViewModel>();
            Mapper.CreateMap<ContestBindingModel, Contest>();
            Mapper.CreateMap<User, EditProfileModel>();
            Mapper.CreateMap<AddPhotoBindingModel, Photo>();
            Mapper.CreateMap<Photo, PhotoViewModel>();
            Mapper.CreateMap<Photo, EditPhotoModel>();
            Mapper.CreateMap<EditPhotoModel, Photo>();
            Mapper.CreateMap<Photo, ViewPhotoModel>();
        }
    }
}