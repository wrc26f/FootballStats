namespace FootballStats.Web.Controllers
{
    using System.Linq;
    using System.Threading.Tasks;

    using FootballStats.Services.Data;
    using FootballStats.Web.ViewModels.Footballers;
    using Microsoft.AspNetCore.Mvc;

    public class FootballersController : Controller
    {
        private readonly IGetAllEnums getAllEnums;
        private readonly ICountryService countryService;
        private readonly ITeamService teamService;
        private readonly ICreateFootballerService createFootballerService;
        private readonly IFootballerService footballerService;

        public FootballersController(
            IGetAllEnums getAllEnums,
            ICountryService countryService,
            ITeamService teamService,
            ICreateFootballerService createFootballerService,
            IFootballerService footballerService)
        {
            this.getAllEnums = getAllEnums;
            this.countryService = countryService;
            this.teamService = teamService;
            this.createFootballerService = createFootballerService;
            this.footballerService = footballerService;
        }

        public IActionResult Create()
        {
            var inputModel = new CreateFootballerInputModel
            {
                Positions = this.getAllEnums.GetAllEnumsAsKeyValuePair(),
                CountryItems = this.countryService.GetAllCountriesAsKeyValuePair(),
                TeamItems = this.teamService.GetAllTeamsAsKeyValuePair(),
            };
            return this.View(inputModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateFootballerInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                input.Positions = this.getAllEnums.GetAllEnumsAsKeyValuePair();
                input.CountryItems = this.countryService.GetAllCountriesAsKeyValuePair();
                input.TeamItems = this.teamService.GetAllTeamsAsKeyValuePair();
                return this.View(input);
            }

            await this.createFootballerService.CreateAsync(input);

            return this.Redirect("/");
        }

        public IActionResult ViewAllFootballers()
        {
            var viewModel = new FootballersListViewModel
            {
                FootballersList = this.footballerService.GetAllFootballers<FootballerViewModel>().OrderByDescending(x => x.CreatedOn),
            };
            return this.View(viewModel);
        }

        public IActionResult FootballerById(int id)
        {
            var viewModel = this.footballerService.GetFootballersById<FootballerViewModel>(id);
            return this.View(viewModel);
        }
    }
}
