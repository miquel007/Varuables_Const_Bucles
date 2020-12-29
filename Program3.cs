using System;
using System.Collections.Generic;

namespace ConsoleApp40
{
    class Program3
    {
        static void Main(string[] args)
        {
            List<int> array = new List<int>();

            for (int i = 1; i < 11; i++)
                array.Add(i);

            foreach (int num in array)
                Console.WriteLine(num);

            Console.WriteLine("\n");

            int auxiliar = 0;

            for (int j = 0; j < 5; j++ )
            {
                auxiliar = array[j];

                array[j] = array[9 - j];

                array[9 - j] = auxiliar;
            }

            foreach (int num in array)
                Console.WriteLine(num);
        }
    }
}
