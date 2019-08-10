using System.ComponentModel.DataAnnotations;

namespace EasyJam.DAL.Entities
{
    public class DjEntity : BaseUserEntity
    {
        [Key]
        public int DjId { get; set; }
    }
}
