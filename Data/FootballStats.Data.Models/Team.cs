namespace FootballStats.Data.Models
{
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    using FootballStats.Data.Common.Models;

    public class Team : BaseDeletableModel<int>
    {
        public Team()
        {
            this.HomeMatches = new HashSet<Match>();
            this.AwayMatches = new HashSet<Match>();
            this.Footballers = new HashSet<Footballer>();
        }

        public string Name { get; set; }

        public string UrlImage { get; set; }

        public int LeagueId { get; set; }

        public League League { get; set; }

        public int StadiumId { get; set; }

        public Stadium Stadium { get; set; }

        [InverseProperty("HomeTeam")]
        public IEnumerable<Match> HomeMatches { get; set; }

        [InverseProperty("AwayTeam")]
        public IEnumerable<Match> AwayMatches { get; set; }

        public IEnumerable<Footballer> Footballers { get; set; }
    }
}
