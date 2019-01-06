namespace TestDecorator
{
    public interface INotificationArguments
    {
        string To { get; set; }
        string From { get; set; }
        string Message { get; set; }
        INotificationCertification Certification { get; set; }
    }
}