using System;

class Program
{
    static void Main()
    {
        Console.Write("Ââåäèòå òåìïåðàòóðó â Ôàðåíãåéòàõ: ");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double fahrenheit))
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"Òåìïåðàòóðà â Öåëüñèÿõ: {celsius:F2}");
        }
        else
        {
            Console.WriteLine("Îøèáêà: ââåäåíî íåêîððåêòíîå çíà÷åíèå.");
        }
    }
}