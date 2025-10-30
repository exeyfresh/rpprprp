using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Âûáåðèòå òèï ââîäà:");
        Console.WriteLine("1 - Ôàðåíãåéòû");
        Console.WriteLine("2 - Êåëüâèíû");
        Console.Write("Ââåäèòå íîìåð âûáðàííîãî òèïà: ");
        string choice = Console.ReadLine();

        if (choice == "1")
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
        else if (choice == "2")
        {
            Console.Write("Ââåäèòå òåìïåðàòóðó â Êåëüâèíàõ: ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double kelvin))
            {
                if (kelvin < 0)
                {
                    Console.WriteLine("Îøèáêà: òåìïåðàòóðà â Êåëüâèíàõ íå ìîæåò áûòü îòðèöàòåëüíîé.");
                }
                else
                {
                    double celsius = kelvin - 273.15;
                    Console.WriteLine($"Òåìïåðàòóðà â Öåëüñèÿõ: {celsius:F2}");
                }
            }
            else
            {
                Console.WriteLine("Îøèáêà: ââåäåíî íåêîððåêòíîå çíà÷åíèå.");
            }
        }
        else
        {
            Console.WriteLine("Íåêîððåêòíûé âûáîð. Ïîæàëóéñòà, çàïóñòèòå ïðîãðàììó çàíîâî è âûáåðèòå 1 èëè 2.");
        }
    }
}