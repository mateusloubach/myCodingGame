using System;

class Program
{
    static void Main()
    {
        int l = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());
        string t = Console.ReadLine().ToUpper();

        string[] sample = new string[h];
        for (int i = 0; i < h; i++)
        {
            sample[i] = Console.ReadLine();
        }

        for (int i = 0; i < h; i++)
        {
            foreach (char x in t)
            {
                int code = char.IsLetter(x) ? (char.ToUpper(x) - 'A' + 1) : 27;
                Console.Write(sample[i].Substring((code - 1) * l, l));
            }
            Console.WriteLine();
        }
    }
}
