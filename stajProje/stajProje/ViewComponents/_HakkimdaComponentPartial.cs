using Microsoft.AspNetCore.Mvc;

namespace stajProje.ViewComponents
{
    public class _HakkimdaComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}