using System;

namespace ____
{
    class Program
    {
        static void Main(string[] args)
        {
            int[]number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            string[] suits = { "Klöver", "Spader", "Knäckt", "Hjärter" };

            Random random = new Random();

            bool sant = true;

            int storedge = 0;

            while (sant)
            {
                int rndmvalue = number[random.Next(0, 11)];
                int rndmvalue2 = number[random.Next(0, 11)];

                string rndmsuits = suits[random.Next(0, 4)];
                string rndmsuits2 = suits[random.Next(0, 4)];

                Console.WriteLine("välkommen till Black jack");
                Console.WriteLine($"Dina startkort kommer att vara {rndmsuits} {rndmvalue} och {rndmsuits2} {rndmvalue2}");
                Console.WriteLine($"Du kommer nu att ha {rndmvalue + rndmvalue2} poäng");
                Console.WriteLine("Vill du ta ett nytt kort (y/n)");
                string val = Console.ReadLine();
                val.ToLower();

                int startplayer = rndmvalue + rndmvalue2;


            }

            while (!sant)
            {
                int rndmvalue=number[random.Next(0, 11)];
                int rndmvalue2 = number[random.Next(0, 11)];

                string rndmsuits = suits[random.Next(0, 4)];
                string rndmsuits2 = suits[random.Next(0, 4)];

                Console.WriteLine($"Datorn drog ett {rndmsuits} {rndmvalue} och ett {rndmsuits2} {rndmvalue2}");
                Console.WriteLine($"Datorn har nu {rndmvalue + rndmvalue2} poäng");

            }

        }
    }
}

