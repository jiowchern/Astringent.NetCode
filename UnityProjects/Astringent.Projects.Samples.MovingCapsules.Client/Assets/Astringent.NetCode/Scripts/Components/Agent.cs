using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Regulus.Remote.Ghost;

namespace Astringent.NetCode.Components
{
    [RequireComponent(typeof(ProtocolProvider),typeof(StreamProvider) )]
    public class Agent : MonoBehaviour
    {
        public string Channel;
        
        
       

        System.Action _Update;
        System.Action _OnDispose;
        public IAgent Native { get; private set; }

        public Agent()
        {
            Channel = "Default";
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
            /*
             *  public ProtocolProvider Protocol;
        
        public StreamProvider Stream;
             */
            var protocolProvider = GetComponent<ProtocolProvider>();
            var streamProvider = GetComponent<StreamProvider>();
            _OnDispose();            
            var protocol = Regulus.Remote.Client.Provider.CreateAgent(protocolProvider.Protocol, streamProvider.Native, protocolProvider.Serializer);
            Native = protocol;
            _Update = Native.Update;
            _OnDispose = Native.Dispose;
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


