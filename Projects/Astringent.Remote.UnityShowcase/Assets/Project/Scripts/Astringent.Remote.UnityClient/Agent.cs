using Regulus.Remote.Ghost;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Astringent.Remote.UnityClient
{
    public class Agent : MonoBehaviour
    {        
        public string Channel;
        
        public ProtocolProvider Protocol;
        public StreamProvider Stream;

        System.Action _Update;
        System.Action _OnDispose;
        public IAgent Native { get; private set; }

        public Agent()
        {
            _Update = () => { };
            _OnDispose = () => { };
        }
        public void Reset()
        {
            _Setup();
        }
        private void Start()
        {
          
            _Setup();
        }

        private void _Setup()
        {
            _OnDispose();
            var protocol = Regulus.Remote.Client.Provider.CreateAgent(Protocol.Protocol, Stream.Native, Protocol.Serializer);
            Native = protocol;
            _Update = Native.Update;
            _OnDispose= Native.Dispose;
        }

        private void Update()
        {
            _Update();
        }

        private void OnDestroy()
        {
            _OnDispose();
        }



    }

}
