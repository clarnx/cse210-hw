using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());


            if (number == 0)
            {
                break;
            }
            numbers.Add(number);


        }

        if (numbers.Count > 0)
        {
            // Core Requirements
            int sum = numbers.Sum();
            double average = numbers.Average();
            int max = numbers.Max();

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {max}");

            // Stretch Challenges
            int? smallestPositive = numbers.Where(n => n > 0).OrderBy(n => n).FirstOrDefault();
            List<int> sortedNumbers = numbers.OrderBy(n => n).ToList();

            if (smallestPositive.HasValue)
            {
                Console.WriteLine($"The smallest positive number is: {smallestPositive.Value}");
            }
            else
            {
                Console.WriteLine("There are no positive numbers in the list.");
            }

            Console.WriteLine("The sorted list is:");
            foreach (int num in sortedNumbers)
            {
                Console.WriteLine(num);
            }
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}