using Messaging;
using Messaging.Interfaces;
using Zenject;

public class ToastPresenter : IToastPresenter
{
    private IMessageBus _messageBus;

    public ToastPresenter(IMessageBus messageBus)
    {
        _messageBus = messageBus;
    }

    public void Publish(string title, string message)
    {
        _messageBus.Publish(new ToastMessage()
        {
            title = "Test Title",
            message = message
        });
    }
}