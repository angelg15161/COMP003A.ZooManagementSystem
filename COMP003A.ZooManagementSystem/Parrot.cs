namespace COMP003A.ZooManagementSystem;

/// <summary>
/// Parrot derived (child) class which is a type of Animal. 
/// </summary>
internal class Parrot : Animal
{
    // Override MakeSound() from the animal abstract class 
    public override void MakeSound()
    {
        Console.Write("The parrot squawks! ");
    }
}