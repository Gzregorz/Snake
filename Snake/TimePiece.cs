using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    public class TimePiece
    {
        public bool exit = false;
        public int time = 0;
        public int timePiece()
        {
            time++;
            return (time);
        }
    }
}
