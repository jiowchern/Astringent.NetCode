using Regulus.Remote.Ghost;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Astringent.Remote.UnityClient
{
    public class Agent : MonoBehaviour
    {
        
        public string Channel;

        
        public AgentProtocol Protocol;
        public AgentStream Stream;
        public CustomSerializer Serializer;

        
        public IAgent Native { get; private set; }

        public Agent()
        {
            Native = new EmptyAgent();
        }
        public void Reset()
        {
            if(Native !=null)
                Native.Dispose();

            _Setup();
        }
        private void Start()
        {
          
            _Setup();
        }

        private void _Setup()
        {
            if (Protocol == null)
                return;

            if (Stream == null)
                return;

            Regulus.Remote.ISerializable serializer = new Regulus.Remote.Serializer(Protocol.Native.SerializeTypes);
            if (Serializer != null)
            {
                serializer = Serializer.Native;
            }
            Native = Regulus.Remote.Client.Provider.CreateAgent(Protocol.Native, Stream.Native, serializer);
        }

        private void Update()
        {
            Native.Update();
        }

        private void OnDestroy()
        {
            Native.Dispose();
        }



    }

}
