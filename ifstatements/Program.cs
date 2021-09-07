using System;

namespace ifstatements
{
    class Program
    {
        static void Main(string[] args)
        {

            //progrmm küsib kasutaja vanust
            //kui kasutaja on vanem, kui 18, siis on konsoolis kuvatakse "oled piisavalt vana"
            //kui kasutaja on noorem, kui 18, siis konsoolis "oled liiga noor"
            //kui kasutaja on 18, siis konsoolis kuvatakse "oledki 18" 

            Console.WriteLine("kui vana sa oled?");

            int age = Int32.Parse(Console.ReadLine());

            if (age > 18)

            {
                Console.WriteLine("Oled piisaalt vanks");

            }
            else if (age < 18)
            {
                Console.WriteLine("oled liiga noor");
            } 
            else
            {
                Console.WriteLine("oledki 18.")

            }

            Console.WriteLine("Ilusat päeva!");




    }
}
