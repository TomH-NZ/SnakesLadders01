using System.Collections.Generic;

namespace SnakesLaddersKata0


{
    public class SnakesLadders
    {
        private int playerOneLocation = 0;
        private int playerTwoLocation = 0;
        private int turnCount = 0;
        
        public string play (int die1, int die2)
        {
            var board = new Dictionary<int, int>()
            {
                {2, 38},
                {7, 14},
                {8, 31},
                {15, 26},
                {16, 6},
                {21, 42},
                {28, 84},
                {36, 44},
                {46, 25},
                {49, 11},
                {51, 67},
                {62, 19},
                {64, 60},
                {71, 91},
                {74, 53},
                {78, 98},
                {87, 94},
                {89, 68},
                {92, 88},
                {95, 75},
                {99, 80}
            };
            
            
            
            return "Player move";
        }
        
        
    }
}
// add player move, 