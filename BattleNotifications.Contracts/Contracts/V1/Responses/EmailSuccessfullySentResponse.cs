namespace BattleNotifications.Contracts.Contracts.V1.Responses
{
    using System;

    public class EmailSuccessfullySentResponse
    {
        public bool Success { get; set; }

        public string Message { get; set; }

        public Guid TrackingId { get; set; }

        public string SeSMessageId { get; set; }
    }
}