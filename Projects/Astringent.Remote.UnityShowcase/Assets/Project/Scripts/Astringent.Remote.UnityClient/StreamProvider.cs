using UnityEngine;
namespace Astringent.Remote.UnityClient
{
    public abstract class StreamProvider : MonoBehaviour
    {
        public abstract Regulus.Network.IStreamable Native { get; }
    }

}
