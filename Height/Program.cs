using System;

namespace Height
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Height of the person");
            int Height = Convert.ToInt32(Console.ReadLine());

            if (Height< 150)
            { Console.WriteLine("The Person is Dwarf"); }

         else if (Height < 180 && Height > 150)
            { Console.WriteLine("The Person is Normal"); }

            else

            { Console.WriteLine("The person is tall"); }
            {Console.Readline();
            }

        }
    }
}
