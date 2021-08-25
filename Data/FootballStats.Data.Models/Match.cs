namespace FootballStats.Data.Models
{
    using System;

    using FootballStats.Data.Common.Models;

    public class Match : BaseDeletableModel<int>
    {
        public int HomeTeamId { get; set; }

        public Team HomeTeam { get; set; }

        public int? HomeGoals { get; set; }

        public int AwayTeamId { get; set; }

        public Team AwayTeam { get; set; }

        public int? AwayGoals { get; set; }

        public DateTime DateMatch { get; set; }

        public bool IsMatchOfTheDay { get; set; }
    }
}
