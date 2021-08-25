namespace FootballStats.Web.ViewModels.Matches
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public class CreateMatchInputModel
    {
        [DisplayName("Home Team")]
        public int HomeTeamId { get; set; }

        [DisplayName("Home Goals")]
        public int? HomeGoals { get; set; }

        [DisplayName("Away Team")]
        public int AwayTeamId { get; set; }

        [DisplayName("Away Goals")]
        public int? AwayGoals { get; set; }

        [DisplayName("Date of match")]
        public DateTime DateMatch { get; set; }

        public IEnumerable<KeyValuePair<int, string>> TeamItems { get; set; }
    }
}
