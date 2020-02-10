using System;
using Library;
namespace OpsummeringUge1
{
    class Program
    {
        static void Main(string[] args)
        {
            Library.Registry registry = new Registry();
            registry.AddNewUser(new User("Person1","Password1"));
            registry.AddNewUser(new User("Person2", "Password2"));
            registry.AddNewUser(new User("Person3", "Password3"));
            registry.AddNewUser(new User("Person4", "Password4"));
            registry.AddNewUser(new User("Person5", "Password5"));
            registry.AddNewUser(new User("Person6", "Password6"));
            registry.AddNewUser(new User("Person7", "Password7"));
            registry.AddNewUser(new User("Person8", "Password8"));
            registry.AddNewUser(new User("Person9", "Password9"));
            registry.AddNewUser(new User("Person10", "Password10"));


        }
    }
}
