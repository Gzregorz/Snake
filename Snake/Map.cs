using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    public class Map
    {
        private int xx, yy;
        public void drawingMap()
        {
            for (xx = 5; xx <= 80; xx++)
            {
                yy = 2;
                Console.SetCursorPosition(xx, yy);
                Console.Write("X");
            }
            for (xx = 5; xx <= 80; xx++)
            {
                yy = 26;
                Console.SetCursorPosition(xx, yy);
                Console.Write("X");
            }
            for (yy = 2; yy <= 26; yy++)
            {
                xx = 5;
                Console.SetCursorPosition(xx, yy);
                Console.Write("X");
            }
            for (yy = 2; yy <= 25; yy++)
            {
                xx = 80;
                Console.SetCursorPosition(xx, yy);
                Console.Write("X");
            }
        }
    }
}
