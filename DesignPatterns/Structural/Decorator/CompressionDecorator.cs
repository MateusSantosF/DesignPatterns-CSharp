using DesignPatterns.Structural.Composite.interfaces;
using DesignPatterns.Structural.Composite.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
