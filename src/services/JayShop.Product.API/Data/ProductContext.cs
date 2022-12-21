using JayShoop.Core.Messages;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace JayShop.Product.API.Data
{
    public class ProductContext : DbContext
    {
        public DbSet<Models.Product> Products { get; set; }

        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Ignore<Event>();
            builder.Ignore<ValidationResult>();

            base.OnModelCreating(builder);
        }
    }
}
