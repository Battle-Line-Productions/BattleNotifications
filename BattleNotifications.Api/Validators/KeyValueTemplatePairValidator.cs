namespace BattleNotifications.Api.Validators
{
    using Contracts.Domain.V1;
    using FluentValidation;

    public class KeyValueTemplatePairValidator : AbstractValidator<KeyValueTemplatePairs>
    {
        public KeyValueTemplatePairValidator()
        {
            RuleFor(x => x.Key).NotEmpty().When(m => string.IsNullOrWhiteSpace(m.Value)).Matches("^[a - zA - Z0 - 9] *$");
            RuleFor(x => x.Value).NotEmpty().When(m => string.IsNullOrWhiteSpace(m.Key));

        }
    }
}