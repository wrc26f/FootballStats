namespace FootballStats.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using FootballStats.Data.Common.Repositories;
    using FootballStats.Data.Models;
    using FootballStats.Web.ViewModels.Teams;

    public class CreateTeamService : ICreateTeamService
    {
        private readonly IDeletableEntityRepository<Team> teamsRepository;

        public CreateTeamService(IDeletableEntityRepository<Team> teamsRepository)
        {
            this.teamsRepository = teamsRepository;
        }

        public async Task CreateAsync(CreateTeamInputModel input)
        {
            var team = new Team
            {
                Name = input.Name,
                LeagueId = input.LeagueId,
                StadiumId = input.StadiumId,
                UrlImage = input.UrlImage,
            };

            await this.teamsRepository.AddAsync(team);
            await this.teamsRepository.SaveChangesAsync();
        }
    }
}
