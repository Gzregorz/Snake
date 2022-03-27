using System;
using System.Threading;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false; 

            TimePiece timer = new TimePiece();
      
            // drawing map
            Map map = new Map();
            map.drawingMap();

            SnakeOne snakeOne = new SnakeOne();
            snakeOne.startSnakeOne();
            SnakeTwo snakeTwo = new SnakeTwo();
            snakeTwo.startSnakeTwo();

            // menu start
            Console.SetCursorPosition(32, 13);
            Console.Write("You want to play? y/n");
            if (Console.ReadKey(true).KeyChar == 'n') { timer.exit = true; }
            if (Console.ReadKey(true).KeyChar == 'y') 
            {
                Console.SetCursorPosition(32, 13);
                Console.Write("                     ");
                for (int a = 3; a >= 0; a--)
                {
                    if (a > 0)
                    {
                        Console.SetCursorPosition(39, 13);
                        Console.Write(a);
                        Thread.Sleep(400);
                    }
                    if (a == 0)
                    {
                        Console.SetCursorPosition(34, 13);
                        Console.Write("START !!!");
                        Thread.Sleep(350);
                    }
                }
            }              
            Console.SetCursorPosition(34, 13);
            Console.Write("         ");

            // game loop 
            while (!timer.exit && !snakeTwo.exitTwo && !snakeOne.exitOne)
            {         
                if (Console.KeyAvailable) 
                {
                    ConsoleKeyInfo klawisz = Console.ReadKey();
                    if (klawisz.Key == ConsoleKey.Escape) { timer.exit = true; }
                    if (snakeOne.cOne != 1 && klawisz.Key == ConsoleKey.LeftArrow) { snakeOne.cOne = 3; }
                    if (snakeOne.cOne != 3 && klawisz.Key == ConsoleKey.RightArrow) { snakeOne.cOne = 1; }
                    if (snakeOne.cOne != 4 && klawisz.Key == ConsoleKey.UpArrow) { snakeOne.cOne = 2; }
                    if (snakeOne.cOne != 2 && klawisz.Key == ConsoleKey.DownArrow) { snakeOne.cOne = 4; }
                    if (snakeTwo.cTwo != 1 && klawisz.Key == ConsoleKey.A) { snakeTwo.cTwo = 3; }
                    if (snakeTwo.cTwo != 3 && klawisz.Key == ConsoleKey.D) { snakeTwo.cTwo = 1; }
                    if (snakeTwo.cTwo != 4 && klawisz.Key == ConsoleKey.W) { snakeTwo.cTwo = 2; }
                    if (snakeTwo.cTwo != 2 && klawisz.Key == ConsoleKey.S) { snakeTwo.cTwo = 4; }
                }

                snakeOne.bodySnakeOne();
                snakeTwo.bodySnakeTwo();

                // collision of two snakes
                for (int i = 0; i < snakeTwo.xTwo.Count - 2; i++)
                {
                    if (snakeOne.xOne[snakeOne.xOne.Count - 1] == snakeTwo.xTwo[i] &&
                        snakeOne.yOne[snakeOne.xOne.Count - 1] == snakeTwo.yTwo[i])
                    { Console.WriteLine(" Palyer TWO won !!!"); timer.exit = true; break; }

                }
                for (int i = 0; i < snakeOne.xOne.Count - 2; i++)
                {
                    if (snakeTwo.xTwo[snakeTwo.xTwo.Count - 1] == snakeOne.xOne[i] &&
                        snakeTwo.yTwo[snakeTwo.xTwo.Count - 1] == snakeOne.yOne[i])
                    { Console.WriteLine(" Player ONE won !!!"); timer.exit = true; break; }

                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(86, 2);
                Console.WriteLine("KEYBOARD CONTROLS:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(86, 3);
                Console.WriteLine("Player One:");
                Console.SetCursorPosition(86, 4);
                Console.WriteLine("Up Arrow    -> Up");
                Console.SetCursorPosition(86, 5);
                Console.WriteLine("Right Arrow -> Right");
                Console.SetCursorPosition(86, 6);
                Console.WriteLine("Down Arrow  -> Down");
                Console.SetCursorPosition(86, 7);
                Console.WriteLine("Left Arrow  -> Left");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(86, 8);
                Console.WriteLine("Player Two:");
                Console.SetCursorPosition(86, 9);
                Console.WriteLine("W -> Up");
                Console.SetCursorPosition(86, 10);
                Console.WriteLine("D -> Right");
                Console.SetCursorPosition(86, 11);
                Console.WriteLine("S -> Down");
                Console.SetCursorPosition(86, 12);
                Console.WriteLine("A -> Left");

                Thread.Sleep(50);          
            }
        }
    }
}
