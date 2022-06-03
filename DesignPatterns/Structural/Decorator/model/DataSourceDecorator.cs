using DesignPatterns.Structural.Composite.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite.model
{
    public class DataSourceDecorator : DataSource
    {
        private DataSource wrappee; 
        public DataSourceDecorator(DataSource dataSource)
        {
            wrappee = dataSource;
        }
        public override string ReadData()
        {
            return wrappee.ReadData();
        }

        public override void WriteData(string data)
        {
            wrappee.WriteData(data);
        }
    }
}
