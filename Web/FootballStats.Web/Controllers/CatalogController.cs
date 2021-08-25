namespace FootballStats.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using FootballStats.Services.Data;
    using FootballStats.Web.ViewModels.Catalog;
    using FootballStats.Web.ViewModels.Matches;
    using Microsoft.AspNetCore.Mvc;

    public class CatalogController : Controller
    {
        private readonly IMatchService matchService;
        private readonly ILeagueService leagueService;

        public CatalogController(
            IMatchService matchService,
            ILeagueService leagueService)
        {
            this.matchService = matchService;
            this.leagueService = leagueService;
        }

        public IActionResult CatalogPage(int id = 1, int leagueId = 0, string chosenDate = "")
        {
            var viewModel = new CatalogPageViewModel
            {
                MatchesList = leagueId == 0 ? this.matchService.Get12Matches<MatchViewModel>(id) : this.matchService.Get12Matches<MatchViewModel>(id).Where(x => x.HomeTeamLeagueId == leagueId),
                PageNumber = id,
                LeagueItems = this.leagueService.GetAllLeaguesAsKeyValuePairForCatalog(),
            };

            if (chosenDate == "")
            {
                viewModel.ChosenDate = DateTime.Now.Date;
                viewModel.MatchesList = viewModel.MatchesList.Where(x => x.DateMatch == DateTime.Now.Date);
            }
            else
            {
                viewModel.ChosenDate = DateTime.Parse(chosenDate);
                viewModel.MatchesList = viewModel.MatchesList.Where(x => x.DateMatch == DateTime.Parse(chosenDate));
            }
            return this.View(viewModel);
        }
    }
}
