class Program
{
    static void Main()
    {
        var content = File.ReadAllText("../../../d2_input.txt");
        
        var ranges = content.Split(',');
        var array1 = new List<long>();
        var array2 = new List<long>();
        
        var resultArray = new List<long>();

        foreach (string range in ranges)
        {
            string[] parts = range.Trim().Split('-');
       
            array1.Add(long.Parse(parts[0]));
            array2.Add(long.Parse(parts[1]));
        }
        
        for (int i = 0; i < array1.Count; i++)
        {
            long startNumber = array1[i];
            long endNumber = array2[i];

            for (long j = startNumber; j <= endNumber; j++)
            {
                if (isDoubled(j))
                {
                    resultArray.Add(j);
                }
            }
        }

        long startNum = 0;

        foreach (var item in resultArray)
        {
            startNum += item;
            Console.WriteLine(item);
        }

        Console.WriteLine(startNum);
    }
    
    private static bool isDoubled(long number)
    {
        string numString = number.ToString();
        long length = numString.Length;
        
        if (length % 2 == 0)
        {
            int midpoint = numString.Length / 2;
            string firstHalf = numString.Substring(0, midpoint);
            string secondHalf = numString.Substring(midpoint);

            if (firstHalf == secondHalf)
            {
                return true;
            }
        }

        if (length % 2 == 1)
        {
            return false;
        }
        
        return false;
    }
}