using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeTesting
{
    // The gameboard. Has a playfield 2d array. Array elements have a 
    // state showing what they contain : empty, food, snake

    class Board
    {
        const int playfieldWidth = 10;
        const int playfieldHeight = 10;

        public enum PositionStates
        {
            empty, food, snake
        }       

        public PositionStates[,] Playfield = new PositionStates[playfieldWidth, playfieldHeight];

        public Board()
        {
            for (int i = 0; i < playfieldWidth; i++)
            {
                for (int j = 0; j < playfieldHeight; j++)
                {
                    Playfield[i, j] = PositionStates.empty;
                }
            }
        }


    }
}
