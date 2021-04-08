namespace BattleNotifications.Service.Services
{
    using HandlebarsDotNet;
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using Contracts.Domain.V1;
    using Contracts.EmailTemplates;
    using Interfaces;

    public class TemplatingService : ITemplatingService
    {
        public (string, string, string) BuildEmailSubjectAndBody(EmailTemplateChoices templateName, object parameters = null)
        {
            var (subject, html, plainText) = GetTemplate(templateName);

            if (parameters == null)
            {
                return (subject, html, plainText);
            }

            var htmlString = BuildTemplate(html, parameters);
            var plainTextString = BuildTemplate(plainText, parameters);

            return (subject, htmlString, plainTextString);
        }

        public object BuildTemplateData(List<KeyValueTemplatePairs> pairs)
        {
            var data = new ExpandoObject();

            if (pairs == null ||  pairs.Count == 0)
            {
                return data;
            }

            foreach (var pair in pairs)
            {
                data.TryAdd(pair.Key, pair.Value);
            }

            return data;
        }

        private string BuildTemplate(string toTemplate, object toTemplateWith)
        {
            var template = Handlebars.Compile(toTemplate);
            return template(toTemplateWith);
        }

        private (string, string, string) GetTemplate(EmailTemplateChoices templateName)
        {
            string subject = "";
            string html = "";
            string plainText = "";

            switch (templateName)
            {
                case EmailTemplateChoices.ConfirmAccount:
                    var confirmAccountTemplates = new ConfirmAccountTemplates();
                    subject = confirmAccountTemplates.Subject;
                    html = confirmAccountTemplates.Html;
                    plainText = confirmAccountTemplates.PlainText;
                    break;
                case EmailTemplateChoices.ForgotPassword:
                    var forgotPasswordTemplates = new ForgotPasswordTemplates();
                    subject = forgotPasswordTemplates.Subject;
                    html = forgotPasswordTemplates.Html;
                    plainText = forgotPasswordTemplates.PlainText;
                    break;
                case EmailTemplateChoices.NewAccount:
                    var newAccountTemplates = new NewAccountTemplates();
                    subject = newAccountTemplates.Subject;
                    html = newAccountTemplates.Html;
                    plainText = newAccountTemplates.PlainText;
                    break;
                default:
                    throw new Exception("Email template not found");
            }

            return (subject, html, plainText);
        }
    }
}
