using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Command
{
    public class SimpleCommand : ICommand
    {
        private string _payload = string.Empty;
        public SimpleCommand(string payload)
        {
            _payload = payload;
        }
        public void Execute()
        {
            Console.WriteLine($"SimpleCommand: See, I can do simples things like priting ({_payload})");
        }
    }
}