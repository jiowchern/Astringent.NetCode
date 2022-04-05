using UnityEngine;
namespace Astringent.Remote.UnityClient
{
    public abstract class AgentProtocol : MonoBehaviour 
    {
        public abstract Regulus.Remote.IProtocol Native{ get; }
        
    }

}
