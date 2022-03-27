using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    public class SnakeTwo : TimePiece
    {
         public bool exitTwo = false;
         public int aTwo = 6, bTwo = 15, cTwo = 1;
         private int i;

         public List<int> xTwo = new List<int>();
         public List<int> yTwo = new List<int>();
         public void startSnakeTwo()
         {
                xTwo.Add(6);
                yTwo.Add(15);
         }
         public void bodySnakeTwo()
         {
                Console.SetCursorPosition(xTwo[0], yTwo[0]);
                Console.Write(" ");

                if (cTwo == 1) { aTwo++; }
                if (cTwo == 2) { bTwo--; }
                if (cTwo == 3) { aTwo--; }
                if (cTwo == 4) { bTwo++; }

                // enlarging the snake
                if (timePiece() % 2 == 0 && timePiece() > 0)
                { xTwo.Add(aTwo); yTwo.Add(bTwo); } 

                for (i = 0; i < xTwo.Count; i++)
                {
                    if (i < xTwo.Count - 1) { xTwo[i] = xTwo[i + 1]; yTwo[i] = yTwo[i + 1]; }
                    if (i == xTwo.Count - 1) { xTwo[i] = aTwo; yTwo[i] = bTwo; }
                }

                for (i = 0; i < xTwo.Count; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(xTwo[i], yTwo[i]);
                    Console.Write("*");
                }

                 // collision with your own body
                for (i = 0; i < xTwo.Count - 2; i++)
                {
                    if (xTwo[xTwo.Count - 1] == xTwo[i] && yTwo[xTwo.Count - 1] == yTwo[i])
                    { Console.WriteLine(" Player ONE win !!!"); exitTwo = true; break; }               
                }

                // collision with the map
                if (xTwo[xTwo.Count - 1] >= 80 || xTwo[xTwo.Count - 1] <= 5 ||
                    yTwo[xTwo.Count - 1] >= 26 || yTwo[xTwo.Count - 1] <= 2)
                { Console.WriteLine(" Player ONE win !!!"); exitTwo = true; }
         }
    }
}


