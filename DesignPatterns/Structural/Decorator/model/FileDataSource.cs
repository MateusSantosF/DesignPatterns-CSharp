using DesignPatterns.Structural.Composite.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite.model
{
    public class FileDataSource : IDataSource
    {
        string FileName;


        public string ReadData()
        {
            return FileName;
        }

        public void WriteData(string data)
        {
           FileName = data;
        }

 
    }
}
