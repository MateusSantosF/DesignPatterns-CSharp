using DesignPatterns.Behavioural.Mediator.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Mediator.model
{
    public abstract class Component
    {

        protected IDialog _dialog; 

        public Component(IDialog dialog)
        {
            _dialog = dialog;
        }

        public abstract void Click();

    }
}
