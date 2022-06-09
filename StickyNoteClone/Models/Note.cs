using System.ComponentModel.DataAnnotations;

namespace StickyNoteClone.Models
{
    public class Note : BaseClass
    {
        public string Title { get; set; } = "Untitled";
        [Required]
        public string Content { get; set; } = String.Empty;
        [MaxLength(10)]
        public string Color { get; set; } = "#00FFFF";
        public bool IsDisplayed { get; set; }
        public string UserId { get; set; }
        public User UserNavigation { get; set; }
        public int StateId { get; set; }
        public State StateNavigation { get; set; }
    }
}
