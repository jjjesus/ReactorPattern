using System.Net.Sockets;

namespace ReactorPattern
{
    public interface IEventHandler
    {
        void HandleEvent(byte[] data);
        TcpListener GetHandler();
    }
}
