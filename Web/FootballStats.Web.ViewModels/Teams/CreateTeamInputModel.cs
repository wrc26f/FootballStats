namespace FootballStats.Web.ViewModels.Teams
{
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class CreateTeamInputModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [DisplayName("Image url")]
        public string UrlImage { get; set; }

        [DisplayName("League")]
        public int LeagueId { get; set; }

        [DisplayName("Stadium")]
        public int StadiumId { get; set; }

        public IEnumerable<KeyValuePair<int,string>> LeagueItems { get; set; }

        public IEnumerable<KeyValuePair<int, string>> StadiumItems { get; set; }
    }
}
