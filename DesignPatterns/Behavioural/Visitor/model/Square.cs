using DesignPatterns.Behavioural.Visitor.interfaces;

namespace DesignPatterns.Behavioural.Visitor.model
{
    public class Square : IShape
    {

        public Tuple<int, int> Coordinates;

        public Square(int x, int y)
        {
            Coordinates = new Tuple<int, int>(x, y);
        }
        public void Accept(IVisitor visitor)
        {
            visitor.VisitSquare(this);
        }

        public void Draw()
        {
            Console.WriteLine("I'm Square!");
        }
    }
}
