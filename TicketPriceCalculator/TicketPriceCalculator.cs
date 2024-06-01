using System;

namespace TicketPriceCalculator
{
    class TicketPriceCalculator
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            if (age <= 12 || age >= 65)
            {
                Console.WriteLine("Your ticket price is: GHC7");
            }
            else
            {
                Console.WriteLine("Your ticket price is: GHC10");
            }
        }
    }
}
