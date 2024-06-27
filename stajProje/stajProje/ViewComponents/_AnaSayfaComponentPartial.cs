using Microsoft.AspNetCore.Mvc;

namespace stajProje.ViewComponents
{
    public class _AnaSayfaComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
