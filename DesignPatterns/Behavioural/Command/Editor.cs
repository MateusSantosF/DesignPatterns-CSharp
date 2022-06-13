using DesignPatterns.Behavioural.CommandPattern.model;

namespace DesignPatterns.Behavioural.CommandPattern
{
    public class Editor
    {
        private CommandHistory commandHistory = new CommandHistory();
        public string Clipboard { get; set; }

        public string CurrentText { get; set; }

        public string SelectedText { get; set; }


        public Editor() { }

        public bool UndoChanges()
        {
            if (!commandHistory.IsEmpty()) return false;

            Command command = commandHistory.Pop();

            command.Undo();       
       
            return true;
        }

        public void RegisterCommand(Command command)
        {
            commandHistory.Push(command);
        }
    }
}
