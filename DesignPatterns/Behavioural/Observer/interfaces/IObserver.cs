namespace DesignPatterns.Behavioural.Observer.interfaces
{
    public interface IObserver
    {
        void Update(ISubject subject);

        string GetName();
    }
}
