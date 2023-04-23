using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Solution
{
    public static void Main(string[] args)
    {
        SkipFirstElement();

        string previousElementValue = null;

        while (true)
        {
            var currentElementValue = GetCurrentElement();
            
            if (IsReadingFinished(currentElementValue))
                break;

            if (IsDuplicatedElement(previousElementValue, currentElementValue))
                continue;

            previousElementValue = currentElementValue;

            Console.WriteLine(currentElementValue);
        }
    }

    private static bool IsDuplicatedElement(string previousElementValue, string currentElementValue)
    {
        return previousElementValue == currentElementValue;
    }

    private static bool IsReadingFinished(string currentElementValue)
    {
        return currentElementValue == null;
    }

    private static void SkipFirstElement() => GetCurrentElement();

    private static string GetCurrentElement() => Console.ReadLine();
}
