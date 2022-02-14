﻿using System;
using static System.Console;
namespace CsharpMaze
{
    public class World
    {

        private string[,] Grid;
        private int rows;
        private int cols;


        public World(string[,] grid)
        {

            Grid = grid;
            rows = Grid.GetLength(0);
            cols = grid.GetLength(1);

        }

        public void Draw()
        {
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    string el = Grid[i, j];
                    SetCursorPosition(j, i);
                    Write(el);
                }
            }
        }           


        
    }
}
