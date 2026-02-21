// ============================================================
// Contact Form Model
// ============================================================
// This model represents the data structure for the contact form.
// It includes validation attributes to ensure data integrity.
// ============================================================

using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    public class ContactForm
    {
        // Name field - Required, must be between 2 and 100 characters
        [Required(ErrorMessage = "Please enter your name")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 100 characters")]
        [Display(Name = "Your Name")]
        public string Name { get; set; } = string.Empty;

        // Email field - Required, must be valid email format
        [Required(ErrorMessage = "Please enter your email")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        [Display(Name = "Email Address")]
        public string Email { get; set; } = string.Empty;

        // Message field - Required, must be between 10 and 1000 characters
        [Required(ErrorMessage = "Please enter your message")]
        [StringLength(1000, MinimumLength = 10, ErrorMessage = "Message must be between 10 and 1000 characters")]
        [Display(Name = "Your Message")]
        public string Message { get; set; } = string.Empty;
    }
}
