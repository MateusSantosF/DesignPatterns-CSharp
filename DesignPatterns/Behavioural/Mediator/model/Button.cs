using DesignPatterns.Behavioural.Mediator.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Mediator.model
{
    public class Button : Component
    {
        public Button(IDialog dialog) : base(dialog)
        {
        }

        public override void Click()
        {
            _dialog.Notify(this, "ClickButton");
        }

    }
}
