using System;
using System.Linq;

namespace Overloading
{
    class Program
    {
        public delegate void delV();
        public delegate float delF();
        public delegate void delP(int a, int b, int c);


        //Delegates for Math
        public delegate int delInt(int a, int b);
        public delegate float delFloat(float a, float b);
        public delegate int delString(string a, string b);
        public delegate int delIntS(int a);
        public delegate float delFloatS(float a);
        public delegate int delStringS(string a);



        static void Main(string[] args)
        {
            
            //A)
            delV dV = new delV(Math.DelegateVoid);
            dV.Invoke();
            //B)
            delF dF = new delF(Math.DelegateFloat);
            dF.Invoke();
            //C)
            delP dP = new delP(Math.DelegateParam);
            dP.Invoke(1, 2, 3);


            //Math
            //Int
            delInt dIntAdd = new delInt(Math.DelegateAdd);
            delInt dIntSub = new delInt(Math.DelegateSub);
            delInt dIntMulti = new delInt(Math.DelegateMulti);
            delInt dIntDiv = new delInt(Math.DelegateDiv);
            delInt dIntSec = new delInt(Math.DelegateSecond);
            delIntS dIntSecS = new delIntS(Math.DelegateSecond);
            //Float
            delFloat dFloatAdd = new delFloat(Math.DelegateAdd);
            delFloat dFloatSub = new delFloat(Math.DelegateSub);
            delFloat dFloatMulti = new delFloat(Math.DelegateMulti);
            delFloat dFloatDiv = new delFloat(Math.DelegateDiv);
            delFloat dFloatSec = new delFloat(Math.DelegateSecond);
            delFloatS dFloatSecS = new delFloatS(Math.DelegateSecond);
            //String
            delString dStringAdd = new delString(Math.DelegateAdd);
            delString dStringSub = new delString(Math.DelegateSub);
            delString dStringMulti = new delString(Math.DelegateMulti);
            delString dStringDiv = new delString(Math.DelegateDiv);
            delString dStringSec = new delString(Math.DelegateSecond);
            delStringS dStringSecS = new delStringS(Math.DelegateSecond);


            //A little program
            Console.WriteLine("A little program...");
            Console.WriteLine("");

            Console.WriteLine("Type your calculation, and then press Enter for result");
            bool on = true;
            while (on)
            {
                string x = Console.ReadLine();

                //add
                if (x.Contains('+'))
                {
                    x.Trim();
                    string[] y = x.Split('+');
                    string first = y[0];
                    string second = y[1];
                    try
                    {
                        
                        
                        int answer = dIntAdd.Invoke(Convert.ToInt32(first), Convert.ToInt32(second));
                        Console.WriteLine(answer);
                    }
                    catch (Exception)
                    {
                        try
                        {
                            float answer = dFloatAdd(Convert.ToSingle(first), Convert.ToSingle(second));
                            Console.WriteLine(answer);
                        }
                        catch (Exception)
                        {
                            int answer = dStringAdd.Invoke(first, second);
                            Console.WriteLine(answer);
                        }
                    }
                }

                //subtract
                else if (x.Contains('-'))
                {
                    x.Trim();
                    string[] y = x.Split('-');
                    string first = y[0];
                    string second = y[1];
                    try
                    {


                        int answer = dIntSub.Invoke(Convert.ToInt32(first), Convert.ToInt32(second));
                        Console.WriteLine(answer);
                    }
                    catch (Exception)
                    {
                        try
                        {
                            float answer = dFloatSub(Convert.ToSingle(first), Convert.ToSingle(second));
                            Console.WriteLine(answer);
                        }
                        catch (Exception)
                        {
                            int answer = dStringSub.Invoke(first, second);
                            Console.WriteLine(answer);
                        }
                    }
                }

                //divide
                else if (x.Contains('/'))
                {
                    x.Trim();
                    string[] y = x.Split('/');
                    string first = y[0];
                    string second = y[1];
                    try
                    {


                        int answer = dIntDiv.Invoke(Convert.ToInt32(first), Convert.ToInt32(second));
                        Console.WriteLine(answer);
                    }
                    catch (Exception)
                    {
                        try
                        {
                            float answer = dFloatDiv(Convert.ToSingle(first), Convert.ToSingle(second));
                            Console.WriteLine(answer);
                        }
                        catch (Exception)
                        {
                            int answer = dStringDiv.Invoke(first, second);
                            Console.WriteLine(answer);
                        }
                    }
                }

                //multiply
                else if (x.Contains('*'))
                {
                    x.Trim();
                    string[] y = x.Split('*');
                    string first = y[0];
                    string second = y[1];
                    try
                    {


                        int answer = dIntMulti.Invoke(Convert.ToInt32(first), Convert.ToInt32(second));
                        Console.WriteLine(answer);
                    }
                    catch (Exception)
                    {
                        try
                        {
                            float answer = dFloatMulti(Convert.ToSingle(first), Convert.ToSingle(second));
                            Console.WriteLine(answer);
                        }
                        catch (Exception)
                        {
                            int answer = dStringMulti.Invoke(first, second);
                            Console.WriteLine(answer);
                        }
                    }
                }


                //find Second
                else if (x.Contains('^'))
                {
                    x.Trim();
                    string[] y = x.Split('^');
                    string first = y[0];
                    string second = y[1];
                    try
                    {


                        int answer = dIntSec.Invoke(Convert.ToInt32(first), Convert.ToInt32(second));
                        Console.WriteLine(answer);
                    }
                    catch (Exception)
                    {
                        try
                        {
                            float answer = dFloatSec(Convert.ToSingle(first), Convert.ToSingle(second));
                            Console.WriteLine(answer);
                        }
                        catch (Exception)
                        {
                            int answer = dStringSec.Invoke(first, second);
                            Console.WriteLine(answer);
                        }
                    }
                }









            }
        }
    }
    

    class Math
    {        
        //A)
        public static void DelegateVoid()
        {
        return ;
        }

        //B)
        public static float DelegateFloat()
        {
            return 2;
        }

        //C)
        public static void DelegateParam(int a, int b, int c)
        {
        }


        //Methods

        //Add
        public static int DelegateAdd(int a, int b)
        {
            return a + b;
        }

        public static float DelegateAdd(float a, float b)
        {
            return a + b;
        }

        public static int DelegateAdd(string a, string b)
        {
            string onlynumbersA = new String(a.Where(Char.IsDigit).ToArray());
            string onlynumbersB = new String(b.Where(Char.IsDigit).ToArray());

            return Convert.ToInt32(onlynumbersA) + Convert.ToInt32(onlynumbersB);
        }

        //Subtract
        public static int DelegateSub(int a, int b)
        {
            return a - b;
        }

        public static float DelegateSub(float a, float b)
        {
            return a - b;
        }

        public static int DelegateSub(string a, string b)
        {
            string onlynumbersA = new String(a.Where(Char.IsDigit).ToArray());
            string onlynumbersB = new String(b.Where(Char.IsDigit).ToArray());

            return Convert.ToInt32(onlynumbersA) - Convert.ToInt32(onlynumbersB);
        }

        //Divide
        public static int DelegateDiv(int a, int b)
        {
            return a / b;
        }

        public static float DelegateDiv(float a, float b)
        {
            return a / b;
        }

        public static int DelegateDiv(string a, string b)
        {
            string onlynumbersA = new String(a.Where(Char.IsDigit).ToArray());
            string onlynumbersB = new String(b.Where(Char.IsDigit).ToArray());

            return Convert.ToInt32(onlynumbersA) / Convert.ToInt32(onlynumbersB);
        }

        //Multiply
        public static int DelegateMulti(int a, int b)
        {
            return a * b;
        }

        public static float DelegateMulti(float a, float b)
        {
            return a * b;
        }

        public static int DelegateMulti(string a, string b)
        {
            string onlynumbersA = new String(a.Where(Char.IsDigit).ToArray());
            string onlynumbersB = new String(b.Where(Char.IsDigit).ToArray());

            return Convert.ToInt32(onlynumbersA) * Convert.ToInt32(onlynumbersB);
        }

        //^2 * something
        public static int DelegateSecond(int a, int b)
        {
            return (a*a) * b;
        }

        public static float DelegateSecond(float a, float b)
        {
            return (a*a) * b ;
        }

        public static int DelegateSecond(string a, string b)
        {
            string onlynumbersA = new String(a.Where(Char.IsDigit).ToArray());
            string onlynumbersB = new String(b.Where(Char.IsDigit).ToArray());

            return (Convert.ToInt32(onlynumbersA)* Convert.ToInt32(onlynumbersA)) * Convert.ToInt32(onlynumbersB);
        }

        //find ^2
        public static int DelegateSecond(int a)
        {
            return (a * a);
        }

        public static float DelegateSecond(float a)
        {
            return (a * a);
        }

        public static int DelegateSecond(string a)
        {
            string onlynumbersA = new String(a.Where(Char.IsDigit).ToArray());

            return (Convert.ToInt32(onlynumbersA) * Convert.ToInt32(onlynumbersA));
        }
    }
}
