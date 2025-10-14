using System;
namespace TestGit;

public class Class1
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static void Main(String[] args)
    {
        Console.WriteLine("Hello World!");
        int a = 5;
        int b = 10;
        Console.WriteLine("Sum: " + Add(a, b));
    }

}
