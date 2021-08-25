namespace FootballStats.Data.Models
{
    using System.Collections;
    using System.Collections.Generic;

    using FootballStats.Data.Common.Models;

    public class Country : BaseDeletableModel<int>
    {
        public Country()
        {
            this.Footballers = new HashSet<Footballer>();
            this.Leagues = new HashSet<League>();
            this.Stadiums = new HashSet<Stadium>();
        }

        public string Name { get; set; }

        public string Abbreviation { get; set; }

        public string UrlImage { get; set; }

        public IEnumerable<Footballer> Footballers { get; set; }

        public IEnumerable<League> Leagues { get; set; }

        public IEnumerable<Stadium> Stadiums { get; set; }
    }
}