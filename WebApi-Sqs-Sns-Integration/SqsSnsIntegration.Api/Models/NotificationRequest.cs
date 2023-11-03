namespace SqsSnsIntegration.Api.Models
{
    public class NotificationRequest
    {
        public Guid Id { get; set; }
        public string? Email { get; set; }
        public string? Descriptions { get; set; }

    }
}
