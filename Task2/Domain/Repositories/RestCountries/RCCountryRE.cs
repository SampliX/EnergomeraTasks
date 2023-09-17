using RESTCountries.NET.Models;
using RESTCountries.NET.Services;
using Task2.Domain.Repositories.Abstract;

namespace Task2.Domain.Repositories.RestCountries
{
    public class RCCountryRE : ICountryRE
    {
        public IQueryable<Country> GetCountries()
        {
            return RestCountriesService.GetAllCountries().AsQueryable();
        }

        public IQueryable<Country> GetCountries(string fullname)
        {
            if (fullname != null)
                return RestCountriesService.GetAllCountries().AsQueryable().Where(x => x.Name.Official.ToLower().Contains(fullname.ToLower()));
            else
                return GetCountriesSorted();
        }

        public IQueryable<Country> GetCountriesSorted()
        {
            return RestCountriesService.GetAllCountries().OrderBy(x => x.Name.Official).AsQueryable();
        }

        public Country GetCountryByFullname(string fullname)
        {
            return RestCountriesService.GetCountryByFullName(fullname);
        }
    }
}
