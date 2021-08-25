namespace FootballStats.Web.ViewModels.Stadiums
{
    using FootballStats.Data.Models;
    using FootballStats.Services.Mapping;
    using System;

    public class StadiumViewModel : IMapFrom<Stadium>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public string UrlImage { get; set; }

        public DateTime CreatedOn { get; set; }

        public Country Country { get; set; }

        public int TeamsCount { get; set; }
    }
}
