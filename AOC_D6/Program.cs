using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string [] lines = File.ReadAllLines("../../../d6_input.txt");
        int[][] arrays = new int[4][];
        string[] array5;

        for (var i = 0; i < 4; i++)
        {
            arrays[i] = lines[i].Split([' ', '\t'], StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();
        }
        array5 = lines[4].Split([' ', '\t'], StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"{arrays[0][i]} {arrays[1][i]} {arrays[2][i]} {arrays[3][i]} {array5[i]}");
        }

    }
}