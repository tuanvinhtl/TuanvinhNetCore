using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TuanvinhCoreApp.Application.Interfaces;
using TuanvinhCoreApp.Application.ViewModels.Product;
using TuanvinhCoreApp.Data.Entities;
using TuanvinhCoreApp.Data.Enums;
using TuanvinhCoreApp.Data.IReportsitories;
using TuanvinhCoreApp.Infrastructure.Interfaces;

namespace TuanvinhCoreApp.Application.Implementations
{
    public class ProductCategoryService : IProductCategoryService
    {

        private IProductCategoryRepository _productCategoryRepository;
        private IUnitOfWork _unitOfWork;
        public ProductCategoryService(IUnitOfWork unitOfWork, IProductCategoryRepository productCategoryRepository)
        {
            _productCategoryRepository = productCategoryRepository;
            _unitOfWork = unitOfWork;
        }

        public ProductCategoryViewModel Add(ProductCategoryViewModel productCategoryViewModel)
        {
            var productCategory = Mapper.Map<ProductCategoryViewModel, ProductCategory>(productCategoryViewModel);
            _productCategoryRepository.Add(productCategory);
            return productCategoryViewModel;
        }

        public void Delete(int id)
        {
            _productCategoryRepository.Remove(id);
        }

        public List<ProductCategoryViewModel> GetAll()
        {
            return _productCategoryRepository.FindAll().OrderBy(x => x.ParentId).
                ProjectTo<ProductCategoryViewModel>().ToList();
        }

        public List<ProductCategoryViewModel> GetAll(string keyword)
        {
            if (!string.IsNullOrEmpty(keyword))
            {
                return _productCategoryRepository.FindAll(x => x.Name.Contains(keyword) || x.Description.Contains(keyword)).
                    OrderBy(x => x.ParentId).ProjectTo<ProductCategoryViewModel>().ToList();
            }
            else
            {
                return _productCategoryRepository.FindAll().OrderBy(x => x.ParentId).
                ProjectTo<ProductCategoryViewModel>().ToList();
            }
        }

        public List<ProductCategoryViewModel> GetAllByParentId(int parentId)
        {
            return _productCategoryRepository.FindAll(x => x.Status == Status.Active && x.ParentId == parentId).
                ProjectTo<ProductCategoryViewModel>().ToList();
        }

        public ProductCategoryViewModel GetById(int id)
        {
            return Mapper.Map<ProductCategory, ProductCategoryViewModel>(_productCategoryRepository.FindById(id));
        }

        public List<ProductCategoryViewModel> GetHomeCategories(int top)
        {
            throw new NotImplementedException();
        }

        public void ReOrder(int sourcecId, int targetId)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Update(ProductCategoryViewModel productCategoryViewModel)
        {
            var productCategory = Mapper.Map<ProductCategoryViewModel, ProductCategory>(productCategoryViewModel);
            _productCategoryRepository.Update(productCategory);
        }

        public void UpdateParentId(int sourceId, int targetId, Dictionary<int, int> Items)
        {
            throw new NotImplementedException();
        }
    }
}
