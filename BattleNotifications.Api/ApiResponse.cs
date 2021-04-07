namespace BattleNotifications.Api
{
    using Contracts.Contracts.V1.Responses;
    using Contracts.Domain.V1;
    using Microsoft.AspNetCore.Mvc;

    public static class ApiResponse
    {
        public static ObjectResult GetActionResult<T>(ResultStatus status, Response<T> response)
        {
            return status switch
            {
                ResultStatus.Ok200 => new ObjectResult(response) { StatusCode = 200 },
                ResultStatus.Created201 => new ObjectResult(response) { StatusCode = 201 },
                ResultStatus.Accepted202 => new ObjectResult(response) { StatusCode = 202 },
                ResultStatus.Error400 => new ObjectResult(response) { StatusCode = 400 },
                ResultStatus.Error401 => new ObjectResult(response) { StatusCode = 401 },
                ResultStatus.Error404 => new ObjectResult(response) { StatusCode = 404 },
                ResultStatus.Error500 => new ObjectResult(response) { StatusCode = 500 },
                _ => new ObjectResult(response) { StatusCode = 500 }
            };
        }
    }
}