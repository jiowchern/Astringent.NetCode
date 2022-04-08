using UnityEngine;

namespace Astringent.NetCode.Components
{
    public abstract class StreamProvider : MonoBehaviour
    {
        public abstract Regulus.Network.IStreamable Native { get; }
    }
}


