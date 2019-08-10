using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EasyJam.DAL.Entities
{
    public class BattlePreliminaryEntity
    {
        [Key]
        public int BattlePreliminaryId { get; set; }
        public DateTime ScheduledTime { get; set; }
        public DateTime StartTime { get; set; }
        public virtual IEnumerable<BattleRoundEntity> BattleRound { get; set; }
        public virtual IEnumerable<BattleParticipantEntity> Participants { get; set; }

    }
}
