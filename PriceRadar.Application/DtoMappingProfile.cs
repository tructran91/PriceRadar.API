using AutoMapper;

namespace PriceRadar.Application
{
    public class DtoMappingProfile : Profile
    {
        public DtoMappingProfile()
        {
            //CreateMap<NewsRequestDto, News>()
            //    .ForMember(prop => prop.Id, opt => opt.MapFrom(o => ((o.Id == null || o.Id == Guid.Empty) ? Guid.NewGuid() : o.Id)))
            //    .ForMember(prop => prop.IsDeleted, opt => opt.MapFrom(o => false))
            //    .ForMember(prop => prop.CreatedOn, opt => opt.MapFrom(o => DateTime.UtcNow));
        }
    }
}
