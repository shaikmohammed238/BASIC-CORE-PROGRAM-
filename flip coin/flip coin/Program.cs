using System;

namespace flip_coin
{
    class Program
    {
        public static void Main(string[] args)
        {
            int head = 0;
            int tail = 0;

            Random random = new Random();
            Console.WriteLine("HOW Many Number Time You Want Toss  ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < userInput; i++)
            {
                int coin = random.Next(0, 2);
                if (coin == 0)
                {
                    head++;
                }
                else
                {
                    tail++;
                }
            }

            double Head = (head * 100) / userInput;
            double Tail = (tail * 100) / userInput;

            Console.WriteLine("Head % is " + Head);
            Console.WriteLine("Tail % is " + Tail);
        }

    }
}
