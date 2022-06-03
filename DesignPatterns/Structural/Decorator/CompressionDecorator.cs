using DesignPatterns.Structural.Decorator.model;

namespace DesignPatterns.Structural.Decorator
{
    internal class CompressionDecorator : DataSourceDecorator
    {
        public CompressionDecorator(DataSource dataSource) : base(dataSource)
        {
        }

        public override string ReadData()
        {
            Console.WriteLine("Descompressing data...");
            return base.ReadData();
        }

        public override void WriteData(string data)
        {
            Console.WriteLine("Compressing data...");
            base.WriteData(data);
        }
    }
}
