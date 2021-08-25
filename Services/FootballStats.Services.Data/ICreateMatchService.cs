namespace FootballStats.Services.Data
{
    using System.Threading.Tasks;

    using FootballStats.Web.ViewModels.Matches;

    public interface ICreateMatchService
    {
        Task CreateAsync(CreateMatchInputModel input);
    }
}
