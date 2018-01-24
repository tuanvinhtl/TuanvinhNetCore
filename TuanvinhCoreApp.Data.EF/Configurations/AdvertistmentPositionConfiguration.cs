﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TuanvinhCoreApp.Data.EF.Extensions;
using TuanvinhCoreApp.Data.Entities;

namespace TuanvinhCoreApp.Data.EF.Configurations
{
    public class AdvertistmentPositionConfiguration : DbEntityConfiguration<AdvertistmentPosition>
    {
        public override void Configure(EntityTypeBuilder<AdvertistmentPosition> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(20).IsRequired();
        }
    }
}
