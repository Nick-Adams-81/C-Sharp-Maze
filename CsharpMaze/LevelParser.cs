using System;
using System.IO;
namespace CsharpMaze
{
    public class LevelParser
    {
       public static string[,] ParseFileToArray(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            string firstLine = lines[0];
            int rows = lines.Length;
            int cols = firstLine.Length;
            string[,] grid = new string[rows, cols];

            for(int i = 0; i < rows; i++)
            {
                string line = lines[i];
                for(int j = 0; j < cols; j++)
                {
                    char currentChar = line[j];
                    grid[i, j] = currentChar.ToString();
                }
            }

            return grid;
        }
    }
}
