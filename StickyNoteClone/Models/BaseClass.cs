using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StickyNoteClone.Models
{
    public abstract class BaseClass
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
    }
}
