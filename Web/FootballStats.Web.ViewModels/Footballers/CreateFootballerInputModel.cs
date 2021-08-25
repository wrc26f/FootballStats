namespace FootballStats.Web.ViewModels.Footballers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    using FootballStats.Data.Models;

    public class CreateFootballerInputModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public Position Position { get; set; }

        public int TeamId { get; set; }

        public DateTime BirthDate { get; set; }

        public int CountryId { get; set; }

        public IEnumerable<KeyValuePair<string, int>> Positions { get; set; }

        public IEnumerable<KeyValuePair<int, string>> TeamItems { get; set; }

        public IEnumerable<KeyValuePair<int, string>> CountryItems { get; set; }
    }
}
