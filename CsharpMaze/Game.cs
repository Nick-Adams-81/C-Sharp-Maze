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

        private void displayIntro()
        {
            WriteLine("Welcome to the maze!!");
            WriteLine("\nInstructions");
            WriteLine("> Use arrow keys to move");
            Write("> Try to reach the goal, which looks like this: ");
            ForegroundColor = ConsoleColor.Green;
            WriteLine("X");
            WriteLine("Press any key to start");
            ReadKey(true);
        }

        private void displayOutro()
        {
            Clear();
            WriteLine("You got out of the maze!");
            WriteLine("Thanks for playing!!!");
            WriteLine("Press any key to exit");
            ReadKey(true);
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
