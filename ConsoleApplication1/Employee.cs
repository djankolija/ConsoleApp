class Employee : Person
{
    public override void SayFullName()
    {
        System.Console.WriteLine($"I am employee: {FirstName} {LastName}");
    }
}