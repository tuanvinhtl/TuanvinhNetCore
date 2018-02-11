using System;
using System.Collections.Generic;
using System.Text;
using TuanvinhCoreApp.Data.Entities;
using TuanvinhCoreApp.Infrastructure.Interfaces;

namespace TuanvinhCoreApp.Data.IReportsitories
{
    public interface IProductCategoryRepository : IRepository<ProductCategory, int>
    {
        List<ProductCategory> GetByAlias(string alias);
    }
}
