namespace BattleNotifications.Service.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Amazon;
    using Amazon.SimpleEmail;
    using Amazon.SimpleEmail.Model;
    using Contracts.Domain.V1;
    using Interfaces;

    public class EmailService : IEmailService
    {
        public async Task<SendEmailResult> BuildAndSendEmail(string from, string to, string subject, string htmlBody, string textBody)
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
                var emailSendResult = await client.SendEmailAsync(sendRequest);

                return new SendEmailResult()
                {
                    SesMessageId = emailSendResult.MessageId,
                    Message = "Email successfully sent",
                    Success = true,
                };
            }
            catch (Exception ex)
            {
                return new SendEmailResult()
                {
                    Message = ex.Message,
                    Success = false,
                    Errors = new []{ $"Stack Track: {ex.StackTrace}", $"InnerException: {ex.InnerException}", $"Source: {ex.Source}", $"Message: {ex.Message}" }
                };
            }
        }
    }
}
