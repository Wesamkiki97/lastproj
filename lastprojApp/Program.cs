internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        PrintNubers("Nubers", numbers);
        PrintNubers("Even No", numbers.Where(x => IsEven(x)));
        PrintNubers("Odd No", numbers.Where(x => IsOdd(x)));
     
        Console.WriteLine("Hello, World!");
    }
    static void PrintNubers (string title , IEnumerable<int> numbers)
    {
        Console.WriteLine();
        Console.Write($"{title}: [");
        foreach (int i in numbers) 
        {
            Console.Write($"{i}");

        }
        Console.WriteLine($" ]");
        Console.WriteLine();
    }
    static bool IsEven(int number)
    {
        if (number % 2 == 0)
        {
            return true; 

        }
        else
        {
            return false;
        }
    }
    static bool IsOdd (int number)
    {
        if ( number  != 0)
        {
            return true;

        }
        else { return false; }
    }
}