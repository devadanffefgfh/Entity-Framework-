using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.IO;
using System.Linq;

namespace Entity_Framework練習.Models
{
    public partial class ProductModel : DbContext
    {
        public ProductModel()
            : base("name=ProductModel")
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetCurrentDirectory());
        }

        public virtual DbSet<ProductsTable> ProductsTable { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductsTable>()
                .Property(e => e.ProductPrice)
                .HasPrecision(18, 0);
        }
    }
}
