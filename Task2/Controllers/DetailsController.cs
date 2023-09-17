using Microsoft.AspNetCore.Mvc;
using Task2.Domain.Repositories.RestCountries;

namespace Task2.Controllers
{
    public class DetailsController : Controller
    {
        private readonly RCCountryRE countryRE = new RCCountryRE();
        [HttpGet]
        public IActionResult Index(string fullname)
        {
            return View(countryRE.GetCountryByFullname(fullname));
        }
    }
}
