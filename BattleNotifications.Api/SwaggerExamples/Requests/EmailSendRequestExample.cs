namespace BattleNotifications.Api.SwaggerExamples.Requests
{
    using System.Collections.Generic;
    using Contracts.Contracts.V1.Requests;
    using Contracts.Domain.V1;
    using Swashbuckle.AspNetCore.Filters;

    public class EmailSendRequestExample : IExamplesProvider<EmailSendRequest>
    {
        public EmailSendRequest GetExamples()
        {
            return new EmailSendRequest()
            {
                To = "Email@email.com",
                From = "noreply@battlelineproductions.com",
                TemplateChoice = "ConfirmAccount",
                TemplateData = new List<KeyValueTemplatePairs>()
                {
                    new KeyValueTemplatePairs()
                    {
                        Key = "Code",
                        Value = "jfjd82134lkjhsd0fghf3"
                    }
                }
            };
        }
    }
}