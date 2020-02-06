using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;

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
        public delegate double delDouble(double a);
        public delegate double advancedmath(object a);
        

        static void Main(string[] args)
        {
            
            //A)
            delV dV = new delV(MathFunc.DelegateVoid);
            dV.Invoke();
            //B)
            delF dF = new delF(MathFunc.DelegateFloat);
            dF.Invoke();
            //C)
            delP dP = new delP(MathFunc.DelegateParam);
            dP.Invoke(1, 2, 3);


            //Math
            //Int
            delInt dIntAdd = MathFunc.DelegateAdd;
            delInt dIntSub = MathFunc.DelegateSub;
            delInt dIntMulti = MathFunc.DelegateMulti;
            delInt dIntDiv = MathFunc.DelegateDiv;
            delInt dIntSec = MathFunc.DelegateSecond;
            delIntS dIntSecS = MathFunc.DelegateSecond;
            //Float
            delFloat dFloatAdd = MathFunc.DelegateAdd;
            delFloat dFloatSub = MathFunc.DelegateSub;
            delFloat dFloatMulti = MathFunc.DelegateMulti;
            delFloat dFloatDiv = MathFunc.DelegateDiv;
            delFloat dFloatSec = MathFunc.DelegateSecond;
            delFloatS dFloatSecS = MathFunc.DelegateSecond;
            //String
            delString dStringAdd = MathFunc.DelegateAdd;
            delString dStringSub = MathFunc.DelegateSub;
            delString dStringMulti = MathFunc.DelegateMulti;
            delString dStringDiv = MathFunc.DelegateDiv;
            delString dStringSec = MathFunc.DelegateSecond;
            delStringS dStringSecS = MathFunc.DelegateSecond;


            //A little program
            Error ERROR = new Error();

            Console.WriteLine("A little program...");
            Console.WriteLine("");

            Console.WriteLine("Type your calculation, and then press Enter for result");
            Console.WriteLine("c clears the screen:");
            Console.WriteLine("h For a list of commands:");
            Console.WriteLine("");
            bool on = true;
            while (on)
            { 
                try
                {
                    string x = Console.ReadLine();

                    //Just for the practice
                    if ((x.Contains('+') || x.Contains('-') || x.Contains('/') || x.Contains('*') || x.Contains('^') || x.Contains('_')) && (x.Contains('+') || x.Contains('-') || x.Contains('/') || x.Contains('*') || x.Contains('^') || x.Contains('_')))
                    {
                        advancedmath advancedmath = (y) => Convert.ToDouble(y);
                        if (x.Contains('|'))
                        {
                            string results = "";
                            string[] moremath = x.Trim().Split('|');
                            foreach (var item in moremath)
                            {
                                string calculation = Regex.Replace(item, @"[^0-9.+*^/_-]+", "");
                                if (calculation.StartsWith('+') || calculation.StartsWith('-') || calculation.StartsWith('/') || calculation.StartsWith('*') || calculation.StartsWith('^') || calculation.StartsWith('_'))
                                {
                                    string subcalculation = Regex.Replace(calculation, @"[^0-9.]+", "");
                                    string subresult = Convert.ToString(advancedmath.Invoke(new DataTable().Compute(subcalculation, null)));
                                    string property = Regex.Replace(calculation, @"[^+*^/_-]+", "");
                                    property += subresult;
                                    results += property;
                                }
                                else
                                {
                                string result = Convert.ToString(advancedmath.Invoke(new DataTable().Compute(calculation, null)));
                                results += result;
                                }
                            }
                            Console.WriteLine(results);
                            Console.WriteLine(advancedmath.Invoke(new DataTable().Compute(results, null)));
                        }
                        else
                        {
                        string numberandsymbols = Regex.Replace(x, @"[^0-9.+*^/_-]+", "");
                        Console.WriteLine(advancedmath.Invoke(new DataTable().Compute(numberandsymbols, null)));
                        }

                    }


                    //add
                    else if (x.Contains('+'))
                    {
                        
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
                            float answer = dFloatMulti(Convert.ToSingle(first), Convert.ToSingle(second));
                            Console.WriteLine(answer);
                        }
                    }


                    //find Second (x*x)
                    else if (x.Contains('^') && x.Length <= 2)
                    {
                        
                        string digit = new String(x.Where(Char.IsDigit).ToArray());
                                             
                        delIntS delIntS = (a) => a * a;
                        Console.WriteLine(delIntS.Invoke(Convert.ToInt32(digit)));
                        
                    }

                    //Lambda Expressions Added:

                    //find ^ (x^)
                    else if (x.Contains('^') && x.Length > 2)
                    {
                        
                        string[] splitted = x.Split('^');
                        
                        delInt del = (a, b) => Convert.ToInt32(Math.Pow(a, b));
                        Console.WriteLine(del.Invoke(Convert.ToInt32(splitted[0]), Convert.ToInt32(splitted[1])));
                        
                    }

                    //Sqare
                    else if (x.Contains('_') && x.Length < 3)
                    {
                        
                        string digit = new String(x.Where(Char.IsDigit).ToArray());
                        try
                        {
                            delDouble del = (a) => (Math.Sqrt(a));
                            Console.WriteLine(del.Invoke(Convert.ToDouble(digit)));
                        }
                        catch (Exception)
                        {
                            string error = ERROR.ErrorHandling;
                            Console.WriteLine(error);

                        }
                    }

                    //Commandlist
                    else if (x.Contains('h') && x.Length == 1)
                    {
                        string[] commandlist = { "+ - Add 2 numbers", "- - Subtract 2 numbers", "/ - Divide 2 numbers", "* - Multiply 2 numbers", "^ - Lift a number in 2, or x", "| - parenthesis", "c - Clear screen", "h - Show this list" };
                        for (int i = 0; i < commandlist.Length - 1; i++)
                        {
                            Console.WriteLine(commandlist[i]);
                        }
                    }
                        
                    //clear screen
                    else if (x.Contains('c') && x.Length == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("A little program...");
                        Console.WriteLine("");

                        Console.WriteLine("Type your calculation, and then press Enter for result");
                        Console.WriteLine("c clears the screen:");
                        Console.WriteLine("h For a list of commands:");
                        Console.WriteLine("");
                    }

                    else
                    {
                        string error = ERROR.ErrorHandling;
                        Console.WriteLine(error);
                        Console.WriteLine("");
                    }
                }
                catch (Exception)
                {
                    string error = ERROR.ErrorHandling;
                    Console.WriteLine(error);
                    Console.WriteLine("");

                }

            }
        }

    }
    

    class MathFunc
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

    class Error
    {

        public string ErrorHandling
        {
            get
            {
                string[] a = { "An Error have occurred!", "This program do not like math mistakes!",
            "Please stop doing that!", "You just found an easter egg! -Just kidding...",
            "The same mistake again?", "You should have learned from last time...",
            "Just stop doing math....", "You dissapoint everyone!",
            "Are you still here?", "Its not the program, its you!"
            };

                Random random = new Random();
                return a[random.Next(0, a.Length - 1)];

            }
        }
    }
}
