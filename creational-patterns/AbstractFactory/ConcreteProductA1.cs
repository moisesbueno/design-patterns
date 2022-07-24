using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ConcreteProductA1 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "The result of the product a1";
        }
    }
}