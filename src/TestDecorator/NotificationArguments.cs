namespace TestDecorator
{
    public class NotificationArguments : INotificationArguments
    {
        public string To { get; set; }
        public string From { get; set; }
        public string Message { get; set; }
        public INotificationCertification Certification { get; set; }
    }
}