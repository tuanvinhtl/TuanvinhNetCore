using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TuanvinhCoreApp.Infrastructure.SharedKernel;

namespace TuanvinhCoreApp.Data.Entities
{
    public class ProductTag : DomainEntity<int>
    {
        public int ProductId { get; set; }


        [StringLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string TagId { get; set; }
        public virtual Product Product { get; set; }
        public virtual Tag Tag { set; get; }

    }
}
