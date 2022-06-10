using DesignPatterns.Program;

namespace Program
{
    public class Program
    {
        /// <summary>
        /// Explore design patterns using Builder below!
        /// 
        /// Creational Patterns
        ///     - [x] SimpleFactory
        ///     - [x] Abstract Factory
        ///     - [x] Singleton
        ///     - [x] Prototype
        ///     - [x] Builder
        /// Structural Patterns
        ///     - [x] Facade<br>
        ///     - [x] Decorator<br>
        ///     - [x] Composite<br>
        ///     - [x] Flyweight<br>
        ///     - [x] Proxy<br>
        ///     - [x] Bridge<br>
        ///     - [x] Adapter<br>
        /// </summary>
        public static void Main(string[] args)
        {
            
            string pattern = DesignPattern.ChoosePattern().StructuralPatterns().Proxy();
            Console.WriteLine(pattern);
  

        }
    }
}


