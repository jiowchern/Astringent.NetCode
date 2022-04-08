using UnityEngine;

namespace Astringent.NetCode.Components
{
    public abstract class ProtocolProvider : MonoBehaviour
    {
        public abstract Regulus.Remote.IProtocol Protocol { get; }
        public virtual Regulus.Remote.ISerializable Serializer { get { return new Regulus.Remote.Serializer(Protocol.SerializeTypes); } }

    }
}


