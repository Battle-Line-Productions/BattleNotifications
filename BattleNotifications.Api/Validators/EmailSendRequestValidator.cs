namespace BattleNotifications.Api.Validators
{
    using System;
    using System.Collections.Generic;
    using Contracts.Contracts.V1.Requests;
    using Contracts.Domain.V1;
    using FluentValidation;

    public class EmailSendRequestValidator : AbstractValidator<EmailSendRequest>
    {
        public EmailSendRequestValidator()
        {
            List<EmailTemplateChoices> conditions = new List<EmailTemplateChoices>()
             {
                 EmailTemplateChoices.ForgotPassword,
                 EmailTemplateChoices.ConfirmAccount,
                 EmailTemplateChoices.NewAccount
             };
            RuleFor(x => x.From).NotEmpty().EmailAddress();
            RuleFor(x => x.To).NotEmpty().EmailAddress();
            RuleFor(x => x.TemplateChoice).NotEmpty().Must(x => conditions.Contains(x))
                .WithMessage("Please only use: " + String.Join(",", conditions));
        }
    }
}