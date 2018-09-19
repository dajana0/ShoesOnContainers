using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductCatalogAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalogAPI.Data
{
    public class CatalogContext: DbContext
    {
        public CatalogContext(DbContextOptions options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<CatalogBrand>(ConfigureCatalogBrand);
            builder.Entity<CatalogType>(ConfigureCatalogType);
            builder.Entity<CatalogItem>(ConfigureCatalogItem);
        }

        private void ConfigureCatalogItem(EntityTypeBuilder<CatalogItem> obj)
        {
            throw new NotImplementedException();
        }

        private void ConfigureCatalogType(EntityTypeBuilder<CatalogType> obj)
        {
            throw new NotImplementedException();
        }

        private void ConfigureCatalogBrand(EntityTypeBuilder<CatalogBrand> obj)
        {
            throw new NotImplementedException();
        }
    }
}
