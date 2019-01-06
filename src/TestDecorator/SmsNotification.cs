using System;

namespace TestDecorator
{
    public class SmsNotification : INotification
    {
        public void Dispose()
        {
            Release();
        }

        public INotification Factory()
        {
            // SMS factory
            return new SmsNotification();
        }

        public void Release()
        {
            // dispose any objects
        }

        public INotificationResult Notify(INotificationArguments args)
        {
            // send SMS and response result
            var resp = new NotificationResult()
            {
                Arguments = args,
                Result = "SMS Sent Successfully",
                Status = NotificationResponseStatus.Success
            };
            Console.WriteLine($"Sent `{resp.Arguments.Message}` SMS to [{resp.Arguments.To}] from [{resp.Arguments.From}]");

            return resp;
        }
    }
}