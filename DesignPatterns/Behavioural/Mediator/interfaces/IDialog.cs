using DesignPatterns.Behavioural.Mediator.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Mediator.interfaces
{
    public interface IDialog
    {

        void Notify(Component component, string evt);
    }
}
