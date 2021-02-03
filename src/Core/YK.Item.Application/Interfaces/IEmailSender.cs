using System.Threading.Tasks;

namespace YK.Item.Application.Interfaces
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string to, string from, string subject, string body);
    }
}
