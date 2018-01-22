using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TuanvinhCoreApp.Data.EF.Extensions;
using TuanvinhCoreApp.Data.Entities;

namespace TuanvinhCoreApp.Data.EF.Configurations
{
    public class TagConfiguration : DbEntityConfiguration<Tag>
    {
        public override void Configure(EntityTypeBuilder<Tag> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(50).
                IsRequired().HasColumnType("varchar(50)");
        }
    }
}
