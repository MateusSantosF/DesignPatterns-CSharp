using DesignPatterns.Behavioural.Mediator.interfaces;
using DesignPatterns.Behavioural.Mediator.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Mediator
{
    public class SimpleDialog:IDialog
    {

        private Button _button;
        private Checkbox _checkBox;
        

        public void RegisterComponent(Component component)
        {
            if(component is Button)
            {
                _button = (Button) component;
            }
            else
            {
                _checkBox = (Checkbox) component;
            }
        }

        public void Notify(Component component, string evt)
        {
            Console.WriteLine("Mediator say: ");
            
            if(component is Button || evt.Equals("ClickButton"))
            {
                Console.WriteLine("Button clicked");
            }
            else
            {
                Console.WriteLine("Checkbox Checked");
            }
        }
    }
}
