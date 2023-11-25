using Spectre.Console;

public class Palindrome {
    public static void Main(string[] args) {
        Console.WriteLine("Type some text: ");
        string? input = Console.ReadLine();

        if (string.IsNullOrEmpty(input)) {
            Console.WriteLine("Please insert a text");
            return;
        }

        var selection = AnsiConsole.Prompt(new SelectionPrompt<string>()
                        .Title("Select palindrome mode")
                        .PageSize(5)
                        .MoreChoicesText("[grey](Move up and down)[/]")
                        .AddChoices(new[] {
                            "Pointer","Reverse"
                        }));

        if(selection == "Reverse"){
            CheckReversePalindrome(input);
        } else {
            CheckPointerPalindrome(input);
        }
    }

    public static void CheckReversePalindrome(string input) {
        char[] stringArr = input.ToCharArray();
        Array.Reverse(stringArr);
        string reversedInput = new string (stringArr);

        if (input == reversedInput) {
            Console.WriteLine("Palindrome");
        } else {
            Console.WriteLine("Not Palindrome");
        }
    }

    public static void CheckPointerPalindrome(string input) {
        int left = 0;
        int right = input.Length - 1;

        while (left < right) {
            if (input[left] != input[right]) {
                Console.WriteLine("Not Palindrome");
            }
            left++;
            right--;
        }

        Console.WriteLine("Palindrome");
    }
}