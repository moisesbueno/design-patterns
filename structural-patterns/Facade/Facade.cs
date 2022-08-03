using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facade
{
    public class Facade
    {
        protected SubSystem1 _subsytem1;
        protected SubSystem2 _subsytem2;

        public Facade(SubSystem1 subsystem1, SubSystem2 subsystem2)
        {
            _subsytem1 = subsystem1;
            _subsytem2 = subsystem2;
        }

        public string Operation()
        {
            string result = "Facade initializes subsystems:\n";
            result += this._subsytem1.Operation1();
            result += this._subsytem2.Operation1();
            result += "Facade orders subsystems to perform the action:\n";
            result += this._subsytem1.OperationN();
            result += this._subsytem2.OperationZ();
            return result;
        }
    }
}