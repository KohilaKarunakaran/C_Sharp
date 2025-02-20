
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        KeskiarvoDemo();
        MinusTaiPlusDemo();
    }

    static void KeskiarvoDemo()
    {
        Console.Write("Anna lukumäärä: ");
        if (int.TryParse(Console.ReadLine(), out int lukumaara) && lukumaara >= 0)
        {
            if (lukumaara == 0)
            {
                Console.WriteLine("Ei laskettavia lukuja.");
                return;
            }

            int[] luvut = new int[lukumaara];
            for (int i = 0; i < lukumaara; i++)
            {
                Console.Write($"Anna luku {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out luvut[i]))
                {
                    Console.Write("Virheellinen syöte. Anna luku uudelleen: ");
                }
                Console.WriteLine($"Syötetty luku: {luvut[i]}");
            }

            double keskiarvo = luvut.Average();
            Console.WriteLine($"Lukumäärä: {lukumaara}");
            Console.WriteLine("Syötetyt luvut: " + string.Join(", ", luvut));
            Console.WriteLine($"Keskiarvo: {keskiarvo:F2}");
        }
        else
        {
            Console.WriteLine("Virheellinen lukumäärä.");
        }
    }

    static void MinusTaiPlusDemo()
    {
        Console.Write("Anna ensimmäinen luku: ");
        int luku1 = int.Parse(Console.ReadLine());

        Console.Write("Anna toinen luku: ");
        int luku2 = int.Parse(Console.ReadLine());

        int tulos = MinusTaiPlus(luku1, luku2);
        Console.WriteLine($"Lopputulos: {tulos}");
    }

    static int MinusTaiPlus(int a, int b)
    {
        return a < b ? b - a : a + b;
    }
}

