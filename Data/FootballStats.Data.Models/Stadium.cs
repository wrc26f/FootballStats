using FootballStats.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FootballStats.Data.Models
{
    public class Stadium : BaseDeletableModel<int>
    {
        public Stadium()
        {
            this.Teams = new HashSet<Team>();
        }

        public string Name { get; set; }

        public int? Capacity { get; set; }

        public string UrlImage { get; set; }

        public int CountryId { get; set; }

        public Country Country { get; set;  }

        public IEnumerable<Team> Teams { get; set; }
    }
}
