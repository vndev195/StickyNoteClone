using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace StickyNoteClone.Models
{
    public class User : IdentityUser
    {
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; } = String.Empty;
        [Required]
        [StringLength(50)]
        public string LastName { get; set; } = String.Empty;

        [JsonIgnore]
        public IEnumerable<Note> Notes { get; set; } = new List<Note>();
    }
}
