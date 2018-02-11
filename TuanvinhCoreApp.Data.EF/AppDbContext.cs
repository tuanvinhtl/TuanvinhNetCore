using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TuanvinhCoreApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using TuanvinhCoreApp.Data.EF.Extensions;
using TuanvinhCoreApp.Data.EF.Configurations;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using TuanvinhCoreApp.Data.Interfaces;

namespace TuanvinhCoreApp.Data.EF
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products { set; get; }
        public DbSet<ProductCategory> ProductCategories { set; get; }
        public DbSet<ProductTag> ProductTags { set; get; }
        public DbSet<ProductImage> ProductImages { set; get; }
        public DbSet<Size> Sizes { set; get; }
        public DbSet<Slide> Slides { set; get; }
        public DbSet<Tag> Tags { set; get; }
        public DbSet<WholePrice> WholePrices { set; get; }
        public DbSet<Advertistment> Advertistments { set; get; }
        public DbSet<AdvertistmentPage> AdvertistmentPages { set; get; }
        public DbSet<AdvertistmentPosition> AdvertistmentPositions { set; get; }
        public DbSet<Announcement> Announcements { set; get; }
        public DbSet<AnnouncementUser> AnnouncementUsers { set; get; }
        public DbSet<Bill> Bills { set; get; }
        public DbSet<BillDetail> BillDetails { set; get; }
        public DbSet<Blog> Blogs { set; get; }
        public DbSet<BlogTag> BlogTags { set; get; }
        public DbSet<Color> Colors { set; get; }
        public DbSet<ContactDetail> ContactDetails { set; get; }
        public DbSet<Feedback> Feedbacks { set; get; }
        public DbSet<Footer> Footers { set; get; }
        public DbSet<Function> Functions { set; get; }
        public DbSet<Language> Languages { set; get; }
        public DbSet<Page> Pages { set; get; }
        public DbSet<Permission> Permissions { set; get; }
        public DbSet<SystemConfig> SystemConfigs { set; get; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<IdentityUserClaim<string>>().ToTable("AppUserClaims").HasKey(x => x.Id);
            builder.Entity<IdentityRoleClaim<string>>().ToTable("AppRoleClaims").HasKey(x => x.Id);
            builder.Entity<IdentityUserLogin<string>>().ToTable("AppUserLogins").HasKey(x => x.UserId);
            builder.Entity<IdentityUserRole<string>>().ToTable("AppUserRoles").HasKey(x => new { x.RoleId, x.UserId });
            builder.Entity<IdentityUserToken<string>>().ToTable("AppUserTokens").HasKey(x => new { x.UserId });
            builder.AddConfiguration(new TagConfiguration());
            builder.AddConfiguration(new BlogTagConfiguration());
            builder.AddConfiguration(new ContactDetailConfiguration());
            builder.AddConfiguration(new FooterConfiguration());
            builder.AddConfiguration(new PageConfiguration());
            builder.AddConfiguration(new PageConfiguration());
            builder.AddConfiguration(new ProductTagConfiguration());
            builder.AddConfiguration(new SystemConfigConfiguration());
            builder.AddConfiguration(new AdvertistmentPositionConfiguration());
            base.OnModelCreating(builder);
        }

        public override int SaveChanges()
        {
            var modified = ChangeTracker.Entries().Where(e => e.State == EntityState.Modified || e.State == EntityState.Added);
            foreach (EntityEntry item in modified)
            {
                var changeOrAdded = item.Entity as IDateTracking;
                if (changeOrAdded != null)
                {
                    if (item.State == EntityState.Added)
                    {
                        changeOrAdded.DateCreated = DateTime.Now;
                    }
                }
            }
            return base.SaveChanges();
        }
    }
}
