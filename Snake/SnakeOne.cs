using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    public class SnakeOne : TimePiece
    {
        public bool exitOne = false;
        public int aOne = 6, bOne = 13, cOne = 1;
        private int i;

        public List<int> xOne = new List<int>();
        public List<int> yOne = new List<int>();
        public void startSnakeOne()
        {
            xOne.Add(6);
            yOne.Add(13);
        }
        public void bodySnakeOne()
        {
            Console.SetCursorPosition(xOne[0], yOne[0]);
            Console.Write(" ");

            if (cOne == 1) { aOne++; }
            if (cOne == 2) { bOne--; }
            if (cOne == 3) { aOne--; }
            if (cOne == 4) { bOne++; }

            // enlarging the snake
            if (timePiece() % 2 == 0 && timePiece() > 0)
            { xOne.Add(aOne); yOne.Add(bOne); } 

            for (i = 0; i < xOne.Count; i++)
            {
                if (i < xOne.Count - 1) { xOne[i] = xOne[i + 1]; yOne[i] = yOne[i + 1]; }
                if (i == xOne.Count - 1) { xOne[i] = aOne; yOne[i] = bOne; }
            }

            for (i = 0; i < xOne.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(xOne[i], yOne[i]);
                Console.Write("*");
            }

            // collision with your own body
            for (i = 0; i < xOne.Count - 2; i++)
            {
                if (xOne[xOne.Count - 1] == xOne[i] && yOne[xOne.Count - 1] == yOne[i])
                { Console.WriteLine(" Palyer TWO won !!!"); exitOne = true; break; }
            }

            // collision with the map
            if (xOne[xOne.Count - 1] >= 80 || xOne[xOne.Count - 1] <= 5 ||
                yOne[xOne.Count - 1] >= 26 || yOne[xOne.Count - 1] <= 2)
            { Console.WriteLine("Player TWO won !!!"); exitOne = true; }
        }
    }
}






