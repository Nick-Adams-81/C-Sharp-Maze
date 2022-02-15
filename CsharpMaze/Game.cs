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
                    if(myWorld.positionWalkable(myPlayer.x, myPlayer.y - 1))
                    {
                        myPlayer.y -= 1;
                    }
                    
                    break;
                case ConsoleKey.DownArrow:
                    if(myWorld.positionWalkable(myPlayer.x, myPlayer.y + 1))
                    {
                        myPlayer.y += 1;
                    }
                    
                    break;
                case ConsoleKey.LeftArrow:
                    if(myWorld.positionWalkable(myPlayer.x - 1, myPlayer.y))
                    {
                        myPlayer.x -= 1;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if(myWorld.positionWalkable(myPlayer.x + 1, myPlayer.y))
                    {
                         myPlayer.x += 1;
                    }

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
                string elemntAtPlayerPos = myWorld.getElementAt(myPlayer.x, myPlayer.y);
                if(elemntAtPlayerPos == "X")
                {
                    break;
                }
                

                System.Threading.Thread.Sleep(20);


               
            }
        }
   
    }
}
