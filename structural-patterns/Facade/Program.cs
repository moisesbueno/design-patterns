using Facade;

var subsystem1 = new SubSystem1();
var subsystem2 = new SubSystem2();
var facade = new Facade.Facade(subsystem1, subsystem2);
Client.ClientCode(facade);