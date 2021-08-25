using FootballStats.Services.Data;
using FootballStats.Web.ViewModels.Stadiums;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballStats.Web.Controllers
{
    public class StadiumsController : Controller
    {
        private readonly ICountryService countryService;
        private readonly ICreateStadiumService createStadiumService;
        private readonly IStadiumService stadiumService;

        public StadiumsController(
            ICountryService countryService,
            ICreateStadiumService createStadiumService,
            IStadiumService stadiumService)
        {
            this.countryService = countryService;
            this.createStadiumService = createStadiumService;
            this.stadiumService = stadiumService;
        }

        public IActionResult Create()
        {
            var viewModel = new CreateStadiumInputModel();
            viewModel.CountryItems = this.countryService.GetAllCountriesAsKeyValuePair();
            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateStadiumInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                input.CountryItems = this.countryService.GetAllCountriesAsKeyValuePair();
                return this.View(input);
            }

            await this.createStadiumService.CreateAsync(input);

            return this.RedirectToAction("ViewAllStadiums");
        }

        public IActionResult ViewAllStadiums()
        {
            var viewModel = new StadiumsListViewModel
            {
                StadiumsList = this.stadiumService.GetAllStadiums<StadiumViewModel>().OrderByDescending(x => x.CreatedOn),
            };
            return this.View(viewModel);
        }

        public IActionResult StadiumById(int id)
        {
            var viewModel = this.stadiumService.GetStadiumById<StadiumViewModel>(id);
            return this.View(viewModel);
        }
    }
}
