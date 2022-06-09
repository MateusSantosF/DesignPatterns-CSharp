namespace DesignPatterns.Structural.Flyweight.model
{
    public class TreeType
    {
        public string Name { get; }
        public string Color { get;  }
        public string Texture { get; }

        public TreeType(string name, string color, string texture)
        {
            Name = name;
            Color = color;
            Texture = texture;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
