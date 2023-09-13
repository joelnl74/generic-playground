using Messaging;
using Messaging.Interfaces;
using UnityEngine;
using Zenject;

public class ToastHandler : MonoBehaviour
    ,ISubscriber<ToastMessage>
{
    [SerializeField] private ToastView _toastView;

    private IMessageBus _messageBus;

    [Inject]
    public void Init(IMessageBus messageBus)
    {
        _messageBus = messageBus;
        _messageBus.Subscribe(this);
    }

    public void OnMessage(ToastMessage message)
        => _toastView.Show(message.title, message.message);
}
