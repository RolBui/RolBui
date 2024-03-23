using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
	[ViewComponent(Name = "_CategorySide")]
		public class _CategorySideViewComponent : ViewComponent
		{
			private readonly WebApplication1Context _context;

			public _CategorySideViewComponent(WebApplication1Context context)
			{
				_context = context;
			}
			public IViewComponentResult Invoke()
			{
				var _category = _context.Category.ToList();
				return View("_CategorySide", _category);
			}
		}
	}
