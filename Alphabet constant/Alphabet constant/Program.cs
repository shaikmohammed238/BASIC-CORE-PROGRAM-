using System;

namespace Alphabet_constant
{
    class Program
    {
        public static void Main(string[] args)
        {
           char Alphabet;
            Console.Write("Enter the Alphabet :");
            Alphabet = Convert.ToChar(Console.ReadLine().ToLower());
            switch (Alphabet)
            {
                case 'a':
                    Console.WriteLine("The Alphabet is Vowel");
                    break;
                case 'e':
                    Console.WriteLine("The Alphabet is Vowel");
                    break;
                case 'i':
                    Console.WriteLine("The Alphabet is Vowel");
                    break;
                case 'o':
                    Console.WriteLine("The Alphabet is Vowel");
                    break;
                case 'u':
                    Console.WriteLine("The Alphabet is Vowel");
                    break;
                default : Console.WriteLine("The Alphabet is Constant");
                    break;
            }
        }
    }
}
