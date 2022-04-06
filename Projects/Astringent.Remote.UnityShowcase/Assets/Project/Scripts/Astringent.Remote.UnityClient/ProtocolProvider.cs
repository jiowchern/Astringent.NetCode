using UnityEngine;
namespace Astringent.Remote.UnityClient
{
    public abstract class ProtocolProvider : MonoBehaviour 
    {
        public abstract Regulus.Remote.IProtocol Protocol{ get; }
        public virtual Regulus.Remote.ISerializable Serializer { get { return new Regulus.Remote.Serializer(Protocol.SerializeTypes); } }

    }

}
