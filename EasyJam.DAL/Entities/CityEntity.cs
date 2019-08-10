using System.ComponentModel.DataAnnotations;

namespace EasyJam.DAL.Entities
{
    public class CityEntity
    {
        [Key]
        public int CityId { get; set; }

        [Required, MaxLength(50)]
        public string CityName { get; set; }
    }
}
