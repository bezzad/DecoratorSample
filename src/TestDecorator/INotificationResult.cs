namespace TestDecorator
{
    public interface INotificationResult
    {
        INotificationArguments Arguments { get; set; }
        NotificationResponseStatus Status { get; set; }
        string Result { get; set; }
    }
}