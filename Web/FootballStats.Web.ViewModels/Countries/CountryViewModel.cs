namespace FootballStats.Web.ViewModels.Countries
{
    using System;

    using FootballStats.Data.Models;
    using FootballStats.Services.Mapping;

    public class CountryViewModel : IMapFrom<Country>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Abbreviation { get; set; }

        public string UrlImage { get; set; }

        public DateTime CreatedOn { get; set; }

        public int FootballersCount { get; set; }

        public int LeaguesCount { get; set; }

        public int StadiumsCount { get; set; }
    }
}
