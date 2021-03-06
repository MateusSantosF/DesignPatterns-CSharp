using DesignPatterns.Structural.Decorator.model;

namespace DesignPatterns.Structural.Decorator.model
{
    public abstract class DataSourceDecorator : DataSource
    {
        protected DataSource wrappee; 
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
