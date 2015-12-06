using System;

namespace P4_2
{
    class Program
    {
        static void Main()
        {
            for (int i = 0; i < 5; i++)
            {
                BankCard c = new BankCard();
                Console.WriteLine(c.id);
            }
            Console.ReadLine();
        }

        public class BankCard
        {
            public readonly int id;
            private static int count = 0;

            public BankCard()
            {
                id = ++count;
            }
        }
    }
}
