namespace TestDecorator
{
    public class NotificationResult : INotificationResult
    {
        public INotificationArguments Arguments { get; set; }
        public NotificationResponseStatus Status { get; set; }
        public string Result { get; set; }
    }
}