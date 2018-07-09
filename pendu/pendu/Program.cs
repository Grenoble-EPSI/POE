using System;

namespace pendu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Console.ReadKey();
            
            string mot = "fox";
            string caractereTape =  "f";

            if (mot.Contains(caractereTape))
            {
                Console.WriteLine("ok");
            }
            else Console.WriteLine(" not ok");
            Console.ReadKey();
        }
    }
}
