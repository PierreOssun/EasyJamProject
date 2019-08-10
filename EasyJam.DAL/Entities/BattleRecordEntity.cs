using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EasyJam.DAL.Entities
{
    public class BattleRecordEntity
    {
        [Key]
        public int BattleRecordId { get; set; }
        public int Order { get; set; }
        public DateTime ScheduledTime { get; set; }
        public DateTime StartTime { get; set; }
        public BattleParticipantEntity Winner { get; set; }
        public BattleParticipantEntity Loser { get; set; }
        public virtual IEnumerable<BattleParticipantEntity> Participants { get; set; }
        public BattleEntity Battle { get; set; }
    }
}
