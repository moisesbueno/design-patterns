﻿using TemplateMethod;

Console.WriteLine("Same client code can work with differente subclasses:");
Client.ClientCode(new ConcreteClass1());

Console.WriteLine();

Console.WriteLine("Same client code can work with differente subclasses:");
Client.ClientCode(new ConcreteClass2());


