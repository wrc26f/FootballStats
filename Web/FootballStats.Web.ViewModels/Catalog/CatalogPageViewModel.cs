namespace FootballStats.Web.ViewModels.Catalog
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using FootballStats.Web.ViewModels.Matches;

    public class CatalogPageViewModel
    {
        public IEnumerable<MatchViewModel> MatchesList { get; set; }

        [DisplayName("League")]
        public int LeagueId { get; set; }

        [DisplayName(" Choose date")]
        public DateTime ChosenDate { get; set; }

        public int PageNumber { get; set; }

        public int PreviousPage => this.PageNumber - 1;

        public bool HasPreviousPage => this.PageNumber > 1;

        public int NextPage => this.PageNumber + 1;

        public bool HasNextPage => this.PageNumber < this.PageCount;

        public int DailyMatchesCount => this.MatchesList.Count();

        public int PageCount => (int)Math.Ceiling((decimal)this.DailyMatchesCount / 12);

        public IEnumerable<KeyValuePair<int, string>> LeagueItems { get; set; }
    }
}
