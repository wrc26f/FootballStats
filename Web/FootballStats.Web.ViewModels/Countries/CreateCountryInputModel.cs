namespace FootballStats.Web.ViewModels.Countries
{
    using FootballStats.Data.Models;
    using FootballStats.Services.Mapping;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class CreateCountryInputModel: IMapFrom<Country>
    {
        [Required]
        [DisplayName("Name of country")]
        public string Name { get; set; }

        [Required]
        [StringLength(3, MinimumLength =3)]
        public string Abbreviation { get; set; }

        [Required]
        [DisplayName("Image url")]
        public string UrlImage { get; set; }
    }
}
