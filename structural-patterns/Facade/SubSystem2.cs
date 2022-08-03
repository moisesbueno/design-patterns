using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facade
{
    public class SubSystem2
    {
        public string Operation1(){
            return "Subsytem2:get ready !\n";
        }

        public string OperationZ(){
            return "Subsystem: Fire !\n";
        }
    }
}