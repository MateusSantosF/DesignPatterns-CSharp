using DesignPatterns.Structural.Composite.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite.model
{
    public class FileDataSource : DataSource
    {
        string FileName;


        public override string ReadData()
        {
            return FileName;
        }

        public override void WriteData(string data)
        {
           FileName = data;
        }

 
    }
}
