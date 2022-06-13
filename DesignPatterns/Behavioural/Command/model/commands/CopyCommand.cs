namespace DesignPatterns.Behavioural.CommandPattern.model
{
    public class CopyCommand : Command
    {
        public CopyCommand(Editor editor) : base(editor)
        {
        }

        public override bool Execute()
        {
            Editor.RegisterCommand(this);
            Editor.Clipboard = Editor.SelectedText;
            return true;
        }

    }
}
