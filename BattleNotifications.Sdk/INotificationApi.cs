namespace BattleNotifications.Sdk
{
    using System.Threading.Tasks;
    using Contracts.Contracts.V1.Requests;
    using Contracts.Contracts.V1.Responses;
    using Refit;

    [Headers("Authorization: Bearer")]
    public interface INotificationApi
    {
        [Post("/api/v1/email")]
        Task<ApiResponse<Response<EmailSuccessfullySentResponse>>> SendEmailAsync([Body] EmailSendRequest emailSendRequest, [Header("x-api-key")] string apiKey);
    }
}
