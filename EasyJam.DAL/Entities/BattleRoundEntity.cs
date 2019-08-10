using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EasyJam.DAL.Entities
{
    public class BattleRoundEntity
    {
        [Key]
        public int BattleRoundId { get; set; }
        public int Order { get; set; }
        public DateTime ScheduledTime { get; set; }
        public DateTime StartTime { get; set; }
        public BattleParticipantEntity Winner { get; set; }
        public BattleParticipantEntity Loser { get; set; }
        public virtual IEnumerable<BattleParticipantEntity> Participants { get; set; }
    }
}
