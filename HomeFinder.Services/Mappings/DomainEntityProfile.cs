using AutoMapper;

namespace HomeFinder.Services.Mappings
{
    public class DomainEntityProfile : Profile
    {
        public DomainEntityProfile()
        {
            MapValues();
        }

        private void MapValues()
        {
            CreateMap<Data.DataObjects.Buyer, Domain.Buyer>().ReverseMap();
            CreateMap<Data.DataObjects.Comment, Domain.Comment>().ReverseMap();
            CreateMap<Data.DataObjects.House, Domain.House>().ReverseMap();
            CreateMap<Data.DataObjects.HouseProspect, Domain.HouseProspect>().ReverseMap();
            CreateMap<Data.DataObjects.Seller, Domain.Seller>().ReverseMap();
        }
    }
}
