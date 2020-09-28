using AutoMapper;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeFinder.WebApi.Mappings
{
    public class WebApiProfile : Profile
    {
        public WebApiProfile()
        {
            MapValues();
        }

        private void MapValues()
        {
            CreateMap<Services.Domain.Buyer, Models.Buyer>().ReverseMap();
            CreateMap<Services.Domain.Comment, Models.Comment>().ReverseMap();
            CreateMap<Services.Domain.House, Models.House>().ReverseMap();
            CreateMap<Services.Domain.HouseProspect, Models.HouseProspect>().ReverseMap();
            CreateMap<Services.Domain.Seller, Models.Seller>().ReverseMap();
        }
    }
}
