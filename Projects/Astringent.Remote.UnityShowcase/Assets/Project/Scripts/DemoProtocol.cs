using Regulus.Remote;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Astringent.Remote.Showcase
{
    public class DemoProtocol : Astringent.Remote.UnityClient.ProtocolProvider
    {
        
        public override IProtocol Protocol => Astringent.Remote.UnitySources.TestProtocol.ProtocolProvider.CreateCase();
    }

}
