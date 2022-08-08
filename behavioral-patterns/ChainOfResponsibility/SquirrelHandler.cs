using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class SquirrelHandler: AbstractHandler
    {
        public override object Handle(object request)
        {
            if(request.ToString() == "Nut"){
                return $"Squirrel : I'ill eat the {request.ToString()}\n";
            }
            
            return base.Handle(request);
        }
    }
}