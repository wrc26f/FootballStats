namespace FootballStats.Web.ViewModels.Teams
{
    using System;

    using FootballStats.Data.Models;
    using FootballStats.Services.Mapping;

    public class TeamViewModel : IMapFrom<Team>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string UrlImage { get; set; }

        public League League { get; set; }

        public Stadium Stadium { get; set; }

        public DateTime CreatedOn { get; set; }

        public int FootballersCount { get; set; }

        public int HomeMatchesCount { get; set; }

        public int AwayMatchesCount { get; set; }
    }
}
