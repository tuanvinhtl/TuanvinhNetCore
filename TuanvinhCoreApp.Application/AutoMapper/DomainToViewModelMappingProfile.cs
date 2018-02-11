using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TuanvinhCoreApp.Application.ViewModels.Product;
using TuanvinhCoreApp.Data.Entities;

namespace TuanvinhCoreApp.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ProductCategory, ProductCategoryViewModel>();
        }
    }
}
