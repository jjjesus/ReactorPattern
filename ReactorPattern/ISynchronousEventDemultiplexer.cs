using System.Collections.Generic;
using System.Net.Sockets;

namespace ReactorPattern
{
    public interface ISynchronousEventDemultiplexer
    {
        IList<TcpListener> Select(ICollection<TcpListener> listeners);
    }
}