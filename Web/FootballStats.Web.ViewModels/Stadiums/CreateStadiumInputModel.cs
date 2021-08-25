namespace FootballStats.Web.ViewModels.Stadiums
{
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class CreateStadiumInputModel
    {
        [Required]
        [DisplayName("Name of stadium")]
        public string Name { get; set; }

        public int Capacity { get; set; }

        [DisplayName("Image url")]
        public string UrlImage { get; set; }

        [DisplayName("Country")]
        public int CountryId { get; set; }

        public IEnumerable<KeyValuePair<int,string>> CountryItems { get; set; }
    }
}
