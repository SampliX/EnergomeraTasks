using RESTCountries.NET.Models;

namespace Task2.Domain.Repositories.Abstract
{
    public interface ICountryRE
    {
        IQueryable<Country> GetCountries();
        IQueryable<Country> GetCountriesSorted();
        IQueryable<Country> GetCountries(string fullname);
        Country GetCountryByFullname(string fullname);
    }
}
