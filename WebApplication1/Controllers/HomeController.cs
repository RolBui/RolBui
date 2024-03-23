using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
		private readonly WebApplication1Context _context;

		public HomeController(WebApplication1Context context)
        {
			_context = context;
		}

        
        public IActionResult Index()
        {
			var _product = _context.Product.Include(p => p.Brand).Include(p => p.Category);
			return View(_product.ToList());
			
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}