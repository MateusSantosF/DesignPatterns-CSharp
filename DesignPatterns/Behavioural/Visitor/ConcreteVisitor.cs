using DesignPatterns.Behavioural.Visitor.interfaces;
using DesignPatterns.Behavioural.Visitor.model;

namespace DesignPatterns.Behavioural.Visitor
{
    public class ConcreteVisitor : IVisitor
    {
        public void VisitDot(Dot dot)
        {
            Console.WriteLine("Export Dot coordinates: (" + dot.Coordinates.Item1 + ", " + dot.Coordinates.Item2 + ")");
        }

        public void VisitSquare(Square square)
        {
            Console.WriteLine("Export Square coordinates: (" + square.Coordinates.Item1 + ", " + square.Coordinates.Item2 + ")");
        }
    }
}
