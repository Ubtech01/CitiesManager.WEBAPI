using System.ComponentModel.DataAnnotations;

namespace CitiesManager.WEBAPI.Models
{
    public class City
    {
        [Key]
        public Guid CityID { get; set; }    
        public String? CityName { get; set; }
    }
}
