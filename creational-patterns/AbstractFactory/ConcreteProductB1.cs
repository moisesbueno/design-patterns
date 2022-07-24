using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ConcreteProductB1 : IAbstractProductB
    {
        public string UseFunctionB()
        {
            return "the result of the product B1";
        }

        public string AnotherUserfulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();

            return $"The result of the B1 collaborating with the ({result})";
        }
    }
}