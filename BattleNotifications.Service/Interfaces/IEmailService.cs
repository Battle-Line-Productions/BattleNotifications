namespace BattleNotifications.Service.Interfaces
{
    using System.Threading.Tasks;
    using Contracts.Domain.V1;

    public interface IEmailService
    {
        Task<SendEmailResult> BuildAndSendEmail(string from, string to, string subject, string htmlBody, string textBody);
    }
}