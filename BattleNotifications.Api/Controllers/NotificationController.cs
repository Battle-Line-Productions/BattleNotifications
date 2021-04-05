namespace BattleNotifications.Api.Controllers
{
    using System.Threading.Tasks;
    using Contracts.Contracts.V1;
    using Contracts.Contracts.V1.Requests;
    using Microsoft.AspNetCore.Mvc;
    using Service.Interfaces;

    [Produces("application/json")]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationService _notificationService;

        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        [HttpPost(ApiRoutes.Notification.SendEmail)]
        public async Task<IActionResult> SendEmail([FromBody] EmailSendRequest request)
        {
            var emailSent = await _notificationService.BuildAndSendEmail(request);

            if (!emailSent)
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}
