using Regulus.Remote;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Astringent.Remote.Showcase
{
    public class Protocol : Astringent.Remote.UnityClient.AgentProtocol
    {
        private readonly IProtocol _Native;

        public Protocol()
        {
            _Native = Astringent.Remote.UnitySources.TestProtocol.ProtocolProvider.CreateCase();


        }
        
        public override IProtocol Native => _Native;

        
    }

}
