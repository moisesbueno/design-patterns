
using Iterator;

var collection = new WordsCollection();

collection.AddItem("First");
collection.AddItem("Second");
collection.AddItem("Third");

Console.WriteLine("Straight traversal:");

foreach (var item in collection)
{
    Console.WriteLine(item);
}

Console.WriteLine("\nReverse traversal:");

collection.ReverseDirection();

foreach (var item in collection)
{
    Console.WriteLine(item);
}

