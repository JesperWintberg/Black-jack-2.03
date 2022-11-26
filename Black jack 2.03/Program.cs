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

            if (val == "y")
            {
                sant = true;
            }

            if (val == "n")
            {
                sant = false;
            }

            int startplayer = rndmvalue + rndmvalue2;
         

            while (sant)
            {
                int rndmvalue5 = number[random.Next(0, 11)];
                string rndmsuits5 = suits[random.Next(0, 4)];

                Console.WriteLine($"Du fick ett {rndmsuits5} {rndmvalue5}");
                Console.WriteLine($"Du har nu {rndmvalue5 + startplayer} poäng");
                Console.WriteLine("Vill du dra ett nytt kort? (y/n)");
                string val2 = Console.ReadLine();
                val2.ToLower();

                int endplayer = rndmvalue5 + startplayer;

                endplayer = startplayer;

                if (endplayer > 21)
                {
                    Console.WriteLine("Du har förlorat");
                    break;
                }
                if(endplayer == 21)
                {
                    Console.WriteLine("Grattis du har vunnit");
                    break;
                }

                if (val2 == "n")
                {
                    sant = false;
                }


            }

            while (!sant)
            {
                int rndmvalue3=number[random.Next(0, 11)];
                int rndmvalue4 = number[random.Next(0, 11)];

                string rndmsuits3 = suits[random.Next(0, 4)];
                string rndmsuits4 = suits[random.Next(0, 4)];

                Console.WriteLine($"Datorn drog ett {rndmsuits3} {rndmvalue3} och ett {rndmsuits4} {rndmvalue4}");
                Console.WriteLine($"Datorn har nu {rndmvalue3 + rndmvalue4} poäng");

                int PCend = rndmvalue3 + rndmvalue4;

                if (PCend >= 17)
                {
                    break;
                }

                else
                {
                    
                }


            }

        }
    }
}

