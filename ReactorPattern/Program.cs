using System.Net;


namespace ReactorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IEventHandler client1 = new MessageEventHandler(IPAddress.Parse("127.0.0.1"), 123);
            //IEventHandler client2 = new MessageEventHandler(IPAddress.Parse("234.234.234.234"), 123);
            //IEventHandler client3 = new MessageEventHandler(IPAddress.Parse("345.345.345.345"), 123);

            ISynchronousEventDemultiplexer synchronousEventDemultiplexer = new SynchronousEventDemultiplexer();

            Reactor dispatcher = new Reactor(synchronousEventDemultiplexer);

            dispatcher.RegisterHandle(client1);
            //dispatcher.RegisterHandle(client2);
            //dispatcher.RegisterHandle(client3);
            dispatcher.HandleEvents();

        }
    }
}
