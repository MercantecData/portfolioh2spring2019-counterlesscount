using System;
using Library;
namespace OpsummeringUge1
{
    class Program
    {
        static void Main(string[] args)
        {
            Library.Registry registry = new Registry();
            registry.AddNewUser(new User() { login = "", password = "" });
        }
    }
}
