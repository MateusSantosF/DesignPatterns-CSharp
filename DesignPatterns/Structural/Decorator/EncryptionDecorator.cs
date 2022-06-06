using DesignPatterns.Structural.Decorator.model;

namespace DesignPatterns.Structural.Composite
{

    
    public class EncryptionDecorator : DataSourceDecorator
    {
        /// <summary>
        /// Permite acoplar comportamentos para objetos ao coloca-lós dentro de wrappers que possuem outros comportamentos.<para />
        /// Quando Utilizar: <para />Utilize o padrão Decorator quando você precisa ser capaz de projetar comportamentos
        /// adicionais para objetos em tempo de execução sem quebrar o código que usa esses objetos;
        /// <para />Utilize o padrão quando é complicado ou impossível estender o comportamento de um objeto usando herança.
        /// </summary>
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
