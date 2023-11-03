using Amazon.SQS;
using Amazon.SQS.Model;
using SqsSnsIntegration.Api.Models;
using System.Text.Json;

namespace SqsSnsIntegration.Api.Services
{
    public class SqsService : ISqsService
    {
        private readonly IAmazonSQS _sqsClient;

        public SqsService(IAmazonSQS sqsClient)
        {
            _sqsClient = sqsClient;
        }

        public async Task<SendMessageResponse> SendMessageToSqsQueue(NotificationRequest request)
        {

            var notificationRequestSer = JsonSerializer.Serialize(request, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            var sendMessageRequest = new SendMessageRequest
            {
                QueueUrl = "https://sqs.ap-southeast-1.amazonaws.com/374313759171/SNSToSQSQueue",
                MessageBody = notificationRequestSer

            };

            return await _sqsClient.SendMessageAsync(sendMessageRequest);
        }
    }
}
