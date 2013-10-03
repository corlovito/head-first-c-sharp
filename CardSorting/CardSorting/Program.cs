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

            CardComparer_byValue cardComparer = new CardComparer_byValue();

            while (deck.Count() < 52)
            {
                Card card = new Card((Suit)random.Next(4), (Value)random.Next(1, 14));

                bool inDeck = false;
                foreach (Card c in deck)
                {
                    if (c.name == card.name)
                    {
                        inDeck = true;
                        break;
                    }
                }

                if (!inDeck)
                    deck.Add(card);
            }

            deck.Sort();

            foreach (Card card in deck)
                Console.WriteLine(card.name);

            Console.ReadKey();
        }
    }
}
