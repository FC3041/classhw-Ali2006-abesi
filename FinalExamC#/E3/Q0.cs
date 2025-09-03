public class Animal
{
    public Animal() { }

    public virtual string MakeSound()
    {
        return "Some generic animal sound";
    }
}

public class Dog : Animal
{
    public Dog() : base() { }

    public override string MakeSound()
    {
        return "Woof";
    }
}