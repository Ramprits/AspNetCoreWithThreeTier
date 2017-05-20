using System.Threading.Tasks;

namespace DniFruitsKart.UI.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
