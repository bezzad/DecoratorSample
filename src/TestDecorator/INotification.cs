using System;

namespace TestDecorator
{
    public interface INotification : IDisposable
    {
        INotification Factory();
        void Release();
        INotificationResult Notify(INotificationArguments args);
    }
}