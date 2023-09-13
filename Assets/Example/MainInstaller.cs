using Messaging;
using Messaging.Interfaces;
using UnityEngine;
using Zenject;

public class MainInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        // Messagebus
        Container.Bind<IMessageBus>().To<MessageBus>().AsSingle();

        // Presenter
        Container.Bind<IToastPresenter>().To<ToastPresenter>().AsSingle();
    }
}