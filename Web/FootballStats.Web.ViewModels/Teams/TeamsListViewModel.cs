using System;
using System.Collections.Generic;
using System.Text;

namespace FootballStats.Web.ViewModels.Teams
{
    public class TeamsListViewModel
    {
        public IEnumerable<TeamViewModel> TeamsList { get; set; }
    }
}
