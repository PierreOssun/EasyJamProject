using System.ComponentModel.DataAnnotations;

namespace EasyJam.DAL.Entities
{
    public class CountryEntity
    {
        [Key]
        public int CountryId { get; set; }

        [Required, MaxLength(50)]
        public string CountryName { get; set; }
    }
}
