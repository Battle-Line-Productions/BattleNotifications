namespace BattleNotifications.Contracts.Contracts.V1.Requests
{
    using System.Collections.Generic;
    using Domain.V1;

    public class EmailSendRequest
    {
        public string To { get; set; }
        
        public string From { get; set; }

        public string TemplateChoice { get; set; }

        public List<KeyValueTemplatePairs> TemplateData { get; set; }
    }
}