using DesignPatterns.Structural.Composite.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite.model
{
    public class DataSourceDecorator : IDataSource
    {
        private IDataSource wrappee; 
        public DataSourceDecorator(IDataSource dataSource)
        {
            wrappee = dataSource;
        }
        public string ReadData()
        {
            return wrappee.ReadData();
        }

        public void WriteData(string data)
        {
            wrappee.WriteData(data);
        }
    }
}
