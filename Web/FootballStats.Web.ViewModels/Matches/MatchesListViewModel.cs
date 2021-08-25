namespace FootballStats.Web.ViewModels.Matches
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class MatchesListViewModel
    {
        public IEnumerable<MatchViewModel> MatchesList { get; set; }

        public DateTime CurrentDate => DateTime.Now;
    }
}
