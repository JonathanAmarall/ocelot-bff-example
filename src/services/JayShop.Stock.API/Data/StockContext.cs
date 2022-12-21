using JayShoop.Core.Messages;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace JayShop.Stock.API.Data
{
    public class StockContext: DbContext
    {
        public DbSet<Models.Stock> Stocks { get; set; }

        public StockContext(DbContextOptions<StockContext> options) : base(options)
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
