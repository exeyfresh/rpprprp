using System;

class Program
{
    enum TempUnit
    {
        Celsius = 1,
        Fahrenheit,
        Kelvin
    }

    static void Main()
    {
        Console.WriteLine("Âûáåðèòå èñõîäíóþ åäèíèöó èçìåðåíèÿ:");
        Console.WriteLine("1 - Öåëüñèé");
        Console.WriteLine("2 - Ôàðåíãåéò");
        Console.WriteLine("3 - Êåëüâèí");
        Console.Write("Ââåäèòå íîìåð: ");
        int fromUnit = int.Parse(Console.ReadLine());

        Console.WriteLine("Âûáåðèòå êîíå÷íóþ åäèíèöó èçìåðåíèÿ:");
        Console.WriteLine("1 - Öåëüñèé");
        Console.WriteLine("2 - Ôàðåíãåéò");
        Console.WriteLine("3 - Êåëüâèí");
        Console.Write("Ââåäèòå íîìåð: ");
        int toUnit = int.Parse(Console.ReadLine());

        Console.Write("Ââåäèòå òåìïåðàòóðó: ");
        double temp = double.Parse(Console.ReadLine());

        double tempInCelsius = 0;

        // Ïåðåâîäèì â Öåëüñèé
        if (fromUnit == (int)TempUnit.Celsius)
            tempInCelsius = temp;
        else if (fromUnit == (int)TempUnit.Fahrenheit)
            tempInCelsius = (temp - 32) * 5 / 9;
        else if (fromUnit == (int)TempUnit.Kelvin)
            tempInCelsius = temp - 273.15;

        double result = 0;

        // Ïåðåâîäèì èç Öåëüñèÿ â íóæíóþ øêàëó
        if (toUnit == (int)TempUnit.Celsius)
            result = tempInCelsius;
        else if (toUnit == (int)TempUnit.Fahrenheit)
            result = tempInCelsius * 9 / 5 + 32;
        else if (toUnit == (int)TempUnit.Kelvin)
            result = tempInCelsius + 273.15;

        Console.WriteLine($"Ðåçóëüòàò: {result:F2}");
    }
}