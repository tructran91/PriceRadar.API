using AutoMapper;

namespace PriceRadar.API
{
    public class ModelMappingProfiles : Profile
    {
        public ModelMappingProfiles()
        {
            //CreateMap<NewsQueryCriteriaModel, NewsQueryCriteriaDto>()
            //    .ForMember(prop => prop.PageNumber, opt => opt.MapFrom(o => ((o.PageNumber == null || o.PageNumber < 0) ? 1 : o.PageNumber)))
            //    .ForMember(prop => prop.PageSize, opt => opt.MapFrom(o => ((o.PageSize == null || o.PageSize < 0) ? 10 : o.PageSize)));

            //CreateMap<NewsRequestModel, NewsRequestDto>()
            //    .ForMember(prop => prop.Id, opt => opt.MapFrom(o => (string.IsNullOrEmpty(o.Id) ? Guid.Empty : Guid.Parse(o.Id))));

            //CreateMap<CrawlingHistoryModel, CrawlingHistoryDto>()
            //    .ForMember(prop => prop.Id, opt => opt.MapFrom(o => (string.IsNullOrEmpty(o.Id) ? Guid.Empty : Guid.Parse(o.Id))));


            //CreateMap<NewsUpdatedModel, NewsUpdatedDto>();
        }
    }
}
