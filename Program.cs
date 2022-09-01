using System;

namespace Contains;
public class Program
{
    public static void Main(string[] args)
    {
        var numbers = new List<int>()
            { 107, 92, 3, 46, 5096, 666, 85 };

        Console.WriteLine(numbers.Contains(6));
        Console.WriteLine(numbers.Contains(3));
    }
}

