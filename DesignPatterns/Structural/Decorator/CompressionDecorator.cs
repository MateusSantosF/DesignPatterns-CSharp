using DesignPatterns.Structural.Decorator.model;

namespace DesignPatterns.Structural.Decorator
{
    internal class CompressionDecorator : DataSourceDecorator
    {

        /// <summary>
        /// Permite acoplar comportamentos para objetos ao coloca-lós dentro de wrappers que possuem outros comportamentos.<para />
        /// Quando Utilizar: <para />Utilize o padrão Decorator quando você precisa ser capaz de projetar comportamentos
        /// adicionais para objetos em tempo de execução sem quebrar o código que usa esses objetos;
        /// <para />Utilize o padrão quando é complicado ou impossível estender o comportamento de um objeto usando herança.
        /// </summary>
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
