using System;

namespace Prime_Number_Checker
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Prime Number Checker-----\n");
            Console.Write("Please enter a number: ");
            string input = Console.ReadLine();
            int number;

            if (int.TryParse(input, out number))
            {
                if (number < 2)
                {
                    Console.WriteLine("Not Prime");
                }
                else if (number == 2)
                {
                    Console.WriteLine("Prime");
                }
                else if (number % 2 == 0)
                {
                    Console.WriteLine("Not Prime");
                }
                else
                {
                    bool isPrime = true;
                    for (int i = 3; i <= Math.Sqrt(number); i += 2)
                    {
                        if (number % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime)
                        Console.WriteLine("Prime");
                    else
                        Console.WriteLine("Not Prime");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number!");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
