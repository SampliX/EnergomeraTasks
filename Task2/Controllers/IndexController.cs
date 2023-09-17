using Task2.Domain.Repositories.RestCountries;
using Task2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}