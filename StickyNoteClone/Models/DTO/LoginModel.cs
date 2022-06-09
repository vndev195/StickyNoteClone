using System.ComponentModel.DataAnnotations;

namespace StickyNoteClone.Models.DTO
{
    public class LoginModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = String.Empty;
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = String.Empty;
        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
        //public string ReturnUrl { get; set; }
    }
}
