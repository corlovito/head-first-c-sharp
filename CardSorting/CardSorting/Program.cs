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
            Card firstCard = new Card((Suit)random.Next(4), (Value)random.Next(1, 13));
            deck.Add(firstCard);

            for (int i = 0; i < 52; i++)
            {
                Card card;
                do
                {
                    card = new Card((Suit)random.Next(4), (Value)random.Next(1, 13));
                } while (true);
     
                

                if (deck[i].suit == card.suit && deck[i].value == card.value) // make each card unique
                    i--;
                else
                    deck.Add(card);

            }

          

            foreach (Card card in deck)
                Console.WriteLine(card.name);

            Console.ReadKey();

        }
    }
}
