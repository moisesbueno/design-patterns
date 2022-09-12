using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Visitor
{
    public interface IComponent
    {
        void Accept(IVisitor visitor);
    }
}