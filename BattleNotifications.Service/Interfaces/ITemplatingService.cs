namespace BattleNotifications.Service.Interfaces
{
    using System.Collections.Generic;
    using Contracts.Domain.V1;

    public interface ITemplatingService
    {
        (string, string, string) BuildEmailSubjectAndBody(EmailTemplateChoices templateName, object parameters);

        object BuildTemplateData(List<KeyValueTemplatePairs> pairs);
    }
}