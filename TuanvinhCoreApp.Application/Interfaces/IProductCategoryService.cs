﻿using System;
using System.Collections.Generic;
using System.Text;
using TuanvinhCoreApp.Application.ViewModels.Product;

namespace TuanvinhCoreApp.Application.Interfaces
{
    public interface IProductCategoryService
    {
        ProductCategoryViewModel Add(ProductCategoryViewModel productCategoryViewModel);
        void Update(ProductCategoryViewModel productCategoryViewModel);
        void Delete(int id);
        List<ProductCategoryViewModel> GetAll();
        List<ProductCategoryViewModel> GetAll(string keyword);
        List<ProductCategoryViewModel> GetAllByParentId(int parentId);
        ProductCategoryViewModel GetById(int id);
        void UpdateParentId(int sourceId, int targetId,Dictionary<int,int >Items);
        void ReOrder(int sourcecId, int targetId);
        List<ProductCategoryViewModel> GetHomeCategories(int top);
        void Save();

    }
}
