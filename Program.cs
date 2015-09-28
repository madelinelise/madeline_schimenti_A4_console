using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using madeline_schimenti_A4_win_forms;

namespace madeline_schimenti_A4_console
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Enter the Base: ");
            int baseValue = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Exponent: ");
            int expValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine( baseValue + " raised to the power of " + expValue + " is " + Numbers.Power(baseValue, expValue));

            Console.WriteLine("\nPress Enter to see all the prime numbers up to 10000");
            Console.ReadLine();

            for (int count = 0; count <= 10000; count++)
            {
                bool isPrime = Numbers.Prime(count);
                if (isPrime)
                {
                    Console.WriteLine(count);
                }
            }

            Console.ReadLine();

        }
    }
}
