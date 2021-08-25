namespace FootballStats.Web.ViewModels.Home
{
    using System;
    using System.Collections.Generic;

    using FootballStats.Web.ViewModels.Leagues;
    using FootballStats.Web.ViewModels.Matches;

    public class IndexViewModel
    {
        public int FootballersCount { get; set; }

        public int TeamsCount { get; set; }

        public int MatchesCount { get; set; }

        public int StadiumssCount { get; set; }

        public int LeaguesCount { get; set; }

        public int CountriesCount { get; set; }

        public IEnumerable<LeagueWithMatchesCountViewModel> LeagueItems { get; set; }

        public IEnumerable<KeyValuePair<int, string>> MatchItems { get; set; }

        public MatchViewModel MatchOfTheDay{ get; set; }
    }
}
