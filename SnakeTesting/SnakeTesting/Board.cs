using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeTesting
{
    // The gameboard. Has a playfield 2d array. Array elements have a 
    // state showing what they contain : empty, fruit, snake

    static class Board
    {
        const int playfieldWidth = 10;
        const int playfieldHeight = 10;

        public enum PositionStates
        {
            empty, fruit, snake
        }       

        public static PositionStates[,] Playfield = new PositionStates[playfieldWidth, playfieldHeight];

        static Board() 
        {
            Random randomFruit = new Random();

            for (int i = 0; i < playfieldWidth; i++) // Initialize all spaces empty
            {
                for (int j = 0; j < playfieldHeight; j++)
                {
                    Playfield[i, j] = PositionStates.empty;
                }
            }

            Playfield[randomFruit.Next(0, playfieldWidth - 1), randomFruit.Next(0, playfieldHeight - 1)] = PositionStates.fruit;  // randomly place fruit on board

        }

        public static void SetPositionStatus(int x, int y, PositionStates state)
        {
            Playfield[x, y] = state;
        }

    }
}
