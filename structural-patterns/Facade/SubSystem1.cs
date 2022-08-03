using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facade
{
    public class SubSystem1
    {
        public string Operation1(){
            return "Subsystem1:Ready !\n";
        }

        public string OperationN(){
            return "Subsytem1: Go!\n";
        }
    }
}