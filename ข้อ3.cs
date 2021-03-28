using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int digitbox1 = int.Parse(Console.ReadLine()); 
            int digitbox2 = int.Parse(Console.ReadLine()); 
            int digitbox3 = int.Parse(Console.ReadLine());
            int Nim = 0;

            while (digitbox1 > 0 || digitbox2 > 0 || digitbox3 > 0)
            {
                string digitbox = Console.ReadLine();
                int pick = int.Parse(Console.ReadLine());
                
                if (digitbox == "1")
                {
                    digitbox1 = digitbox1 - pick;
                }
                else if (digitbox == "2")
                {
                    digitbox2 = digitbox2 - pick;
                }
                else if (digitbox == "3")
                {
                    digitbox3 = digitbox3 - pick;
                }
                else
                {
                    Console.WriteLine();
                }
                Nim++;
            }
            if (Nim % 2 == 0)
            {
                Console.WriteLine("A");
            }
            else
            {
                Console.WriteLine("B");
            }
            Console.ReadLine();
        }
    }
}
