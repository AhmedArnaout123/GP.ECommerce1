using AutoMapper;
using GP.ECommerce1.Core.Application.Categories.Commands.CreateCategory;
using GP.ECommerce1.Core.Domain;

namespace GP.ECommerce1.Infrastructure.MongoDb;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<CreateCategoryCommand, MongoEntities.Category>()
            .ForMember(c => c.Id, option => option.MapFrom(c => c.Id.ToString()))
            .ForMember(c => c.ParentId, option => option.MapFrom(c => c.ParentId.ToString()));
        
        CreateMap<MongoEntities.Category, Category>()
            .ForMember(c => c.Id, option => option.MapFrom(c => Guid.Parse(c.Id)))
            .ForMember(c => c.ParentId,
                option => option.MapFrom<Guid?>(c => c.ParentId != null ? Guid.Parse(c.ParentId) : null));
    }
}