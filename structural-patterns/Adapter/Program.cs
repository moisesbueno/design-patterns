// See https://aka.ms/new-console-template for more information

using Adapter;

Adaptee adaptee = new Adaptee();

ITarget target = new Adapter.Adapter(adaptee);

Console.WriteLine("Adaptee inteface is incompatible with the client");

Console.WriteLine("But with adapter client can call it's method.");

Console.WriteLine(target.GetRequest());