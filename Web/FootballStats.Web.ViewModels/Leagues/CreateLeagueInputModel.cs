namespace FootballStats.Web.ViewModels.League
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    using FootballStats.Data.Models;
    using Microsoft.EntityFrameworkCore;

    public class CreateLeagueInputModel
    {
        [Required]
        [DisplayName("Name of league")]
        public string Name { get; set; }

        [DisplayName("Image url")]
        public string UrlImage { get; set; }

        [DisplayName("Country")]
        public int CountryId { get; set; }

        public IEnumerable<KeyValuePair<int, string>> CountryItems { get; set; }
    }
}
