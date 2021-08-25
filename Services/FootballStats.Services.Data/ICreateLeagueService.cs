namespace FootballStats.Services.Data
{
    using System.Threading.Tasks;

    using FootballStats.Web.ViewModels.League;

    public interface ICreateLeagueService
    {
        Task CreateAsync(CreateLeagueInputModel input);
    }
}
