/*
    Author: Angel Gomez
    Course: COMP-003A
    Faculty: Jonathan Cruz
    Purpose: Zoo management system demonstrating inheritance, abstraction, polymorphism, and method overloading in C#
*/
namespace COMP003A.ZooManagementSystem;

class Program
{
    static void Main(string[] args)
    {
        // Welcome 
        Console.WriteLine("Welcome to the Zoo Management System! ");
        
        // List that stores the added zoo animals 
        List<Animal> animals = new List<Animal>();
        
        // zooUtility class used to describe an animal 
        ZooUtility zooUtility = new ZooUtility();
        
        // Variable for the loop condition 
        bool exit = true;

        // Looped menu, ends only when the user selects exit, aka option 5. 
        while (exit)
        {
            Console.WriteLine("\nSelect an option (1-5): ");
            Console.WriteLine("1. Add a Lion \n2. Add a Parrot \n3. Display all animals \n4. Describe the animals \n5. Exit");
            Console.Write("Your choice: ");

            // Try-Catch for incorrect user input (so application doesn't end unexpectedly). 
            try
            {
                int choice = int.Parse(Console.ReadLine());

                // If-else and else-if statements for menu choice 1-5
                // Add a lion. 
                if (choice == 1)
                {
                    Console.Write("\nEnter the name of the lion: ");
                    string lionName = Console.ReadLine();
                    Console.Write("Enter the species of the lion: ");
                    string lionSpecies = Console.ReadLine();
                    int lionAge = 6; // Preset lion age to show I understand method overloading. 
                    
                    Lion lion = new Lion { Name = lionName, Species = lionSpecies, Age = lionAge };
                    animals.Add(lion);
                    Console.WriteLine("Lion added successfully! ");
                }
                // Add a parrot. 
                else if (choice == 2)
                {
                    Console.Write("\nEnter the name of the parrot: ");
                    string parrotName = Console.ReadLine();
                    Console.Write("Enter the species of the parrot: ");
                    string parrotSpecies = Console.ReadLine();
                    int parrotAge = 3; // preset parrot age to show I understand method overloading.
                    
                    Parrot parrot = new Parrot { Name = parrotName, Species = parrotSpecies, Age = parrotAge };
                    animals.Add(parrot);
                    Console.WriteLine("Parrot added successfully! ");
                }
                // Display all of the zoo animals. 
                else if (choice == 3)
                {
                    Console.WriteLine("\nDisplaying all animals: ");
                    
                    // Cycles through the animal list 
                    foreach (var animal in animals)
                    {
                        animal.MakeSound();
                        Console.WriteLine($"({animal.Name}, {animal.Species}) ");
                    }
                }
                // Describe an animal 
                else if (choice == 4)
                {
                    Console.WriteLine("\nSelect an option: ");
                    Console.WriteLine("1. Describe by name only");
                    Console.WriteLine("2. Describe by name and species");
                    Console.WriteLine("3. Describe by name, species, and age");
                    Console.Write("Choice: ");
                    
                    string describeChoice = Console.ReadLine(); // string to avoid using another try catch 
                    
                    // if else statements for description choice 1-3 
                    if (describeChoice == "1") // Display animal names only 
                    {
                        foreach (var animal in animals)
                        {
                            zooUtility.DescribeAnimal(animal.Name);
                        }
                    }
                    else if (describeChoice == "2") // Display animal names and species 
                    {
                        foreach (var animal in animals)
                        {
                            zooUtility.DescribeAnimal(animal.Name, animal.Species);
                        }
                    }
                    else if (describeChoice == "3") // Display animal name, species, and age 
                    {
                        foreach (var animal in animals)
                        {
                            zooUtility.DescribeAnimal(animal.Name, animal.Species, animal.Age);
                        }
                    }
                    // Prompts user to select number 1-3 (sends them back to main menu).
                    else
                    {
                        Console.WriteLine("Invalid input. Please select a number 1-3. \nRedirecting to main menu..."); 
                    }
                }
                // Ends loop and application. 
                else if (choice == 5)
                {
                    Console.WriteLine("\nGoodbye!");
                    exit = false;
                }
                // Prompts user to select number 1-5 if another number was selected (similar to the try-catch). 
                else
                {
                    Console.WriteLine("Invalid input. Please select a number 1-5."); 
                }
            }
            // catches exceptions described in the Animal class
            catch (ArgumentException ex)
            {
                Console.WriteLine($"{ex.Message} Try again.");
            }
            // Tells the user they entered a wrong input, allows the user to try again instead of ending the program.
            catch (Exception) 
            {
                Console.WriteLine("Invalid input. Try again.");  
            }
        }
    }
}