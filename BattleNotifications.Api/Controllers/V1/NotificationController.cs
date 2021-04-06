namespace BattleNotifications.Api.Controllers.V1
{
    using System.Threading.Tasks;
    using Contracts.Contracts.V1;
    using Contracts.Contracts.V1.Requests;
    using Contracts.Contracts.V1.Responses;
    using Microsoft.AspNetCore.Authorization;
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

        /// <summary>
        /// Allows a user to send email through AWS Simple Email Service.
        /// </summary>
        /// <remarks>User must know parameters that will be passed in for template. parameters to pass in call be null. For templateChoice you can pick 0 for forgotPassword, 1 for confirmAccount and 2 for newAccount Email.</remarks>
        /// <response code="200">Email sent by AWS Simple Email Service.</response>
        /// <response code="400">Email not send by AWS Simple Email Service.</response>
        [HttpPost(ApiRoutes.Notification.SendEmail)]
        [Authorize]
        [ProducesResponseType(200)]
        [ProducesErrorResponseType(typeof(ErrorResponse))]
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
