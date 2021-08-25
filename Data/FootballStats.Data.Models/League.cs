namespace FootballStats.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using FootballStats.Data.Common.Models;

    public class League : BaseDeletableModel<int>
    {
        public League()
        {
            this.Teams = new HashSet<Team>();
        }

        public string Name { get; set; }

        public string UrlImage { get; set; }

        public int CountryId { get; set; }

        public Country Country { get; set; }

        public IEnumerable<Team> Teams { get; set; }
    }
}
