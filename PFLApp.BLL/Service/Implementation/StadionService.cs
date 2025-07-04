﻿using AutoMapper;
using FluentValidation;
using PFLApp.BLL.Models;
using PFLApp.BLL.Service.Interface;
using PFLApp.BLL.Service.Repository;
using PFLApp.DAL.Entity;
using PFLApp.DAL.Repository.Interface;

namespace PFLApp.BLL.Service.Implementation
{
    public class StadionService : GenericService<Stadion, StadionDto>, IStadionService
    {
        public StadionService(IStadionRepository repository, IMapper mapper, IValidator<StadionDto> validator)
            : base(repository, mapper, validator)
        {
        }
        // Additional methods specific to Stadion can be added here if needed
    }
}
