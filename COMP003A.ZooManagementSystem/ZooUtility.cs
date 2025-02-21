using System.Net;

namespace COMP003A.ZooManagementSystem;

/// <summary>
/// Class used for overloading the Animal's name, species, and age. 
/// </summary>
internal class ZooUtility
{
    public void DescribeAnimal(string name)
    {
        Console.WriteLine($"Animal Name: {name}");
    }

    public void DescribeAnimal(string name, string species)
    {
        Console.WriteLine($"Animal Name: {name}, Species: {species}");
    }

    public void DescribeAnimal(string name, string species, int age)
    {
        // Don't need this anymore since the animal ages are predetermined 
        /*if (age == 0)
        {
            Console.WriteLine($"Animal Name: {name}, Species: {species}, No age provided. "); 
        }
        else
        */
        {
            Console.WriteLine($"Animal Name: {name}, Species: {species}, Age: {age} years old. ");
        }
    }
}