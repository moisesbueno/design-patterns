using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public interface IAbstractProductB
    {
        string UseFunctionB();

        string AnotherUserfulFunctionB(IAbstractProductA collaborator);
    }
}