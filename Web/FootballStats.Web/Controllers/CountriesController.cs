namespace FootballStats.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using FootballStats.Services.Data;
    using FootballStats.Web.ViewModels.Countries;
    using Microsoft.AspNetCore.Mvc;

    public class CountriesController : Controller
    {
        private readonly ICreateCountryService createCountryService;
        private readonly ICountryService countryService;

        public CountriesController(
            ICreateCountryService createCountryService,
            ICountryService countryService)
        {
            this.createCountryService = createCountryService;
            this.countryService = countryService;
        }

        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCountryInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            await this.createCountryService.CreateAsync(input);

            return this.RedirectToAction("ViewAllCountries");
        }

        public IActionResult ViewAllCountries()
        {
            var viewModel = new CountriesListViewModel
            {
                CountryList = this.countryService.GetAllCountries<CountryViewModel>().OrderByDescending(x => x.CreatedOn),
            };
            return this.View(viewModel);
        }

        public IActionResult CountryById(int id)
        {
            var viewModel = this.countryService.GetCountryById<CountryViewModel>(id);
            return this.View(viewModel);
        }
    }
}
