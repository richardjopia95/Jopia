using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask for user's name
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        // Ask for user's age
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        // Display output
        Console.WriteLine("\nHello, " + name + "!");
        Console.WriteLine("You are " + age + " years old.");

        // Extra message
        if (age >= 18)
        {
            Console.WriteLine("You are an adult.");
        }
        else
        {
            Console.WriteLine("You are still a minor.");
        }

        // Pause before closing
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
