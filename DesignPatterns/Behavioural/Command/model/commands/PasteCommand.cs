namespace DesignPatterns.Behavioural.CommandPattern.model
{
    public class PasteCommand : Command
    {
        public PasteCommand(Editor editor) : base(editor)
        {
        }

        public override bool Execute()
        {
            if (Editor.Clipboard is null || Editor.Clipboard == string.Empty) return false;

            Editor.RegisterCommand(this);
            base.Backup();
            Editor.CurrentText = Editor.CurrentText + " " +  Editor.Clipboard;
            return true;
        }
    }
}
