using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.creational.interfaces
{
    public interface IPrototype
    {
        IPrototype ShallowClone();
        IPrototype DeepClone();
    }
}
