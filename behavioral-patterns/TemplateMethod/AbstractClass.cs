using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class AbstractClass
    {
        public void TemplateMethod()
        {
           BaseOperation1();
           RequiredOperations1();
           BaseOperation2();
           Hook1();
           RequiredOperations2();
           BaseOperation3();
           Hook2();
        }

        protected void BaseOperation1()
        {
             Console.WriteLine("AbstractClass says : I am doing the bulk of the the work");
        }

        protected void BaseOperation2()
        {
            Console.WriteLine("AbstractClass says: But I let subclasses override some operations");
        }

        protected void BaseOperation3()
        {
            Console.WriteLine("AbstractClass says: But I am doing the bulk of the work anyway");
        }

        protected abstract void RequiredOperations1();
        protected abstract void RequiredOperations2();

        protected virtual void Hook1() { }
        protected virtual void Hook2() { }
    }
}