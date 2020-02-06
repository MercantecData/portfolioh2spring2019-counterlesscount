using System;

namespace Øvelse_i_Nedarvning_mm
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

    public class Computer
    {
        public string[] NewComputer()
        {
            Stuff stuff = new Stuff();
            string[] stuffs = {
                stuff.newCase(),
                stuff.newCpu(),
                stuff.newMemory(),
                stuff.newMotherboard(),
                stuff.newPsu(),
                stuff.newRam(),
                stuff.newSoundcard(),
                stuff.NewGpu()
            };
            return stuffs;
        }
    }

    class Desktop : Computer
    {
        public void NewDesktop()
        {
            
        }
    }

    class Laptop : Computer
    {
        public string newlaptop()
        {
            Stuff stuff = new Stuff();
            string[] laptopstuff = {
                stuff.newBattery(),
                stuff.newMic(),
                stuff.newWifi(),
                stuff.newSpeakers()
            };
            string laptop = "";
            foreach (var item in NewComputer())
            {
                laptop += item;
            }
            foreach (var item in laptopstuff)
            {
                laptop += item;
            }
            return laptop;
        }
    }

    class CellPhone : Computer
    {

    }

    class SmartTV : Computer
    {

    }

    class GameConsole : Computer
    {

    }

}
