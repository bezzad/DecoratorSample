using System;

namespace TestDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Send Simple SMS");
            var smsArgs = new NotificationArguments()
            {
                From = "John",
                To = "Server",
                Message = "TEST MESSAGE",
                Certification = new NotificationCertification()
            };

            var sms = new SmsNotification();
            DoSomething(sms, smsArgs);

            Console.WriteLine("\nWelcome to Decorator Pattern");
            DoSomething(new NotificationLogDecorator(sms), smsArgs);

            Console.ReadKey();
        }

        public static void DoSomething(INotification notification, INotificationArguments args)
        {
            // ...
            var resp = notification.Notify(args);
            Console.WriteLine($"response: {resp.Status}. `{resp.Result}`");
        }
    }
}
