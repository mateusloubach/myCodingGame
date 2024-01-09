using System;

class Program
{
    static void Main()
    {
        int surfaceN; // the number of points used to draw the surface of Mars.
        surfaceN = int.Parse(Console.ReadLine());
        for (int i = 0; i < surfaceN; i++)
        {
            int landX; // X coordinate of a surface point. (0 to 6999)
            int landY; // Y coordinate of a surface point. By linking all the points together in a sequential fashion, you form the surface of Mars.
            string[] landCoordinates = Console.ReadLine().Split();
            landX = int.Parse(landCoordinates[0]);
            landY = int.Parse(landCoordinates[1]);
        }

        while (true)
        {
            int X;
            int Y;
            int hSpeed; // the horizontal speed (in m/s), can be negative.
            int vSpeed; // the vertical speed (in m/s), can be negative.
            int fuel; // the quantity of remaining fuel in liters.
            int rotate; // the rotation angle in degrees (-90 to 90).
            int power; // the thrust power (0 to 4).

            string[] spaceshipData = Console.ReadLine().Split();
            X = int.Parse(spaceshipData[0]);
            Y = int.Parse(spaceshipData[1]);
            hSpeed = int.Parse(spaceshipData[2]);
            vSpeed = int.Parse(spaceshipData[3]);
            fuel = int.Parse(spaceshipData[4]);
            rotate = int.Parse(spaceshipData[5]);
            power = int.Parse(spaceshipData[6]);

            if (Y < 1650)
            {
                Console.WriteLine("0 4");
            }
            else if (Y < 2200)
            {
                Console.WriteLine("0 3");
            }
            else if (Y < 2300)
            {
                Console.WriteLine("0 2");
            }
            else if (Y < 2450)
            {
                Console.WriteLine("0 1");
            }
            else
            {
                Console.WriteLine("0 0");
            }
        }
    }
}
