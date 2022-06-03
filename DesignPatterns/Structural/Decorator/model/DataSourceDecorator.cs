using DesignPatterns.Structural.Decorator.model;

namespace DesignPatterns.Structural.Decorator.model
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
