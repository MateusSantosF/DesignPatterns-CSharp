using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.AbstractFactory.interfaces;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.Prototype;
using DesignPatterns.Creational.SimpleFactory;
using DesignPatterns.Creational.Singleton;
using DesignPatterns.Program.factorys.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Program.factorys
{
    public class CreationalPatternFactory: IFactory
    {

        public CreationalPatternFactory() { }
            
        public string Show(string patternName)
        {
            StringBuilder sb = new StringBuilder();

            switch (patternName)
            {
                case Constants.BUILDER:
                    Director director = new Director();
                    SportBuilder builder = new SportBuilder();
                    director.makeSportCar(builder);
                    return "Car built:" + builder.getResult().GetType().ToString();
                case Constants.PROTOTYPE:
                    var prop = new Prototype() { Age = 20, Name = "Mateus", children = new ChildrenPrototype() { Id = 2 } };
                    sb.Append("Initial ID = " + prop.children.Id + "\n");

                    var copy = (Prototype)prop.ShallowClone();
                    copy.Name = "Joao";
                    sb.Append("\nOriginal name =" + prop.Name);
                    sb.Append("\nShallow Copy Name =" + copy.Name);

                    var anotherCopy = (Prototype)prop.DeepClone();
                    anotherCopy.children.Id = 20;
                    sb.Append("\nOriginal Id =" + prop.children.Id);
                    sb.Append("\nDeep Copy ID =" + anotherCopy.children.Id);
                    return sb.ToString();
                case Constants.SINGLETON:          
                    var singleton = Singleton.getInstance();
                    singleton.bussinesLogic();
                    return "";
                case Constants.ABSTRACT_FACTORY:
                    var optionFactory = 1;
                    IAbstractFactory? factory = null;
                    if (optionFactory == 0)
                    {
                        factory = new ModernAbstractFactory();
                    }
                    else
                    {
                        factory = new VintageAbstractFactory();
                    }

                    var chair = factory.createChair();
                    var table = factory.createTable();
                    var sofa = factory.createSofa();

                    sb.Append(chair.ToString() + " Chair");
                    sb.Append(table.ToString() + " Table");
                    sb.Append(sofa.ToString() + " Sofa");

                    return sb.ToString();
                case Constants.SIMPLE_FACTORY:
                    var result = SimpleFactory.Make("Margherita");
                    return result.GetType().ToString();
                default:
                    return "Creational pattern name not found";

            }
        }
        
    }
}
