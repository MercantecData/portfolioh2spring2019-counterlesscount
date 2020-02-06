using System;

namespace Library_.dll_
{
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

    public class Desktop : Computer
    {
        public void NewDesktop()
        {

        }
    }

    public class Laptop : Computer
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

    public class CellPhone : Computer
    {

    }

    public class SmartTV : Computer
    {

    }

    public class GameConsole : Computer
    {

    }

    public class Stuff
    {
        public string newCase()
        {
            return "NewCase";
        }

        public string newPsu()
        {
            return "Clean Power to the system - aint gonna work without!";
        }

        public string NewGpu()
        {
            return "Vizualise this stuff";
        }

        public string newRam()
        {
            return "Ram = Power^2";
        }

        public string newMemory()
        {
            return "Hard to store any data without it!";
        }

        public string newMotherboard()
        {
            return "This is a peice of art";
        }

        public string newSoundcard()
        {
            return "Like you ever r going to need this anyway?";
        }

        public string newCpu()
        {
            return "Virtual Brain? Biip Boop";
        }



        public string newBattery()
        {
            return "ITS OVER 9000!!!!";
        }

        public string newWifi()
        {
            return "A true hacker needs his Wifi";
        }

        public string newSpeakers()
        {
            return "Get Dat Bass";
        }

        public string newMic()
        {
            return "Start the speaking";
        }

        public string newSim(int a)
        {
            return "New Simcard with:" + a + "Number!";
        }

        public string newGps(string a)
        {
            return "You just got your new: " + a;
        }
    }



}
