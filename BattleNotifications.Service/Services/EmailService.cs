namespace BattleNotifications.Service.Services
{
    using Microsoft.Extensions.Logging;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Amazon;
    using Amazon.SimpleEmail;
    using Amazon.SimpleEmail.Model;
    using Interfaces;

    public class EmailService : IEmailService
    {
        private readonly ILogger _logger;

        public EmailService(ILogger logger)
        {
            _logger = logger;
        }

        public async Task<bool> BuildAndSendEmail(string from, string to, string subject, string htmlBody, string textBody)
        {
            using var client = new AmazonSimpleEmailServiceClient(RegionEndpoint.USEast2);
            var sendRequest = new SendEmailRequest()
            {
                Source = @from,
                Destination = new Destination()
                {
                    ToAddresses = new List<string>() {to}
                },
                Message = new Message()
                {
                    Subject = new Content(subject),
                    Body = new Body()
                    {
                        Html = new Content()
                        {
                            Charset = "UTF-8",
                            Data = htmlBody
                        },
                        Text = new Content()
                        {
                            Charset = "UTF-8",
                            Data = textBody
                        }
                    }
                }
            };

            try
            {
                await client.SendEmailAsync(sendRequest);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
