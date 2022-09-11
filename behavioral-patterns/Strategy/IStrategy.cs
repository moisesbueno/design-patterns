using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Strategy
{
    public interface IStrategy
    {
        object DoAlgorithm(object data);
    }
}