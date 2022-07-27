Singleton.Models.Singleton s1 = Singleton.Models.Singleton.GetInstance();
Singleton.Models.Singleton s2 = Singleton.Models.Singleton.GetInstance();

if (s1 == s2)
{
    Console.WriteLine("Singleton works, both variables contain the same instance.");
}
else
{
    Console.WriteLine("Singleton failed, variables contain different instances.");
}