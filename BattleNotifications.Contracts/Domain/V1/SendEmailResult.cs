namespace BattleNotifications.Contracts.Domain.V1
{
    using System;
    using System.Collections.Generic;

    public class SendEmailResult
    {
        public Guid TrackingId { get; set; }

        public IEnumerable<string> Errors { get; set; }

        public string Message { get; set; }

        public bool Success { get; set; }

        public string SesMessageId { get; set; }
    }
}