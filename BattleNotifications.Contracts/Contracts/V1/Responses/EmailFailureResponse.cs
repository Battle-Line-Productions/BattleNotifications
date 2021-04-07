namespace BattleNotifications.Contracts.Contracts.V1.Responses
{
    using System;
    using System.Collections.Generic;

    public class EmailFailureResponse
    {
        public bool Success { get; set; }

        public IEnumerable<string> Errors { get; set; }

        public Guid TrackingId { get; set; }
    }
}