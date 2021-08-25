namespace FootballStats.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface ICountryService
    {
        IEnumerable<KeyValuePair<int, string>> GetAllCountriesAsKeyValuePair();

        IEnumerable<T> GetAllCountries<T>();

        T GetCountryById<T>(int id);
    }
}
