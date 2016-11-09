class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public virtual void SayFullName()
    {
        System.Console.WriteLine($"My name is: {FirstName} {LastName}");
    }
}