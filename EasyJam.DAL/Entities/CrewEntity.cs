using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EasyJam.DAL.Entities
{
    public class CrewEntity
    {
        [Key]
        public int CrewId { get; set; }
        public string CrewName { get; set; }
        public virtual ICollection<CityEntity> CityEntity { get; set; }
        public virtual ICollection<CountryEntity> CountryEntity { get; set; }
    }
}
