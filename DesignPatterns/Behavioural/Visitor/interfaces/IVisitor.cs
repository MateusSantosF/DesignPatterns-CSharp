using DesignPatterns.Behavioural.Visitor.model;

namespace DesignPatterns.Behavioural.Visitor.interfaces
{
    public interface IVisitor
    {

        void VisitDot(Dot dot);

        void VisitSquare(Square square);
    }
}
