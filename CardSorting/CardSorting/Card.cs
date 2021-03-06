﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardSorting
{

    public enum Suit
    {
        Spades,
        Clubs,
        Diamonds,
        Hearts
    }

    public enum Value
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13
    }

    class Card : IComparable<Card>
    {
        public Suit suit;
        public Value value;

        public Card(Suit s, Value v)
        {
            suit = s;
            value = v;
        }

        private string _name;

        public string name
        {
            get
            {
                _name = value.ToString() + " of " + suit.ToString();
                return _name;
            }
        }

        public int CompareTo(Card cardToCompare)
        {
            if (this.value > cardToCompare.value)
                return 1;
            else if (this.value < cardToCompare.value)
                return -1;
            else
                return 0;
               
        }

    }
}
