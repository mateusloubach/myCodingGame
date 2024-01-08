//Power of Thor - Ep1 - solution in C#

using System;

class Program
{
    static void Main()
    {
        // Read input values
        string[] inputValues = Console.ReadLine().Split();
        int light_x = int.Parse(inputValues[0]);
        int light_y = int.Parse(inputValues[1]);
        int initial_tx = int.Parse(inputValues[2]);
        int initial_ty = int.Parse(inputValues[3]);

        // Game loop
        while (true)
        {
            // Read the number of remaining moves (not used in this example)
            int remaining_turns = int.Parse(Console.ReadLine());

            // Calculate the direction for Thor to move
            string direction_x = "";
            string direction_y = "";

            if (initial_tx > light_x)
            {
                direction_x += "W";
                initial_tx -= 1;
            }
            else if (initial_tx < light_x)
            {
                direction_x += "E";
                initial_tx += 1;
            }

            if (initial_ty > light_y)
            {
                direction_y += "N";
                initial_ty -= 1;
            }
            else if (initial_ty < light_y)
            {
                direction_y += "S";
                initial_ty += 1;
            }

            // Print the move instruction
            Console.WriteLine(direction_y + direction_x);
        }
    }
}
