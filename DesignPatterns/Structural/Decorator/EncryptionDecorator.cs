using DesignPatterns.Structural.Composite.interfaces;
using DesignPatterns.Structural.Composite.model;

namespace DesignPatterns.Structural.Composite
{
    public class EncryptionDecorator : DataSourceDecorator
    {
        public EncryptionDecorator(IDataSource dataSource) : base(dataSource)
        {
        }

        public new string ReadData()
        {
            return Decode(base.ReadData());
        }

        public new void WriteData(string data)
        {

            Console.WriteLine("Encrypting...");
            base.WriteData(data);
        }

        private string Decode(string data)
        {
            //Make things
            return data;
        }
    }
}
