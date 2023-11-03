using Amazon.SQS.Model;
using SqsSnsIntegration.Api.Models;

namespace SqsSnsIntegration.Api.Services
{
    public interface ISqsService
    {
        Task<SendMessageResponse> SendMessageToSqsQueue(NotificationRequest request);
    }
}
