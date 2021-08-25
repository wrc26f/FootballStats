namespace FootballStats.Services.Data
{
    using System.Threading.Tasks;

    using FootballStats.Web.ViewModels.Teams;

    public interface ICreateTeamService
    {
        Task CreateAsync(CreateTeamInputModel input);
    }
}
