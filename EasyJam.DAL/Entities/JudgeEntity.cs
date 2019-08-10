using System.ComponentModel.DataAnnotations;

namespace EasyJam.DAL.Entities
{
    public class JudgeEntity : BaseUserEntity
    {
        [Key]
        public int JudgeId { get; set; }
    }
}
