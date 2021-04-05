namespace BattleNotifications.Service.Interfaces
{
    using System.Threading.Tasks;

    public interface INotificationService
    {
        Task<bool> BuildAndSendEmail();
    }
}