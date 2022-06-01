using DesignPatterns.Structural.Facade.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade.model
{
    public class OggCompressionCodec: ICodec
    {

        public string type = "ogg";
    }
}
