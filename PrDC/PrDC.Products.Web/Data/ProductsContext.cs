using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PrDC.Products.Web.Model;

namespace PrDC.Products.Web
{
    public class ProductsContext : DbContext
    {
        public ProductsContext (DbContextOptions<ProductsContext> options)
            : base(options)
        {
        }

        public DbSet<PrDC.Products.Web.Model.Product> Products { get; set; }
    }
}
