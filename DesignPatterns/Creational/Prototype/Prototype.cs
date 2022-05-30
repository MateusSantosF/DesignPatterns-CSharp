using DesignPatterns.creational.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype
{

    /// <summary>
    ///  Utilize o padrão Prototype quando seu código não deve depender de classes concretas de objetos que você precisa copiar.
    ///  Ao invés de instanciar uma subclasse que coincide com alguma configuração, o cliente pode simplesmente procurar por
    ///  um protótipo apropriado e cloná-lo (Com o padrão Factory ficará mais claro).
    /// </summary>
    internal class Prototype : IPrototype
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public ChildrenPrototype children;

        //TODO: Another and more complexy form to make the DeepClone
        public IPrototype DeepClone()
        {
            var copy = new Prototype() { Age = Age, Name = Name, children = new ChildrenPrototype() { Id = children.Id } };
            return copy;
        }

        public IPrototype ShallowClone()
        {
            return (Prototype)MemberwiseClone();
        }
    }

    public class ChildrenPrototype
    {

        public int Id { get; set; }

        public ChildrenPrototype() { }
    }

}
