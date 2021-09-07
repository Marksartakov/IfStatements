using System;

namespace PositiveNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun sisesta Numbrit")
            int positiivne = Convert.ToInt32(Console.ReadLine());
            int Negatiivne = -+positiivne;

            if (positiivne > Negatiivne)

            {
                Console.WriteLine("number on positiivne"); 

            }       
            else if (positiivne < Negatiivne)

            {
              Console.WriteLine("Number on negatiivne);

            }
            else
            {
                Console.WriteLine("null");

            }

        }
    }
}
