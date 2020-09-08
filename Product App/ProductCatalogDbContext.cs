using Microsoft.EntityFrameworkCore;
using Product_App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product_App
{
	public class ProductCatalogDbContextDbContext: DbContext
	{
		public ProductCatalogDbContextDbContext() { }
		public ProductCatalogDbContextDbContext(DbContextOptions<ProductCatalogDbContextDbContext> options) : base(options) { }
		public DbSet<Product> Songs { get; set; }
	}
}
