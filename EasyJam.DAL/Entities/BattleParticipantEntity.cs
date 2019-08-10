using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EasyJam.DAL.Entities
{
    public class BattleParticipantEntity
    {
        [Key]
        public int BattleEntryId { get; set; }

        [Required, MaxLength(50)]
        public string BattleBlaze { get; set; }

        public DateTime SubscritpionDate { get; set; }
        public int? Rank { get; set; }
        public virtual IEnumerable<DancerEntity> Dancer { get; set; }
        public virtual IEnumerable<CrewEntity> Crew { get; set; }


    }
}
