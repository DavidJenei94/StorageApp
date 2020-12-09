using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StorageAppWeb.Models
{
    public class Storage
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [ForeignKey("ReferencedRoom")]
        public int RoomId { get; set; }

        public virtual Room ReferencedRoom { get; set; }
    }
}
