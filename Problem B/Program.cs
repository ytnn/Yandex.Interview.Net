public class Solution
{
    public static void Main(string[] args)
    {
        const string searchedElementValue = "1";
        var currentSequenceLength = 0;
        var maxSequenceLength = 0;

        SkipFirstElement();

        while (true)
        {
            var currentElementValue = GetCurrentElement();
            if (currentElementValue == null)
                break;

            if (currentElementValue == searchedElementValue)
            {
                currentSequenceLength++;
                if (currentSequenceLength > maxSequenceLength)
                {
                    maxSequenceLength = currentSequenceLength;
                }
            }
            else
            {
                currentSequenceLength = 0;
            }
        }

        Console.WriteLine($"{maxSequenceLength}");
    }

    private static void SkipFirstElement() => GetCurrentElement();

    private static string? GetCurrentElement() => Console.ReadLine();
}
