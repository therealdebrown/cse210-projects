using System;

namespace ScriptureMemorization
{
    class Program
    {
        static void Main(string[] args)
        {
            Scripture scripture = new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."
            );

            while (!scripture.IsFullyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.Display());
                Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
                string input = Console.ReadLine();

                if (input?.Trim().ToLower() == "quit") break;

                scripture.HideRandomWords(3);
            }

            Console.Clear();
            Console.WriteLine(scripture.Display());
            Console.WriteLine("\nAll words have been hidden. Goodbye!");
        }
    }
}