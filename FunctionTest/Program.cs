using System;
class FunctionTest
{
    //static void Sum()
    //{
    //    Console.WriteLine("Sun: ");
    //}
    static int Sum(int first, int second)
    {
        int sum = first + second;
        //Console.WriteLine($"Sum = {sum} ");
        return sum;
    }

    static void Main(string[] args)
    {
        
        int first = Convert.ToInt32(args[0]);
        int second = Convert.ToInt32(args[1]);

        //int result = FunctionTest.Sum(3, 5); 

        int result = Sum(first, second);
        Console.WriteLine($"Sum = {result} ");
    }

}