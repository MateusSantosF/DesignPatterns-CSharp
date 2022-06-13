using DesignPatterns.Behavioural.Memento.interfaces;

namespace DesignPatterns.Behavioural.Memento.model
{
    public class Snapshot : ISnapshot
    {
        private string state;
        public string Name { get; set; } 
        public Snapshot( string state, string originatorName)
        {
            this.state = state;
            Name = DateTime.Now.ToString() + "SnapTo_" + originatorName;
        }

        public string GetState()
        {
           return state;
        }
    }
}
