namespace FootballStats.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using AutoMapper.QueryableExtensions;
    using FootballStats.Data.Common.Repositories;
    using FootballStats.Data.Models;
    using FootballStats.Services.Mapping;
    using FootballStats.Web.ViewModels.Countries;

    public class CountryService : ICountryService
    {
        private readonly IDeletableEntityRepository<Country> countryRepository;

        public CountryService(IDeletableEntityRepository<Country> countryRepository)
        {
            this.countryRepository = countryRepository;
        }

        public IEnumerable<T> GetAllCountries<T>()
        {
            return this.countryRepository.AllAsNoTracking()
                   .To<T>()
                   .ToList();
        }

        public IEnumerable<KeyValuePair<int, string>> GetAllCountriesAsKeyValuePair()
        {
            return this.countryRepository.AllAsNoTracking().Select(x => new
            {
                x.Id,
                x.Name,
            }).OrderBy(x => x.Name)
              .ToList().Select(x => new KeyValuePair<int, string>(x.Id, x.Name));
        }

        public T GetCountryById<T>(int id)
        {
            return this.countryRepository.AllAsNoTracking()
                .Where(x => x.Id == id)
                .To<T>()
                .FirstOrDefault();
        }
    }
}
