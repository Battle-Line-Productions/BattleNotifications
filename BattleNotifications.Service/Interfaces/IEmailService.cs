namespace BattleNotifications.Service.Interfaces
{
    using System.Threading.Tasks;

    public interface IEmailService
    {
        Task<bool> BuildAndSendEmail(string from, string to, string subject, string htmlBody, string textBody);
    }
}