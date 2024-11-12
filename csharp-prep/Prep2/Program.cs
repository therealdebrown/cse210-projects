using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("What is your grade? ");
        string input = Console.ReadLine();

     
        if (int.TryParse(input, out int grade))
        {
           
            if (grade >= 90)
            {
                Console.WriteLine("Your grade is greater than or equal to 90.");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("Your grade is greater than or equal to 80.");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("Your grade is greater than or equal to 70.");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("Your grade is greater than or equal to 60.");
            }
            else
            {
                Console.WriteLine("Your grade is less than 60.");
            }

            
            if (grade >= 60)
            {
                Console.WriteLine("Congratulations for passing!");
            }
            else
            {
                Console.WriteLine("Sorry, you will do better next time.");
            }

           
            string letterGrade = "";
            string sign = "";

            
            if (grade >= 90)
            {
                letterGrade = "A";
            }
            else if (grade >= 80)
            {
                letterGrade = "B";
            }
            else if (grade >= 70)
            {
                letterGrade = "C";
            }
            else if (grade >= 60)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }

            if (grade == 100)
            {
                letterGrade = "A"; 
                sign = ""; 
            }
            else if (letterGrade == "F")
            {
                sign = ""; 
            }
            else
            {
                int lastDigit = grade % 10;

                if (lastDigit >= 7)
                {
                    sign = "+";
                }
                else if (lastDigit < 3)
                {
                    sign = "-";
                }
                else
                {
                    sign = ""; 
                }
            }
            Console.WriteLine($"Your letter grade is: {letterGrade}{sign}");
        }
        else
        {
            Console.WriteLine("Please enter a valid number.");
        }
    }
}