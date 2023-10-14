// Multi-dimensional arrays - FindMax
// Implement the FindMax method, which given a two-dimensional array of integers, returns the maximal value from this array.

// If any of the array's dimensions is zero, it means the array is empty, and the method should return -1.

// For example:

// for an empty array of size [0,3] the result should be -1

// for an array like this, the result should be 12
//  3   5
// -1  12
//  4   0


using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static int FindMax(int[,] numbers)
        {
            if (numbers.GetLength(0) == 0 || numbers.GetLength(1) == 0)
            {
                return -1;
            }

            int max = numbers[0, 0];

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    if (numbers[i, j] > max)
                    {
                        max = numbers[i, j];
                    }
                }
            }

            return max;
        }
        public static void Main(string[] args)
        {
            int[,] array = { { 3, 5 }, { -1, 12 }, { 4, 0 } };
            int maxNumber = FindMax(array);
            Console.WriteLine("Maximum number in the array: " + maxNumber);
        }
    }
}
