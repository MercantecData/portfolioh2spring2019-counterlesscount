using System;
using System.Linq;

namespace Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class Math
    {
        //Add
        public int FuncAdd(int a, int b)
        {
            return a + b;
        }

        public float FuncAdd(float a, float b)
        {
            return a + b;
        }

        public int FuncAdd(string a, string b)
        {
            string onlynumbersA = new String(a.Where(Char.IsDigit).ToArray());
            string onlynumbersB = new String(b.Where(Char.IsDigit).ToArray());

            return Convert.ToInt32(onlynumbersA) + Convert.ToInt32(onlynumbersB);
        }

        //Subtract
        public int FuncSub(int a, int b)
        {
            return a - b;
        }

        public float FuncSub(float a, float b)
        {
            return a - b;
        }

        public int FuncSub(string a, string b)
        {
            string onlynumbersA = new String(a.Where(Char.IsDigit).ToArray());
            string onlynumbersB = new String(b.Where(Char.IsDigit).ToArray());

            return Convert.ToInt32(onlynumbersA) - Convert.ToInt32(onlynumbersB);
        }

        //Divide
        public int FuncDiv(int a, int b)
        {
            return a / b;
        }

        public float FuncDiv(float a, float b)
        {
            return a / b;
        }

        public int FuncDiv(string a, string b)
        {
            string onlynumbersA = new String(a.Where(Char.IsDigit).ToArray());
            string onlynumbersB = new String(b.Where(Char.IsDigit).ToArray());

            return Convert.ToInt32(onlynumbersA) / Convert.ToInt32(onlynumbersB);
        }

        //Multiply
        public int FuncMulti(int a, int b)
        {
            return a * b;
        }

        public float FuncMulti(float a, float b)
        {
            return a * b;
        }

        public int FuncMulti(string a, string b)
        {
            string onlynumbersA = new String(a.Where(Char.IsDigit).ToArray());
            string onlynumbersB = new String(b.Where(Char.IsDigit).ToArray());

            return Convert.ToInt32(onlynumbersA) * Convert.ToInt32(onlynumbersB);
        }

        //^2
        public int FuncSecond(int a, int b)
        {
            return (a*a) + (b*b);
        }

        public float FuncSecond(float a, float b)
        {
            return (a*a) + (b*b);
        }

        public int FuncSecond(string a, string b)
        {
            string onlynumbersA = new String(a.Where(Char.IsDigit).ToArray());
            string onlynumbersB = new String(b.Where(Char.IsDigit).ToArray());

            return (Convert.ToInt32(onlynumbersA)* Convert.ToInt32(onlynumbersA)) + (Convert.ToInt32(onlynumbersB) * Convert.ToInt32(onlynumbersB));
        }
    }
}
