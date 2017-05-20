using System.Threading.Tasks;

namespace DniFruitsKart.UI.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
