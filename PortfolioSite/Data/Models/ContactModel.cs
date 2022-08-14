using System.ComponentModel.DataAnnotations;

namespace PortfolioSite.Data.Models
{
    public class ContactModel
    {
        [Required(ErrorMessage = "Please provide your first name.")]
        [StringLength(100, ErrorMessage = "Big doubt that your first name is longer than 100 characters.")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Please provide your last name.")]
        [StringLength(100, ErrorMessage = "Big doubt that your last name is longer than 100 characters.")]
        public string? LastName { get; set; }

        [StringLength(100, ErrorMessage = "Big doubt that your company name is longer than 100 characters.")]
        public string? CompanyName { get; set; }

        [Required(ErrorMessage = "Please provide a valid email address.")]
        [EmailAddress(ErrorMessage = "Please provide a valid email address.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Thanks for trying to contact me, but could you provide a message?")]
        [StringLength(5000, ErrorMessage = "Please send me something shorter. That is quite the long message.")]
        public string? Message { get; set; }

    }
}
