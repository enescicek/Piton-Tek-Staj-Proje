using Microsoft.AspNetCore.Mvc;
using stajProje.DAL.Context;

namespace stajProje.ViewComponents
{
    public class _NotlarComponentPartial : ViewComponent
    {
        stajProjeContext stajProjeContext = new stajProjeContext();
        public IViewComponentResult Invoke()
        {
            var values = stajProjeContext.NoteInfos.ToList(); 
            return View(values);
        }
    }
}
