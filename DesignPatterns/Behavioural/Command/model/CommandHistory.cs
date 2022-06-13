namespace DesignPatterns.Behavioural.CommandPattern.model
{
    public class CommandHistory
    {

        private Stack<Command> commands = new Stack<Command>();

        public void Push(Command command)
        {
            commands.Push(command);
            
        }

        public Command Pop()
        {
            return commands.Pop();
        }

        public bool IsEmpty()
        {
            return commands.Any();
        }
    }
}
