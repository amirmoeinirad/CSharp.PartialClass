
// Amir Moeini Rad
// September 2025

// Help from Grok

// Main Concept: Partial Classes in C#.NET

// Purpose: Partial classes are useful for splitting large classes,
// separating generated code (e.g., by Visual Studio or Entity Framework) from custom code,
// or enabling team collaboration on the same class.

// Requirements: All parts of a partial class must have the partial keyword and be in the same namespace and assembly.


namespace PartialClass
{
    // File 1: Part of the Person class
    // In a real project, this would be in Person.Part1.cs
    internal partial class Person
    {
        public string? FirstName { get; set; }

        public void PrintFirstName()
        {
            Console.WriteLine($"First Name: {FirstName}");
        }
    }


    // File 2: Another part of the Person class
    // In a real project, this would be in Person.Part2.cs
    internal partial class Person
    {
        public string? LastName { get; set; }

        public void PrintLastName()
        {
            Console.WriteLine($"Last Name: {LastName}");
        }
    }

    
    ///////////////////////////////////////////////////
    

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Partial Classes in C#.NET.");
            Console.WriteLine("--------------------------\n");


            // Create an instance of the Person class
            Person person = new()
            {
                FirstName = "John",
                LastName = "Doe"
            };

            // Call methods from both parts of the partial class
            person.PrintFirstName();
            person.PrintLastName();


            Console.WriteLine("\nDone.");
        }
    }
}
