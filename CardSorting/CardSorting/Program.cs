using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            List<Card> deck = new List<Card>();

            for (int i = 0; i < 52; i++)
            {
                Card card = new Card((Suit)random.Next(4), (Value)random.Next(1,13));

                if (deck. // make each card unique
                    break;
                deck.Add(card);
            }

            foreach (Card card in deck)
                Console.WriteLine(card.name);

            Console.ReadKey();

        }
    }
}
