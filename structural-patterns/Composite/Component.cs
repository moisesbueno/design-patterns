using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class Component
    {
        public abstract string Operation();

        public virtual void Add(Component component){
            throw new NotImplementedException();
        }

        public virtual void Remove(Component component){
            throw new NotImplementedException();
        }

        public virtual bool IsComposite(){
            return true;
        }
    }
}