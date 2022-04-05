using UnityEngine;
namespace Astringent.Remote.UnityClient
{
    public abstract class AgentStream : MonoBehaviour
    {
        public abstract Regulus.Network.IStreamable Native { get; }

        
    }

}
