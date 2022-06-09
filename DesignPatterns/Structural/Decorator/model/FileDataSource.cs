using DesignPatterns.Structural.Decorator.model;

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
