using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public class CurrencyController : Controller
    {
        // GET
        public IActionResult Index()
        {
            var url = Url.Action(nameof(View), "Currency", new {code = "USD"});
            return Content($"the url is {url}");
        }

        public IActionResult View(string code)
        {
            return Content(code);
        }

        public IActionResult RedirectingToARoute()
        {
            return RedirectToRoute("view_currency", new {code = "GBP"});
        }
    }
}