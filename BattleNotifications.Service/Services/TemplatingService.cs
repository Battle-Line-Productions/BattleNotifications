namespace BattleNotifications.Service.Services
{
    using System.Threading.Tasks;
    using Interfaces;

    public class TemplatingService : ITemplatingService
    {
        public Task<(string, string)> BuildEmailBody<T>(string templateName, T parameters)
        {
            throw new System.NotImplementedException();
        }
    }
}