using Regulus.Network;
using Regulus.Network.Tcp;
using System;
using System.Net.Sockets;
using System.Threading.Tasks;
namespace Astringent.Remote.UnityClient
{
    public class TcpConnecter : AgentStream
    {
        public readonly Connecter Connecter;
       
        public TcpConnecter()
        {
            Connecter = new Regulus.Network.Tcp.Connecter();
            Connecter.SocketErrorEvent += _Error;
        }

        private void _Error(SocketError error)
        {
            ErrorEvent.Invoke(error);            
        }

        public override IStreamable Native => Connecter;


        public UnityEngine.Events.UnityEvent<SocketError> ErrorEvent;
    }
}
