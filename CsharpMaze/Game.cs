using System;
using static System.Console;
namespace CsharpMaze
{
    public class Game
    {

        private World myWorld;
        private Player myPlayer;
       

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

            myWorld = new World(grid);
            
            myPlayer = new Player(0, 2);

            RunGameLoop();
          
            }

        private void DrawFrame()
        {
            Clear();
            myWorld.Draw();
            myPlayer.Draw();
        }
         
        private void HandlePlayerInput()
        {
            ConsoleKeyInfo keyInfo = ReadKey(true);
            ConsoleKey key = keyInfo.Key;
            switch(key)
            {
                case ConsoleKey.UpArrow:
                    myPlayer.y -= 1;
                    break;
                case ConsoleKey.DownArrow:
                    myPlayer.y += 1;
                    break;
                case ConsoleKey.LeftArrow:
                    myPlayer.x -= 1;
                    break;
                case ConsoleKey.RightArrow:
                    myPlayer.x += 1;
                    break;
                default: break;
            }
        }


        private void RunGameLoop()
        {
            while (true)
            {
                DrawFrame();
                HandlePlayerInput();

                System.Threading.Thread.Sleep(20);


                break;
            }
        }
   
    }
}
