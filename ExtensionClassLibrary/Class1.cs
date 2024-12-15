using Person;

namespace ExtensionClassLibrary
{
    public static class ExtensionClassLibrary1
    {
        public static int CalculateAge(this Person1 person)

        {
            return DateTime.Today.Year - person.dateOfBirth.Year;
        }

        public static int WordCount(this string text)
        {
            if(string.IsNullOrWhiteSpace(text)) return 0;

            string[] str = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            return str.Length;
        }
    }
}
