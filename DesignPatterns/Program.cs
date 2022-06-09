using DesignPatterns.Program;

namespace Program
{

    public class Program
    {
        public static void Main(string[] args)
        {

            string pattern = DesignPattern.ChoosePattern().StructuralPatterns().Decorator();
            Console.WriteLine(pattern);
        }
    }
}


