using System.ComponentModel.DataAnnotations;

namespace EasyJam.DAL.Entities
{
    public class HostEntity : BaseUserEntity
    {
        [Key]
        public int HostId { get; set; }
    }
}
