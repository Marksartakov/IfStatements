using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mis on su lemmik värv");
            string Usercolor = Console.ReadLine();

            if(Usercolor == "punane")

            {
                Console.WriteLine("oled romantiline");  
            }
            else if (Usercolor == "sinine")
            {
                Console.WriteLine("oled töökas");
            }
            else if (Usercolor == "roheline")
            {
                Console.WriteLine("oled looduse sõber");
            }
            else
            {
                Console.WriteLine("oled ükssarvik"); 
            }
        }
    }
}
