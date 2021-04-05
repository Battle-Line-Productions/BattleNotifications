namespace BattleNotifications.Api.Controllers
{
    using System.Threading.Tasks;
    using Contracts.Contracts.V1;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using Service.Interfaces;

    [Produces("application/json")]
    public class NotificationController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly INotificationService _notificationService;

        public NotificationController(ILogger logger, INotificationService notificationService)
        {
            _logger = logger;
            _notificationService = notificationService;
        }

        [HttpPost(ApiRoutes.Notification.SendEmail)]
        public async Task<IActionResult> SendEmail()
        {

        }
    }
}
