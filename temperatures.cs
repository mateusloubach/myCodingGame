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

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        if (n == 0)
        {
            Console.WriteLine(0);
            return;
        }

        string[] temperatures = Console.ReadLine().Split();
        int closestTemp = int.Parse(temperatures[0]);

        for (int i = 1; i < n; i++)
        {
            int currentTemp = int.Parse(temperatures[i]);
            if (Math.Abs(currentTemp) < Math.Abs(closestTemp) || (Math.Abs(currentTemp) == Math.Abs(closestTemp) && currentTemp > closestTemp))
            {
                closestTemp = currentTemp;
            }
        }

        Console.WriteLine(closestTemp);
    }
}