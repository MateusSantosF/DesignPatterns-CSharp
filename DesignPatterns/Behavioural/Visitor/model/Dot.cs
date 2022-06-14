using DesignPatterns.Behavioural.Visitor.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Visitor.model
{
    public class Dot : IShape
    {

        public Tuple<int, int> Coordinates;

        public Dot(int x, int y) {
            Coordinates = new Tuple<int, int>(x, y);
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitDot(this);
        }

        public void Draw()
        {
            Console.WriteLine("I'm Dot");
        }
    }
}
