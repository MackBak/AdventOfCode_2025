using System.IO;
using System.Collections.Generic;

class Program
{
    private static void Main()
    {
        var input = File.ReadAllLines("../../../d1_input.txt");

        const int start = 50;
        const int neutral = 0;
        const int maxKnob = 100;

        var zeroCounter = CalculateZeros(input, start, neutral, maxKnob);
        
        Console.WriteLine(zeroCounter);
    }

    
    private static int CalculateZeros(string[] commands, int start, int neutral, int maxKnob)
    {
        var directionList = new List<char>();
        var stepsList = new List<int>();

        foreach (var line in commands)
        {
            directionList.Add(line[0]);
            stepsList.Add(int.Parse(line[1..]));
        }

        var knobPosition = start;
        var zeroCounter = 0;

        for (int i = 0; i < directionList.Count; i++)
        {
            if (directionList[i] == 'L')
            {
                knobPosition = (knobPosition - stepsList[i]) % maxKnob;
                if (knobPosition < 0)
                {
                    knobPosition += maxKnob;
                }
            }
            
            else if (directionList[i] == 'R')
            {
                knobPosition = (knobPosition + stepsList[i]) % maxKnob;
            }

            if (knobPosition == neutral)
            {
                zeroCounter++;
            }
        }

        return zeroCounter;
    }
}