using Regulus.Remote;
using Regulus.Remote.Ghost;
using System;
namespace Astringent.Remote.UnityClient
{
    class EmptyAgent : IAgent
    {
        bool IAgent.Active => false;

        long IAgent.Ping => 0;

        event Action<string, string> IAgent.ErrorMethodEvent
        {
            add
            {

            }

            remove
            {

            }
        }

        void IDisposable.Dispose()
        {

        }

        INotifier<T> INotifierQueryable.QueryNotifier<T>()
        {
            return new Regulus.Remote.TProvider<T>();
        }

        void IAgent.Update()
        {
        
        }
    }

}
