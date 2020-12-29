using System;
using System.Collections.Generic;

namespace ConsoleApp38
{

    static class Constants
    {
        public const int trespass = 1948;
        public const int temps = 4;

    }

    class Program
    {
        

        static void Main(string[] args)
        {
            List<int> arrayedat = new List<int>();
            List<string> arraynom = new List<string>();

            arraynom = preguntarnom();
            
            try
            {
                arrayedat = preguntaredat();
            }
                
             catch (System.ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            List<string> array = mostrar(arraynom, arrayedat);

            bool op = calcul(arrayedat);
 
            mostrar2(array,op);


        }

        public static void mostrar2(List<string> array,bool any)
        {
            Console.WriteLine("");

            
            Console.WriteLine("El meu nom es "+ array[0]);
            Console.WriteLine("Vaig neixer el" + array[1]);

            if  (any)
                    Console.WriteLine("El teu any ha estat de trespass");
                else
                    Console.WriteLine("El teu any no ha estat de trespass");
        }

        public static bool calcul (List<int> array)
        {
            int op = 0, i = 0;
            bool anytrespass = false;

            for (i = Constants.trespass; i < array[2]+1; i = i + Constants.temps)
            {
                Console.WriteLine("El any {0} ha estat any de trespas",i);
                op++;
                if (i == array[2])
                    anytrespass = true;
            }

            Console.WriteLine("Han passat {0} anys de traspas", op);

            return anytrespass;

        }

        public static List<string> mostrar(List<string> array1, List<int> array2)
        {
            string nom = "";
            string date = "X";

            foreach (string cosa in array1)
                nom = nom + " " + cosa;

            Console.WriteLine(nom);

            foreach (int cosa in array2)
                date = date + "/" + cosa;

            date = date.Replace("X/", " ");
            Console.WriteLine(date);

            List<string> array = new List<string>();

            array.Add(nom);
            array.Add(date);

            return array;
        }

        public static List<int> preguntaredat()
        {
                Console.WriteLine("Dia que fas anys");
                string Njoke = Console.ReadLine();
                int dia = Convert.ToInt32(Njoke);

                Console.WriteLine("Mes que fas anys");
                Njoke = Console.ReadLine();
                int mes = Convert.ToInt32(Njoke);

                Console.WriteLine("any que vas neixer");
                Njoke = Console.ReadLine();
                int any = Convert.ToInt32(Njoke);


                if ((0 > dia  && dia  > 31 ) || (0 > mes && mes > 12))
                {
                    throw new System.ArgumentOutOfRangeException(" variable mal ficada ");
                }

            List<int> array = new List<int>();


            array.Add(dia);
            array.Add(mes);
            array.Add(any);

            return array;
        }

        public static List<String> preguntarnom()
        {

            Console.WriteLine("Fica el teu nom!");
            string nom = Console.ReadLine();
           

            Console.WriteLine("EL teu primer cognom");
            string cognom1 = Console.ReadLine();
           

            Console.WriteLine("El teu segon cognom");
            string cognom2 = Console.ReadLine();

            List<String> array = new List<String>();

            
            array.Add(cognom1);
            array.Add(cognom2);
            array.Add(nom);

            return array;
        }
    }
}
