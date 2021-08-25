namespace FootballStats.Web.Controllers
{
    using System.Linq;
    using System.Threading.Tasks;

    using FootballStats.Services.Data;
    using FootballStats.Web.ViewModels.Teams;
    using Microsoft.AspNetCore.Mvc;

    public class TeamsController : Controller
    {
        private readonly ILeagueService leagueService;
        private readonly IStadiumService stadiumService;
        private readonly ICreateTeamService createTeamService;
        private readonly ITeamService teamService;

        public TeamsController(
            ILeagueService leagueService,
            IStadiumService stadiumService,
            ICreateTeamService createTeamService,
            ITeamService teamService)
        {
            this.leagueService = leagueService;
            this.stadiumService = stadiumService;
            this.createTeamService = createTeamService;
            this.teamService = teamService;
        }

        public IActionResult Create()
        {
            var inputModel = new CreateTeamInputModel
            {
                LeagueItems = this.leagueService.GetAllLeaguesAsKeyValuePair(),
                StadiumItems = this.stadiumService.GetAllStadiumsAsKeyValuePair(),
            };
            return this.View(inputModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateTeamInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                input.LeagueItems = this.leagueService.GetAllLeaguesAsKeyValuePair();
                input.StadiumItems = this.stadiumService.GetAllStadiumsAsKeyValuePair();
                return this.View(input);
            }

            await this.createTeamService.CreateAsync(input);

            return this.RedirectToAction("ViewAllTeams");
        }

        public IActionResult ViewAllTeams()
        {
            var viewModel = new TeamsListViewModel
            {
                TeamsList = this.teamService.GetAllTeams<TeamViewModel>().OrderByDescending(x => x.CreatedOn),
            };
            return this.View(viewModel);
        }

        public IActionResult TeamById(int id)
        {
            var viewModel = this.teamService.GetTeamById<TeamViewModel>(id);
            return this.View(viewModel);
        }
    }
}
