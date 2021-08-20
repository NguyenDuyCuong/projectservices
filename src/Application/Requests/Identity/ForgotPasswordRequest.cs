using System.ComponentModel.DataAnnotations;

namespace ProjectServices.Application.Requests.Identity
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}