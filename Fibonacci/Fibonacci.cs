public class Fibonacci {
    public static void Main(string[] args) {
        int i = 0;
        int x = 0;
        int y = 1;
        int z;
        List<int> list = new List<int>();

        Console.WriteLine("Pick a length of number: ");
        string? input = Console.ReadLine();

        if(int.TryParse(input, out int length)){
            void Fibonacci(int len){
                list.Add(x);
                list.Add(y);

                while(i < len){
                    z = x + y;
                    x = y;
                    y = z;

                    list.Add(z);
                    i += 1;
                }
                Console.WriteLine(string.Join(", ", list));
                }
            if(length != 0) {
                Fibonacci(length);
             } else { 
                Console.WriteLine("Please insert a non-zero number");
             }
        } else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}