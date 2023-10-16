using System;


class program
{
    static void Main(string[] args)
    {
        IEnumerable<int> oddNums =
 
            Enumerable.Range(20, 20).Where(Oddonly => Oddonly % 2 != 0);
 
        foreach (int n in oddNums)
        {
            Console.WriteLine(n);
        }
        Console.ReadLine();
 
    }
}