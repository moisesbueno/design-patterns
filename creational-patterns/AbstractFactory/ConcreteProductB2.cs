using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ConcreteProductB2 : IAbstractProductB
    {
        public string AnotherUserfulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();

            return $"The result of the b2 colllaborating with the ({result})";
        }

        public string UseFunctionB()
        {
            return "The result of the product B2";
        }
    }
}