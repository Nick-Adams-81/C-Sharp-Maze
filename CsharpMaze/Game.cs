using System;
using static System.Console;
namespace CsharpMaze
{
    public class Game
    {
       

           public void Start()
            {
   
            //SetCursorPosition(4, 2);
            //Write("X");


            string[,] grid =
            {
               { "=", "=", "=", "=", "=", "=", "=" },
               { "=", " ", "=", " ", " ", " ", "X" },
               { "O", " ", "=", " ", "=", " ", "=" },
               { "=", " ", "=", " ", "=", " ", "=" },
               { "=", " ", " ", " ", "=", " ", "=" },
               { "=", "=", "=", "=", "=", "=", "=" }
            };

            World world = new World(grid);
            world.Draw();

            WriteLine("\n\npress any key top exit...");

            ReadKey(true);
            }
   
    }
}
