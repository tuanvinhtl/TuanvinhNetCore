using AutoMapper;
using TuanvinhCoreApp.Application.ViewModels.Product;
using TuanvinhCoreApp.Data.Entities;

namespace TuanvinhCoreApp.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ProductCategoryViewModel, ProductCategory>()
                .ConstructUsing(c=>new ProductCategory(c.Name,c.Description,c.ParentId,c.HomeOrder,c.Image,c.HomeFlag,c.SeoPageTitle,c.SeoAlias
                ,c.SeoKeywords,c.SeoDescription,c.Status,c.SortOrder));
            
        }
    }
}
