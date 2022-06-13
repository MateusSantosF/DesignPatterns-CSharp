namespace DesignPatterns.Behavioural.CommandPattern.model
{
    public class Button
    {

        private Command _Command;
        public Button(Command command)
        {
            _Command = command;
        }

        public bool Click()
        {
           return _Command.Execute();
        }
    }
}
