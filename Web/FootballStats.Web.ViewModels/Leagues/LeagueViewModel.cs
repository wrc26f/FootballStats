namespace FootballStats.Web.ViewModels.Leagues
{
    using System;

    using FootballStats.Data.Models;

    using FootballStats.Services.Mapping;

    public class LeagueViewModel : IMapFrom<League>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string UrlImage { get; set; }

        public Country Country { get; set; }

        public DateTime CreatedOn { get; set; }

        public int TeamsCount { get; set; }

    }
}
