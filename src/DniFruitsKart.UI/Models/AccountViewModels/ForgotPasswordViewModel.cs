using System.ComponentModel.DataAnnotations;

namespace DniFruitsKart.UI.Models.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
