internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, };

        Print("numbers", numbers);
        Print("IsEven", numbers.Where(x=>IsEven(x)));
        Print("Odd", numbers.Where(x=>IsOdd(x)));

    }


    static void Print(string Title, IEnumerable<int> numbers)
    {
        Console.Write($"title {Title} [");
        foreach (var num in numbers)
        {
            Console.Write($"{num}");
        }
        Console.Write("]");
        Console.WriteLine();

    }

    static bool IsEven(int numebrs)
    {
        if(numebrs%2==0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static bool IsOdd(int numebrs)
    {
        if (numebrs % 2 != 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}