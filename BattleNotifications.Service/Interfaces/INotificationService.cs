namespace BattleNotifications.Service.Interfaces
{
    using System.Threading.Tasks;
    using Contracts.Contracts.V1.Requests;

    public interface INotificationService
    {
        Task<bool> BuildAndSendEmail(EmailSendRequest request);
    }
}