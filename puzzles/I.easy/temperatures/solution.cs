// Temperatures - Solution in C#
// GOAL
// In this exercise, you have to analyze records of temperature to find the closest to zero.
// You need to solve this puzzle using as little characters as possible.

// RULES
// Write a program that prints the temperature closest to 0 among input data. 
// If two numbers are equally close to zero, positive integer has to be considered closest to zero 
// (for instance, if the temperatures are -5 and 5, then display 5).

//INPUT

// Your program must read the data from the standard input and write the result on the standard output.
// Input

// Line 1: N, the number of temperatures to analyze
// Line 2: The N temperatures expressed as integers ranging from -273 to 5526

// Output
// Display 0 (zero) if no temperatures are provided. Otherwise, display the temperature closest to 0.

// Constraints
// 0 ≤ N < 10000

// Example

// Input

// 5
// 1 -2 -8 4 5

// Output

// 1

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] inputs = Console.ReadLine().Split(' ');
        int res = n > 0 ? 5526 : 0;

        for (int i = 0; i < n; i++)
        {
            int t = int.Parse(inputs[i]);
            res = (Math.Abs(t) == Math.Abs(res) && t > 0) ? t : (Math.Abs(t) < Math.Abs(res)) ? t : res;
        }

        Console.WriteLine(res);
    }
}
