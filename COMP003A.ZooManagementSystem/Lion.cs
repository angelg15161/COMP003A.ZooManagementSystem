namespace COMP003A.ZooManagementSystem;

/// <summary>
/// Lion derived (child) class which is a type of Animal. 
/// </summary>
internal class Lion : Animal 
{
    // Override MakeSound() from the animal abstract class
    public override void MakeSound()
    {
        Console.Write("The lion roars! ");
    }
}