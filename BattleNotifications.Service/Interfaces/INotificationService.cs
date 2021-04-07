namespace BattleNotifications.Service.Interfaces
{
    using System.Threading.Tasks;
    using Contracts.Contracts.V1.Requests;
    using Contracts.Domain.V1;

    public interface INotificationService
    {
        Task<SendEmailResult> BuildAndSendEmail(EmailSendRequest request);
    }
}