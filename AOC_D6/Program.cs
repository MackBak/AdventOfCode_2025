using System;
using System.Collections.Specialized;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        var lines = File.ReadAllLines("../../../d6_input.txt");
        var arrays = new int[4][];

        for (var i = 0; i < 4; i++)
        {
            arrays[i] = lines[i].Split([' ', '\t'], StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();
        }
        var oprArray = lines[4].Split([' ', '\t'], StringSplitOptions.RemoveEmptyEntries);
        long sum = 0;
        
        for (var i = 0; i < oprArray.Length; i++)
        {
            Console.WriteLine($"Call nr: {i}");
            long a = arrays[0][i];
            long b = arrays[1][i];
            long c = arrays[2][i];
            long d = arrays[3][i];

            var opr = oprArray[i].Trim();

            switch (opr)
            {
                case "+":
                    var calc = addNums(a, b, c, d);
                    sum += calc;
                    break;
                case "*":
                    var calc2 = multiplyNums(a, b, c, d);
                    sum += calc2;
                    break;
            }
        }
        
        Console.WriteLine(sum);
    }
    
    private static long multiplyNums(long a, long b, long c, long d)
    {
        return a * b * c * d;
    }

    private static long addNums(long a, long b, long c, long d)
    {
        return a + b + c + d;
    }
}
