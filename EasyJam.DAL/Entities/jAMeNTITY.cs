using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EasyJam.DAL.Entities
{
    public class JamEntity
    {
        [Key]
        public int JamId { get; set; }
        public string JamName { get; set; }
        public DateTime ScheduledTime { get; set; }

        public DateTime startTime { get; set; }

        [Required]
        public string Location { get; set; }

        public CityEntity City { get; set; }

        public CountryEntity Country { get; set; }

        public virtual ICollection<HostEntity> Host { get; set; }

        public virtual ICollection<BattleEntity> Battle { get; set; }
    }
}