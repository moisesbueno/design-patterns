using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proxy
{
    public class Client
    {
        public void ClientCode(ISubject subject){
            subject.Request();
        }
    }
}