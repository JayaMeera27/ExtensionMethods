using ExtensionMethod_Class;
using Person;


class Program
{
    public static void Main()
    {
        Person1 p = new Person1 { name = "Meera", dateOfBirth = new DateTime(1999,2,27) };
        string displayText = $"Age of {p.name} is {p.CalculateAge()}";
        Console.WriteLine(displayText );
        Console.WriteLine($"Word Count is {displayText.WordCount()}");


    }
}
