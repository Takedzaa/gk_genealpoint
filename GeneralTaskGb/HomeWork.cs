namespace GeneralTaskGb;

internal static class HomeWork
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Please enter the array elements separated by commas:");
        var input = Console.ReadLine();
        var initialArray = input?.Split(',');

        var filteredArray = FilterShortStrings(initialArray, 3);

        Console.WriteLine("Result:");
        Console.WriteLine($"[{string.Join(", ", filteredArray)}]");
    }

    private static string[] FilterShortStrings(string[] array, int maxLength)
    {
        var count = 0;
        foreach (string str in array)
        {
            if (str.Trim().Length <= maxLength) count++;
        }

        var result = new string[count];
        var index = 0;
        foreach (var str in array)
        {
            if (str.Trim().Length > maxLength) continue;
            result[index] = str.Trim();
            index++;
        }

        return result;
    }
}