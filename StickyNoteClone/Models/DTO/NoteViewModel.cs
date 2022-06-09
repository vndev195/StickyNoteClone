namespace StickyNoteClone.Models.DTO
{
    public class NoteViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; } = String.Empty;
        public string? Color { get; set; } 
        public bool IsDisplayed { get; set; } = true;
        public int StateId { get; set; }
    }
    public class CreateNoteModel
    {
        public string Title { get; set; } = "Untitled";
        public string Content { get; set; } = String.Empty;
        public string Color { get; set; } = String.Empty;
        public bool IsDisplayed { get; set; } = true;
        public int StateId { get; set; } = 1;
    }
}
