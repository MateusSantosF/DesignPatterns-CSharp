using DesignPatterns.Program.factorys.interfaces;
using DesignPatterns.Structural.Composite;
using DesignPatterns.Structural.Composite.model;
using DesignPatterns.Structural.Decorator;
using DesignPatterns.Structural.Decorator.model;
using DesignPatterns.Structural.Facade;
using DesignPatterns.Structural.Flyweight.model;
using System.Text;

namespace DesignPatterns.Program.factorys
{
    public class StructuralPatternFactory : IFactory
    {
        public string Show(string patternName)
        {
            switch (patternName)
            {
                case Constants.COMPOSITE:

                    var pen = new Product("Pen", 2.5f);
                    var smartphone = new Product("Smartphone", 2500.00f);
                    var tablet = new Product("Tablet", 1000f);

                    var produtBox = new Box();
                    produtBox.AddItem(pen);
                    produtBox.AddItem(smartphone);
                    produtBox.AddItem(tablet);

                    var shirt = new Product("Shirt", 30.00f);
                    var pants = new Product("Pants", 10f);

                    var anotherProductBox = new Box();
                    anotherProductBox.AddItem(shirt);
                    anotherProductBox.AddItem(pants);

                    produtBox.AddItem(anotherProductBox);

                    return $"Sale total price:{produtBox.GetPrice()}";
                  
                case Constants.DECORATOR:
                    var encrypt = true;
                    var compress = true;
                    var simple = new FileDataSource();
                    DataSourceDecorator? source = null;

                    if (encrypt)
                    {
                        source = new EncryptionDecorator(simple);
                    }
                    if (compress)
                    {
                        if (source != null)
                        {
                            source = new CompressionDecorator(source);
                        }
                        else
                        {
                            source = new CompressionDecorator(simple);
                        }
                    }
                    source.WriteData("Anything");
                    return source.ReadData();

                case Constants.FACADE:
                    VideoConverterFacade converter = new VideoConverterFacade();
                    string mp4Video = converter.Convert("youtubevideo.ogg", "mp4");
                    return "";
                  
                case Constants.FLYWEIGHT:
                    Florest florest = new Florest();

                    for (int i = 0; i < 25; i++)
                    {
                        if (i % 2 == 0)
                        {
                            florest.PlantTree(i, i, "OAK", "red", "textureOAK.png");
                        }
                        else
                        {
                            florest.PlantTree(i, i, "Autumn", "blue", "textureAutumn.png");
                        }
                    }
                    StringBuilder sb = new StringBuilder();

                    florest.Trees.ForEach(tree =>
                    {
                        sb.Append(tree.Type.ToString() + "\n");
                    });

                    return sb.ToString();
                default:
                    return "";

            }
        }
    }
}
