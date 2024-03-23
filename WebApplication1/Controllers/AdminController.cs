using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace WebApplication1.Controllers
{
    [Authorize(Roles= "adminstrator")]
    public class AdminController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
