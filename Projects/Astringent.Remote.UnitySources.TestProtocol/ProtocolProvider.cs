namespace Astringent.Remote.UnitySources.TestProtocol
{
    public static partial class ProtocolProvider
    {
        public static Regulus.Remote.IProtocol CreateCase()
        {
            Regulus.Remote.IProtocol protocol = null;
            _CreateCase(ref protocol);
            return protocol;
        }

        [Regulus.Remote.Protocol.Creater]
        static partial void _CreateCase(ref Regulus.Remote.IProtocol protocol);
    }
}
