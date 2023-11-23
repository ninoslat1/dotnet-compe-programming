using System;
using System.Collections.Generic;

public class Fibonacci {
    public static void Main(string[] args) {
        Console.WriteLine("Pick a length of number: ");
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int length)) {
            if (length != 0) {
                List<int> fibonacciList = GenerateFibonacciSequence(length);
                Console.WriteLine(string.Join(", ", fibonacciList));
            } else {
                Console.WriteLine("Please insert a non-zero number");
            }
        } else {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }

    public static List<int> GenerateFibonacciSequence(int length) {
        int i = 0;
        int x = 0;
        int y = 1;
        int z;
        List<int> fibonacciList = new List<int>();

        fibonacciList.Add(x);
        fibonacciList.Add(y);

        while (i < length) {
            z = x + y;
            x = y;
            y = z;

            fibonacciList.Add(z);
            i += 1;
        }

        return fibonacciList;
    }
}