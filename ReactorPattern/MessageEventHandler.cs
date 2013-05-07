using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ReactorPattern
{
    public class MessageEventHandler : IEventHandler
    {
        private readonly TcpListener _listener;

        public MessageEventHandler(IPAddress ipAddress, int port)
        {
            _listener = new TcpListener(ipAddress, port);
            System.Console.WriteLine("Starting listener on {0} : {1}", ipAddress, port);
            _listener.Start();
        }

        public void HandleEvent(byte[] data)
        {
        	System.Console.WriteLine("Got data len:{0}", data.Length);
            string message = Encoding.UTF8.GetString(data);
        }

        public TcpListener GetHandler()
        {
            return _listener;
        }
    }
}
