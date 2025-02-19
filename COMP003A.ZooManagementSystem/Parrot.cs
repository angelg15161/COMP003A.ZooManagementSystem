namespace COMP003A.ZooManagementSystem;

/// <summary>
/// Parrot derived (child) class which is a type of Animal.
/// </summary>
public class Parrot : Animal
{
    // Override MakeSound() 
    public override void MakeSound()
    {
        Console.Write("The parrot squawks! ");
    }
}