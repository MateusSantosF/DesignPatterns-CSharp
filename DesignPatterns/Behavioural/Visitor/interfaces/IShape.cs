namespace DesignPatterns.Behavioural.Visitor.interfaces
{
    public interface IShape
    {

        void Draw();
        void Accept(IVisitor visitor);
    }
}
