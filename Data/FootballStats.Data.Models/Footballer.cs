namespace FootballStats.Data.Models
{
    using System;

    using FootballStats.Data.Common.Models;

    public class Footballer : BaseDeletableModel<int>
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public int Age => (ZeroTime + DateTime.Now.Subtract(this.BirthDate)).Year - 1;

        public DateTime ZeroTime => new DateTime(1, 1, 1);

        public Position Position { get; set; }

        public int TeamId { get; set; }

        public Team Team { get; set; }

        public int CountryId { get; set; }

        public Country Country { get; set; }
    }
}
