namespace StickyNoteClone.Models.DTO
{
    public class NoteDto
    {
        public string? Title { get; set; }
        public string? Content { get; set; }
        public string? Color { get; set; }
        public bool? IsDisplayed { get; set; }
        public int UserId { get; set; }
        public int StateId { get; set; }
    }
}
