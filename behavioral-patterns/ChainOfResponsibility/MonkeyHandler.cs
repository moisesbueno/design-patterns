using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class MonkeyHandler: AbstractHandler
    {
        public override object Handle(object request){
            if((request as string) == "Banana"){
                return $"Monkey : I'ill eat the {request.ToString()}.\n";
            }else{
                return base.Handle(request);
            }
        }
    }
}