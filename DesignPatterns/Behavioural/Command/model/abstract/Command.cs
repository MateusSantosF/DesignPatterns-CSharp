namespace DesignPatterns.Behavioural.CommandPattern.model
{
    public abstract class Command
    {
        public Editor Editor { get; set; }

        private string _Backup { get; set; }

        public Command(Editor editor)
        {
            Editor = editor;
        }

        public abstract bool Execute();

        public void Backup()
        {
            _Backup = Editor.CurrentText;
        }

        public void Undo()
        {
            Editor.CurrentText = _Backup;
        }
    }
}
