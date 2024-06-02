using System;
using System.Text;
using Task1;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        var level1 = new Level1Support();
        var level2 = new Level2Support();
        var level3 = new Level3Support();
        var level4 = new Level4Support();

        level1.SetNext(level2).SetNext(level3).SetNext(level4);

        while (true)
        {
            Console.WriteLine("Ласкаво просимо до системи підтримки користувачів.");
            level1.Handle();
            Console.WriteLine("Чи потребуєте ви ще допомоги? (так/ні)");
            string userInput = Console.ReadLine().ToLower();
            if (userInput == "ні")
            {
                break;
            }
        }
    }
}
