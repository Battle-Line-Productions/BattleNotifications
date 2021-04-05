namespace BattleNotifications.Service.Interfaces
{
    using System.Threading.Tasks;

    public interface ITemplatingService
    {
        Task<(string, string)> BuildEmailBody<T>(string templateName, T parameters);
    }
}