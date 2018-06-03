using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PrDC.Products.Web.Model;

namespace PrDC.Products.Web
{
    public class IndexModel : PageModel
    {
        private readonly PrDC.Products.Web.ProductsContext _context;

        public IndexModel(PrDC.Products.Web.ProductsContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Products.ToListAsync();
        }
    }
}
