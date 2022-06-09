using DesignPatterns.Structural.Decorator.model;

namespace DesignPatterns.Structural.Composite
{

    
    public class EncryptionDecorator : DataSourceDecorator
    {
        public EncryptionDecorator(DataSource dataSource) : base(dataSource)
        {
        }

        public override string ReadData()
        {
            Console.WriteLine("Decrypting...");
            return Decode(base.ReadData());
        }

        public override void WriteData(string data)
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
