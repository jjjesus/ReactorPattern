namespace ReactorPattern
{
    public interface IReactor
    {
        void RegisterHandle(IEventHandler eventHandler);
        void RemoveHandle(IEventHandler eventHandler);
        void HandleEvents();
    }
}