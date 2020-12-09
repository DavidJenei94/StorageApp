using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StorageAppWeb.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        [ForeignKey("ReferencedStorage")]
        public int StorageId { get; set; }

        public virtual Storage ReferencedStorage { get; set; }
    }
}
