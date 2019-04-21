using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication.Controllers
{
    public class CurrencyController : Controller
    {
        static readonly Dictionary<string, decimal> AllCurrencies =
            new Dictionary<string, decimal>
            {
                {"GBP", 1.00m},
                {"USD", 1.22m},
                {"CAD", 1.64m},
                {"EUR", 1.15m},
            };
        // GET
        public IActionResult Index()
        {
//            var url = Url.Action(nameof(View), "Currency", new {code = "USD"});
//            return Content($"the url is {url}");
            
            var model = AllCurrencies.Select(x => new SelectListItem { Text = x.Key }).ToList();

            return View(model);
        }
        
        [HttpPost]
        public IActionResult ShowRates(List<string> currencies)
        {
            var selectedCurrencies =
                AllCurrencies.Where(x => currencies.Contains(x.Key))
                    .ToDictionary(x => x.Key, x => x.Value);
            return View(selectedCurrencies);
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