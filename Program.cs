using System;
using System.Linq;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateArray();
            removeDuplicate();
        }

        private static void CalculateArray()
        {
            int[] numbersToCalculate = { 7, 4, 8, 2, 6, 9 };

            Console.WriteLine("The numbers to be calculated:");
            foreach (int number in numbersToCalculate) // displays the numbers before calculation
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("----------------------"); // the line is seperating the numbers

            Console.WriteLine("The calculated minimum, maximum, sum and average of the numbers respectively:");
            Console.WriteLine(numbersToCalculate.Min()); // shows the smallest number
            Console.WriteLine(numbersToCalculate.Max()); // shows the biggest number
            Console.WriteLine(numbersToCalculate.Sum()); // shows the total amount from all of the numbers
            Console.WriteLine(numbersToCalculate.Average()); // shows the average number
            Console.WriteLine("----------------------"); // end of the function
        }

        private static void removeDuplicate()
        {
            int[] numbersToCheck = { 3, 5, 8, 1, 6, 8 };

            Console.WriteLine("The numbers with the duplicate:");
            foreach (int number in numbersToCheck) // displays the numbers before the removal of the duplicate
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("----------------------"); // the line is seperating the numbers

            Console.WriteLine("The numbers without the duplicate:");
            int[] numbersAfterCheck = numbersToCheck.Distinct().ToArray(); // removes the duplicate from the numbers
            foreach (int number in numbersAfterCheck) // displays the numbers after the removal of the duplicate
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("----------------------"); // end of the function
        }
    }
}
