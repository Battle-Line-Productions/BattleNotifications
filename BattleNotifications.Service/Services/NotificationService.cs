namespace BattleNotifications.Service.Services
{
    using System.Threading.Tasks;
    using Contracts.Contracts.V1.Requests;
    using Interfaces;

    public class NotificationService : INotificationService
    {
        private readonly ITemplatingService _templatingService;
        private readonly IEmailService _emailService;

        public NotificationService(ITemplatingService templatingService, IEmailService emailService)
        {
            _templatingService = templatingService;
            _emailService = emailService;
        }

        public async Task<bool> BuildAndSendEmail(EmailSendRequest request)
        {
            var templateData = _templatingService.BuildTemplateData(request.TemplateData);
            var (subject, html, plainText) =
                _templatingService.BuildEmailSubjectAndBody(request.TemplateChoice, templateData);

            return await _emailService.BuildAndSendEmail(request.From, request.To, subject, html, plainText);
        }
    }
}
