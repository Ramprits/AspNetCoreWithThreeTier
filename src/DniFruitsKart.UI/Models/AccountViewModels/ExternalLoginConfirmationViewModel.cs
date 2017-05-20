using System.ComponentModel.DataAnnotations;

namespace DniFruitsKart.UI.Models.AccountViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
