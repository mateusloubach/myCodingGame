//There is no Spoon - Episode 1

using System;

class Program
{
    static char[,] map;
    
    static int CheckHorizontal(int j, int i, int width)
    {
        for (j = j + 1; j < width; j++)
        {
            if (map[i, j] == '0')
            {
                return j;
            }
        }
        return -1;
    }

    static int CheckVertical(int i, int j, int height)
    {
        Console.Error.WriteLine($"\narg [i][j] = {i}{j} ");
        for (i = i + 1; i < height; i++)
        {
            Console.Error.Write($"char - {map[i, j]} ");
            if (map[i, j] == '0')
            {
                Console.Error.WriteLine($"found i = {i}");
                return i;
            }
        }
        return -1;
    }

    static void Main()
    {
        int width = int.Parse(Console.ReadLine()); // the number of cells on the X axis
        int height = int.Parse(Console.ReadLine()); // the number of cells on the Y axis

        map = new char[height, width];

        for (int i = 0; i < height; i++)
        {
            string line = Console.ReadLine();
            for (int j = 0; j < width; j++)
            {
                map[i, j] = line[j];
            }
        }

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (map[i, j] == '0')
                {
                    Console.Write($"{j} {i} ");
                    int index = CheckHorizontal(j, i, width);
                    if (index == -1)
                    {
                        Console.Write($"{-1} {-1} ");
                    }
                    else
                    {
                        Console.Write($"{index} {i} ");
                    }

                    index = CheckVertical(i, j, height);
                    Console.Error.Write($"index = {index}");
                    if (index == -1)
                    {
                        Console.Write($"{-1} {-1} ");
                    }
                    else
                    {
                        Console.Write($"{j} {index} ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}