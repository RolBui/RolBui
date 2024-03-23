using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
	[ViewComponent(Name = "_Category")]
	public class _CategoryViewComponent : ViewComponent
	{
		private readonly WebApplication1Context _context;

		public _CategoryViewComponent(WebApplication1Context context)
		{
			_context = context;
		}
		public IViewComponentResult Invoke() {
			var _category = _context.Category.ToList();
			return View("_Category", _category);
		}
	}
}
