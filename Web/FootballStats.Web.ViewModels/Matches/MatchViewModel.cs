namespace FootballStats.Web.ViewModels.Matches
{
    using System;

    using FootballStats.Data.Models;
    using FootballStats.Services.Mapping;

    public class MatchViewModel : IMapFrom<Match>
    {
        public int Id { get; set; }

        public int HomeTeamId { get; set; }

        public Team HomeTeam { get; set; }

        public int? HomeGoals { get; set; }

        public int AwayTeamId { get; set; }

        public Team AwayTeam { get; set; }

        public int? AwayGoals { get; set; }

        public DateTime DateMatch { get; set; }

        public int HomeTeamLeagueId { get; set; }

        public string HomeTeamLeagueUrlImage { get; set; }

        public bool IsMatchOfTheDay { get; set; }
    }
}
