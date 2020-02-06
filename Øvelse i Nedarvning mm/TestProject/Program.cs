using System;
using Library_.dll_;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SmartTV desktop = new SmartTV();
            foreach (var item in desktop.NewComputer())
            {
                Console.WriteLine(item);
            }
            Laptop laptop = new Laptop();
            Console.WriteLine(laptop.newlaptop());
        }
    }
}
