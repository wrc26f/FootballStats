namespace FootballStats.Web.Controllers
{
    using System.Linq;
    using System.Threading.Tasks;

    using FootballStats.Services.Data;
    using FootballStats.Web.ViewModels.League;
    using FootballStats.Web.ViewModels.Leagues;
    using Microsoft.AspNetCore.Mvc;

    public class LeaguesController : Controller
    {
        private readonly ICountryService countryService;
        private readonly ICreateLeagueService createLeaguesService;
        private readonly ILeagueService leagueService;

        public LeaguesController(
            ICountryService countryService,
            ICreateLeagueService createLeaguesService,
            ILeagueService leagueService)
        {
            this.countryService = countryService;
            this.createLeaguesService = createLeaguesService;
            this.leagueService = leagueService;
        }

        public IActionResult Create()
        {
            var viewModel = new CreateLeagueInputModel();
            viewModel.CountryItems = this.countryService.GetAllCountriesAsKeyValuePair();
            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateLeagueInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
               input.CountryItems = this.countryService.GetAllCountriesAsKeyValuePair();
               return this.View(input);
            }

            await this.createLeaguesService.CreateAsync(input);
            // TODO Redirect user to leagues infopage
            return this.RedirectToAction("ViewAllLeagues");
        }

        public IActionResult ViewAllLeagues()
        {
            var viewModel = new LeaguesListViewModel()
            {
                LeagueList = this.leagueService.GetAllLeagues<LeagueViewModel>().OrderByDescending(x => x.CreatedOn),
            };
            return this.View(viewModel);
        }

        public IActionResult LeagueById(int id)
        {
            var viewModel = this.leagueService.GetLeagueById<LeagueViewModel>(id);
            return this.View(viewModel);
        }
    }
}
