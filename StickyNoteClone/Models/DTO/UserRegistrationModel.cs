using System.ComponentModel.DataAnnotations;

namespace StickyNoteClone.Models.DTO
{
    public class UserRegistrationModel
    {
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; } = String.Empty;
        [Required]
        [StringLength(50)]
        public string LastName { get; set; } = String.Empty;

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Password and confirm password do not match")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
