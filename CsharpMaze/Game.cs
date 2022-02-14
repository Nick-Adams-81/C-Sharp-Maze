using System;
using static System.Console;
namespace CsharpMaze
{
    public class Game
    {
       

           public void Start()
            {
   
      

            string[,] grid =
            {
               { "=", "=", "=", "=", "=", "=", "=" },
               { "=", " ", "=", " ", " ", " ", "X" },
               { " ", " ", "=", " ", "=", " ", "=" },
               { "=", " ", "=", " ", "=", " ", "=" },
               { "=", " ", " ", " ", "=", " ", "=" },
               { "=", "=", "=", "=", "=", "=", "=" }
            };

            World world = new World(grid);
            world.Draw();

            Player player = new Player(0, 2);
            player.Draw();


            //WriteLine("\n\npress any key top exit...");

            ReadKey(true);
            }
   
    }
}
