using AbstractFactory;

static void ClientMethod(IAbstractFactory factory)
{
    var productA = factory.CreateProductA();
    var productB = factory.CreateProductB();

    Console.WriteLine(productB.UseFunctionB());
    Console.WriteLine(productB.AnotherUserfulFunctionB(productA));
}

Console.WriteLine("Client: Tesring cliente code with first factory type ... ");
ClientMethod(new ConcreteFactory1());

Console.WriteLine("Client: Testing the same client code with the second factory type...");
ClientMethod(new ConcreteFactory2());

