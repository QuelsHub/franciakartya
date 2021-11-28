using System;
using System.Collections.Generic;
using System.Linq;

namespace franciakartya
{
    class Program
    {
        
        static void deck()
        {
            //Változók és tömbök
            string[] Color = {"Treff","Pick","Káró","Kör"};
            string[] Shape = {"2","3","4","5","6","7","8","9","10","J","D","K","A"};
            int DeckSize = 52;
            string[] Deck = new string[DeckSize];


            //Pakli összeállítása
            int counter = 0;

            for (int i = 0; i < Color.Length; i++)
            {

                for (int j = 0; j < Shape.Length; j++)
                {

                    Deck[counter] = Color[i] + " " + Shape[j];
                    counter++;
                }

            }


            //Pakli kiiratása
            counter = 0;

            Console.WriteLine("A teljes pakli tartalma:\n");

            foreach (var item in Deck)
            {
                
                Console.Write(item + "\t");
                counter++;
                if (counter == 3)
                {
                    Console.WriteLine();
                    counter = 0;
                }
            }


            //Random 5 lap kiválasztása
            Random random = new Random();
            HashSet<int> Rnd = new HashSet<int>();

            do
            {
                Rnd.Add(random.Next(0, DeckSize-1));
            } while (Rnd.Count != 5);

            Console.WriteLine("\n\nA kiosztott lapjaid:\n");

            foreach (var item in Rnd)
            {
                Console.WriteLine(Deck[item]);
            }

            
            //Keverés
            string[] shuffled = Deck.OrderBy(c => random.Next()).ToArray();

            Console.WriteLine("A megkevert pakli:\n");

            counter = 0;
            
            foreach (var item in shuffled)
            {

                Console.Write(item + "\t");
                counter++;
                if (counter == 3)
                {
                    Console.WriteLine();
                    counter = 0;
                }
            }
        }



        static void Main(string[] args)
        {
            deck();
            Console.ReadKey();
        }
    }
}
