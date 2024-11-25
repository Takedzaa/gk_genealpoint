class HoumeWork
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter the array elements separated by commas:");
        string input = Console.ReadLine();
        string[] initialArray = input.Split(',');

        string[] filteredArray = FilterShortStrings(initialArray, 3);

        Console.WriteLine("Resalt:");
        Console.WriteLine($"[{string.Join(", ", filteredArray)}]");
    }

    static string[] FilterShortStrings(string[] array, int maxLength)
    {
        int count = 0;
        foreach (string str in array)
        {
            if (str.Trim().Length <= maxLength) count++;
        }

        string[] result = new string[count];
        int index = 0;
        foreach (string str in array)
        {
            if (str.Trim().Length <= maxLength)
            {
                result[index] = str.Trim();
                index++;
            }
        }

        return result;
    }
}