using DesignPatterns.Behavioural.Memento.interfaces;
using DesignPatterns.Behavioural.Memento.model;

namespace DesignPatterns.Behavioural.Memento
{
    public class Originator
    {
        private string Name;
        private string State;

        public Originator(string state, string name)
        {
            State = state;
            Name = name;
        }

        public ISnapshot Backup()
        {
            return new Snapshot(State, Name);
        }

        public void Restore(ISnapshot snapshot)
        {
            if(snapshot is Snapshot)
            {
                State = snapshot.GetState();
            }
          
        }

        public void DoSomething()
        {
            State = new Random().NextDouble().ToString();
        }

        public void ShowState()
        {
            Console.WriteLine("Actual state: " + State);
        }


    }
}
