using Microsoft.AspNetCore.Mvc;
using Task2.Domain.Repositories.RestCountries;

namespace Task2.Controllers
{
    public class IndexController : Controller
    {
        private readonly RCCountryRE countryRE = new RCCountryRE();
        [HttpGet]
        public IActionResult Index()
        {
            return View(countryRE.GetCountriesSorted());
        }
        [HttpPost]
        public IActionResult Index(string search)
        {
            return View(countryRE.GetCountries(search));
        }
    }
}