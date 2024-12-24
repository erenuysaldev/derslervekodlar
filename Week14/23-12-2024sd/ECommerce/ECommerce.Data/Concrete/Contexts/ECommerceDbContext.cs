using ECommerce.Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Concrete.Contexts
{
    public class ECommerceDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options) : base(options)
        {

        }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            #region ProductCategory
            builder.Entity<ProductCategory>().HasKey(x => new { x.ProductId, x.CategoryId });
            #endregion


            #region Category
            builder.Entity<Category>().HasKey(x => x.Id );
            builder.Entity<Category>().Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Entity<Category>().Property(x=> x.CreatedDate).HasDefaultValueSql("GETDATE()");
            //builder.Entity<Category>().Property(x => x.Name).HasColumnType("VARCHAR");
            builder.Entity<Category>().Property(x => x.Name).HasMaxLength(100);
            #endregion

            #region Product 
            builder.Entity<Product>().HasKey(x => x.Id);
            builder.Entity<Product>().Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Entity<Product>().Property(x => x.CreatedDate).HasDefaultValueSql("GETDATE()");
            builder.Entity<Product>().HasMany(x => x.ProductCategories).WithOne(x => x.Product);




            //builder.Entity<Product>().Property(x => x.Name).HasMaxLength(100);
            //builder.Entity<Product>().Property(x => x.Price).HasColumnType("decimal(18,2)");
            //builder.Entity<Product>().HasMany(x => x.ProductCategories).WithOne(x => x.Product).HasForeignKey(x => x.ProductId);


            #endregion







            base.OnModelCreating(builder);
        }
    }
}
