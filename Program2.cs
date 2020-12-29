using System;

namespace ConsoleApp39
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double num = 1234.3456;
            int a = (int)num;
            float b = (float)num;
            string c = num.ToString();


            Console.WriteLine("\n El double es {0}  \n El int es {1}  \n El float es {2}  \n El string es {3}", num, a, b, c);

        }
    }
}
