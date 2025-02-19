namespace COMP003A.ZooManagementSystem;

/// <summary>
/// Abstract base (parent) animal class. 
/// </summary>
public abstract class Animal
{
    // fields (private)
    private string _name;
    private string _species;

    // Properties (public) with implementation and validation.
    public string Name
    {
        // implementation 
        get { return _name; }
        set // validation ensuring that the name's value is not empty 
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name cannot be empty.");
            }
            _name = value;
        }
    }

    public string Species
    {
        get { return _species; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Species cannot be empty.");
            }
            _species = value;
        }
    }

    // Empty abstract method (will be overridden in child class)
    public abstract void MakeSound();
}