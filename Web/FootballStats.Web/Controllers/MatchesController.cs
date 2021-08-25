namespace FootballStats.Web.Controllers
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using FootballStats.Services.Data;
    using FootballStats.Web.ViewModels.Matches;
    using Microsoft.AspNetCore.Mvc;

    public class MatchesController : Controller
    {
        private readonly ICreateMatchService createMatchService;
        private readonly ITeamService teamService;
        private readonly IMatchService matchService;

        public MatchesController(
            ICreateMatchService createMatchService,
            ITeamService teamService,
            IMatchService matchService)
        {
            this.createMatchService = createMatchService;
            this.teamService = teamService;
            this.matchService = matchService;
        }

        public IActionResult Create()
        {
            var viewModel = new CreateMatchInputModel
            {
                TeamItems = this.teamService.GetAllTeamsAsKeyValuePair(),
            };
            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateMatchInputModel input)
        {
            if (!this.ModelState.IsValid || input.AwayTeamId == input.HomeTeamId)
            {
                input.TeamItems = this.teamService.GetAllTeamsAsKeyValuePair();
                return this.View(input);
            }

            await this.createMatchService.CreateAsync(input);
            return this.Redirect("/");
        }

        public IActionResult Details(int id)
        {
            var viewModel = this.matchService.GetMatchById<MatchViewModel>(id);
            return this.View(viewModel);
        }
    }
}
