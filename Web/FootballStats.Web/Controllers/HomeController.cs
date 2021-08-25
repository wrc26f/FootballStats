namespace FootballStats.Web.Controllers
{
    using System.Diagnostics;

    using FootballStats.Services.Data;
    using FootballStats.Web.ViewModels;
    using FootballStats.Web.ViewModels.Home;
    using FootballStats.Web.ViewModels.Leagues;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : BaseController
    {
        private readonly IGetCountsOfEntities getCountsOfEntities;
        private readonly ILeagueService leagueService;
        private readonly IMatchService matchService;

        public HomeController(
            IGetCountsOfEntities getCountsOfEntities,
            ILeagueService leagueService,
            IMatchService matchService)
        {
            this.getCountsOfEntities = getCountsOfEntities;
            this.leagueService = leagueService;
            this.matchService = matchService;
        }

        public IActionResult Index()
        {
            var viewModel = new IndexViewModel();
            viewModel = this.getCountsOfEntities.GetAllCount();
            viewModel.LeagueItems = this.leagueService.GetLeagueDailyMatches();
            viewModel.MatchItems = this.matchService.GetAllDailyMatchesAsKeyValuePair();
            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
