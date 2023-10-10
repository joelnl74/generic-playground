# generic-playground
Unity generic components
- Messaging decouple systems by using messaging to different systems in your game
- Singleton contains a generic singleton wrapper class
- Zenject by https://github.com/modesttree/Zenject for dependency injection
- Presenter view view controller architecture
- MVVP Core view architecture (Model, viewcontroller, view, presenter)


## Messaging:
Download package: https://joel-van-der-werf.com/messagebus.rar 

### Messaging example:

Create message by inheriting from the Imessage class.

```
using Messaging.Interfaces;

public class ToastMessage : IMessage
{
    public string title;
    public string message;
}
```

Subscribe class to the messagebuss listening to specific messages.

```
public class ToastController : MonoBehaviour
    ,IToastController
    ,ISubscriber<ToastMessage>
{
    [SerializeField] private ToastView _toastView;

    private void Awake()
        => MessageBus.Get().Subscribe(this);

    public void OnMessage(ToastMessage message)
        => _toastView.Show(message.title, message.message);
}
```

Publish message from anywhere in your game.

```
private void ShowToast()
{
  _messageBus.Publish(new ToastMessage()
  {
    title = "Test Title",
    message = "Test toast message"
  });
}
```
