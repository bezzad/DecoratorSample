using System;

namespace TestDecorator
{
    public class NotificationLogDecorator : INotification
    {
        protected INotification InnerNotification { get; set; }
        private readonly ILog _logger = new Log();

        public NotificationLogDecorator(INotification notification)
        {
            InnerNotification = notification;
        }

        public void Dispose()
        {
            InnerNotification.Dispose();
        }

        public INotification Factory()
        {
            return new NotificationLogDecorator(InnerNotification.Factory());
        }

        public void Release()
        {
            InnerNotification.Release();
        }

        public INotificationResult Notify(INotificationArguments args)
        {
            try
            {
                _logger.Info("Notifying...");
                var result = InnerNotification.Notify(args);
                _logger.Info("Notify Completed");
                return result;
            }
            catch (Exception e)
            {
                _logger.Error("Error on Notify", e);
                return new NotificationResult()
                {
                    Arguments = args,
                    Status = NotificationResponseStatus.Fail,
                    Result = e.Message
                };
            }
        }
    }
}