using Microsoft.AspNetCore.Mvc;

namespace Matsiushenka.UI.Components
{
	public class CartViewComponent: ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
