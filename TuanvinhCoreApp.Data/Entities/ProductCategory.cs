﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TuanvinhCoreApp.Data.Enums;
using TuanvinhCoreApp.Data.Interfaces;
using TuanvinhCoreApp.Infrastructure.SharedKernel;

namespace TuanvinhCoreApp.Data.Entities
{
    [Table("ProductCategories")]
    public class ProductCategory : DomainEntity<int>, IHasSeoMetaData, ISwitchable, ISortable, IDateTracking
    {
        public ProductCategory()
        {
            Products = new List<Product>();
        }

        public ProductCategory(string name, string decription, int? parentId
            , int? homeOrder, string image, bool? homeFlag, string seoPageTitle, string seoAlias, string seoKeyword
            , string seoDescription, Status status, int sortOrder)
        {
            Name = name;
            Description = decription;
            ParentId = parentId;
            HomeOrder = homeOrder;
            Image = image;
            HomeFlag = homeFlag;
            SeoPageTitle = seoPageTitle;
            SeoAlias = seoAlias;
            SeoKeywords = seoKeyword;
            SeoDescription = seoDescription;
            Status = status;
            SortOrder = sortOrder;

        }
        [StringLength(255)]
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ParentId { get; set; }
        public int? HomeOrder { get; set; }
        public string Image { get; set; }
        public bool? HomeFlag { get; set; }

        public string SeoPageTitle { set; get; }
        [Column(TypeName = "varchar(255)")]
        [StringLength(255)]
        public string SeoAlias { set; get; }
        public string SeoKeywords { set; get; }
        public string SeoDescription { set; get; }
        public Status Status { set; get; }
        public int SortOrder { set; get; }
        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }

        public virtual ICollection<Product> Products { set; get; }
    }
}
