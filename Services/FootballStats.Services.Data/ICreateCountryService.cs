namespace FootballStats.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    using FootballStats.Web.ViewModels.Countries;

    public interface ICreateCountryService
    {
        Task CreateAsync(CreateCountryInputModel input);
    }
}
