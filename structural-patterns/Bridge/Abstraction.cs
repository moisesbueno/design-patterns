using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bridge
{
    public class Abstraction
    {
        protected IImplementation _implementation;

        public Abstraction(IImplementation implementation){
            _implementation = implementation;
        }

        public virtual string Operation(){
            return "Abstract : Base operation with:\n" + _implementation.OperationImplementation();
        }
    }
}