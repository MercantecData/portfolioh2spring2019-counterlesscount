using System;

namespace Lambda_Expressions
{
    public delegate int Funcdel1(int a);
    public delegate float Funcdel2(float a, float b, float c);
    public delegate string Funcdel3();
    class Program
    {
        static void Main(string[] args)
        {
            //A)
            Funcdel1 funcdel1 = (a) => a * a;
            Console.WriteLine(funcdel1.Invoke(2));

            //B)
            Funcdel2 funcdel2 = (a, b, c) => a + b + c;
            Console.WriteLine(funcdel2.Invoke(1,2,3));

            //C)
            Funcdel3 funcdel3 = () => "Hello World";
            Console.WriteLine(funcdel3.Invoke());
        }
    }
}
