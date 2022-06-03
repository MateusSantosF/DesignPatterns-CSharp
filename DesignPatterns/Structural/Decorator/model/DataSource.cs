using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator.model
{
    public abstract class IDataSource
    {
        public abstract void WriteData(string data);
        public abstract string ReadData();

    }
}
