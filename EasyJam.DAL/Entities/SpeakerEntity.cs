using System.ComponentModel.DataAnnotations;

namespace EasyJam.DAL.Entities
{
    public class SpeakerEntity : BaseUserEntity
    {
        [Key]
        public int SpeakerId { get; set; }
    }
}
