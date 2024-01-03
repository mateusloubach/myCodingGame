using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        string inputMessage = Console.ReadLine();
        string outputMessage = binaryFunction(inputMessage);
        string resultMessage = unaryFunction(outputMessage);
        
        Console.WriteLine($"{resultMessage}");
    }
    static string binaryFunction(string inputMessage)
    {
        StringBuilder binaryStringBuilder = new StringBuilder();

        foreach (char x in inputMessage)
        {
            string binaryRepresentation = Convert.ToString(x, 2).PadLeft(7, '0');
            binaryStringBuilder.Append(binaryRepresentation);
        }
        return binaryStringBuilder.ToString();
    }
    static string unaryFunction(string outputMessage)
    {
        string unaryOutput = "";

        for (int i = 0; i < outputMessage.Length; i++)
        {
            if (outputMessage[i] == '1')
            {
                unaryOutput += "0 ";
            }
            else if (outputMessage[i] == '0')
            {
                unaryOutput += "00 0 ";
            }
        }
        return unaryOutput.TrimEnd();
    }
}
