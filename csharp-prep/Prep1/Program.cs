using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    { 
        Console.WriteLine("What is your grade? ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int grade))
        { 
            if (grade >= 90)
            {
                Console.WriteLine("Your grade is greater than or equal to 90?");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("Your grade is greater than or equal to 80");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("Your grade is greater than or equal to 70");
            }
            else if ( grade >= 60) 
            {
                Console.WriteLine("Your grade is greater than or equal to 60");
            }
            else if (grade < 60)
            {
                Console.WriteLine("Your grade is less than 60");
            }

            if (grade >= 60)
            {
                Console.WriteLine("Congratulations for passing");
            }
            else
            {

                Console.WriteLine("Sorry you will do better next time");
            }
        }
        else
        {
            Console.WriteLine("Enter a valid number.");
        }
    }

}