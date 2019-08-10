using System.ComponentModel.DataAnnotations;

namespace EasyJam.DAL.Entities
{
    public class DancerEntity : BaseUserEntity
    {
        [Key]
        public int DancerId { get; set; }
    }
}
