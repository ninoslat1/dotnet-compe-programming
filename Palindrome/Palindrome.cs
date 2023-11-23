using Spectre.Console;

public class Palindrome {
    public static void Main(string[] args) {
        Console.WriteLine("Type some text: ");
        string? input = Console.ReadLine();

        if (input != null && input.Length != 0) {
            CheckPalindrome(input);
        } else { 
            Console.WriteLine("Please insert a text");
        }
    }

    public static void CheckPalindrome(string input) {
        char[] stringArr = input.ToCharArray();
        Array.Reverse(stringArr);
        string reversedInput = new string (stringArr);

        if (input == reversedInput) {
            Console.WriteLine("Palindrome");
        } else {
            Console.WriteLine("Not Palindrome");
        }
    }
}