using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Iterator.interfaces
{
    public interface MyIterator
    {

        int GetNext();
        bool HasNext();
    }
}
