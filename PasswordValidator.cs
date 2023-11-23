using System.Text.RegularExpressions;

public partial class Program
{
    public static void Main()
    {
        
        Regex validateGuidRegex = MyRegex();
        Console.Write("Enter the password: ");
        string? input = Console.ReadLine();

        if (input is null)
            {
                Console.WriteLine("Error reading input.");
                return;
            }
        
        bool result = validateGuidRegex.IsMatch(input);
        Console.WriteLine(result);
    }

    [GeneratedRegex(
        @"^(?=.*?[A-Z])" +          // At least one uppercase English letter
        @"(?=.*?[a-z])" +           // At least one lowercase English letter
        @"(?=.*?[0-9])" +           // At least one digit
        @"(?=.*?[#?!@$%^&*-])" +    // At least one special character
        @".{8,}$"                   // Has minimum 8 characters in length
    )]
    private static partial Regex MyRegex();
}