namespace COMP003A.ZooManagementSystem;

/// <summary>
/// Lion derived (child) class which is a type of Animal. 
/// </summary>
public class Lion : Animal 
{
    // Override MakeSound() 
    public override void MakeSound()
    {
        Console.Write("The lion roars! ");
    }
}