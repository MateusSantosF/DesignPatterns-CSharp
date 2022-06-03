namespace DesignPatterns.Structural.Decorator.model
{
    public abstract class DataSource
    {
        public abstract void WriteData(string data);
        public abstract string ReadData();

    }
}
