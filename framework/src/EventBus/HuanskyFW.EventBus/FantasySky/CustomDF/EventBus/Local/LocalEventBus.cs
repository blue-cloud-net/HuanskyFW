using FantasySky.CstomDF.EventBus;
using FantasySky.CstomDF.EventBus.Local;
using HuanskyFW.DependencyInjection;

using Microsoft.Extensions.DependencyInjection;

namespace HuanskyFW.EventBus.Local;

[Dependency(typeof(ILocalEventBus), ServiceLifetime.Singleton)]
public class LocalEventBus : EventBusBase, ILocalEventBus
{
    public IDisposable Subscribe<TEvent>(ILocalEventHandler<TEvent> handler) where TEvent : IEvent
    {
        throw new NotImplementedException();
    }

    public void Unsubscribe<TEvent>(ILocalEventHandler<TEvent> handler) where TEvent : IEvent
    {
        throw new NotImplementedException();
    }
}
