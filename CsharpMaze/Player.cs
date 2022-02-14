using System;
using static System.Console;
namespace CsharpMaze
{
    public class Player
    {

        public int x { get; set; }
        public int y { get; set; }
        private string PlayerMarker;
        private ConsoleColor PlayerColor;


        public Player(int initX, int initY)
        {
            x = initX;
            y = initY;
            PlayerMarker = "O";
            PlayerColor = ConsoleColor.Red;

        }


        public void Draw()
        {
            ForegroundColor = PlayerColor;
            SetCursorPosition(x, y);
            Write(PlayerMarker);
            ResetColor();
        }
    }
}
