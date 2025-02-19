using System.Net;

namespace COMP003A.ZooManagementSystem;

/// <summary>
/// Class used for overloading the Animal's name, species, and age. 
/// </summary>
public class ZooUtility
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
        if (age == 0)
        {
            Console.WriteLine($"Animal Name: {name}, Species: {species}, No age provided. "); 
        }
        else
        {
            Console.WriteLine($"Animal Name: {name}, Species: {species}, Age: {age} years old. ");
        }
    }
}