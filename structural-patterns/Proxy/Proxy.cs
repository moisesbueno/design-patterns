using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proxy
{
    public class Proxy : ISubject
    {
        private RealSubject _realSubject;

        public Proxy(RealSubject realSubject)
        {
            _realSubject = realSubject;
        }
        public void Request()
        {
            if (this.ChecAccess())
            {
                this._realSubject.Request();
                this.LogAccess();
            }
        }

        public bool ChecAccess()
        {
            Console.WriteLine("Proxy: Checking access prior to firigin a real request.");
            return true;
        }

        public void LogAccess()
        {
            Console.WriteLine("Proxy: Logging the time of request");
        }
    }
}