using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace StickyNoteClone.Models
{
    public class State : BaseClass
    {
        public string StateName { get; set; } = string.Empty;

        [JsonIgnore]
        public IEnumerable<Note> Notes { get; set; } = new List<Note>();
    }
}
