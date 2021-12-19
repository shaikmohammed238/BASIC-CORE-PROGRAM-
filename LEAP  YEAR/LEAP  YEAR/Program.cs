using System;

namespace LEAP__YEAR
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter Any year: ");
            int Userinput = Convert.ToInt16(Console.ReadLine());
            if
                ((Userinput % 400 == 0 || (Userinput % 4 == 0 && Userinput % 100 != 0)))
                Console.WriteLine("Year is Leap Year");
            else
                Console.WriteLine("Year is not Leap Year");
        }
    }
}
