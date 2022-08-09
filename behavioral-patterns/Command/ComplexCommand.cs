using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Command
{
    public class ComplexCommand : ICommand
    {
        private Receiver _receiver;

        private string _a;
        private string _b;

        public ComplexCommand(Receiver receiver, string a, string b)
        {
            _receiver = receiver;
            _b = b;
            _a = a;
        }
        public void Execute()
        {
            Console.WriteLine("ComplexCommand: Complex stuff should be done by a receiver object.");
            _receiver.DoSomething(_a);
            _receiver.DoSomethingElse(_b);
        }
    }
}