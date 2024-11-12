using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();
        Console.Write("Enter a list of numbers, type 0 when finished.");
    
        string playAgain;
        do
        {
            while (true)
            {
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());

                if (number == 0 )
                    break;

                numbers.Add(number);
            }
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            float average = ((float)sum) / numbers.Count;

            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {max}");

            Console.WriteLine("Are you interested in playing again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower();
        } 
        
        while (playAgain == "yes");
        Console.WriteLine("Thank You for using this program.");
    }
}