using DesignPatterns.Behavioural.Memento.interfaces;
using DesignPatterns.Behavioural.Memento.model;

namespace DesignPatterns.Behavioural.Memento
{
    public class Caretake
    {
        private List<ISnapshot> _snapshots = new List<ISnapshot>();
        private Originator _originator;

        public Caretake(Originator originator)
        {
            _originator = originator;
        }

        public void Backup()
        {
            _snapshots.Add(_originator.Backup());
        }

        public void Undo()
        {
            if(_snapshots.Count > 0)
            {
                var snapshot = _snapshots.Last();
                _snapshots.Remove(snapshot);
                _originator.Restore(snapshot);
            }
        }


        public void ShowHistory()
        {
         
            _snapshots.ForEach(item =>
            {
                Console.WriteLine((item as Snapshot).Name);
            });
        }


    }
}
