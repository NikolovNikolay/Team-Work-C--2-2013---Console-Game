using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class Enemy
{
    public static ConsoleColor enemyColor = ConsoleColor.Magenta;
    static Random generator = new Random();
    public static int enemyRow;
    public static int enemyCol;

    static char enemyChar = '?';
    public static List<List<int>> enemyCoords = new List<List<int>>();

    public static void SetEnemyCoordinates(GameField matrix)
    {
        enemyRow = generator.Next(2, 21);
        enemyCol = generator.Next(1,21);
        if (matrix[enemyRow, enemyCol] != '#' && matrix[enemyRow, enemyCol] != Player.playerChar)
        {
            matrix[enemyRow, enemyCol] = enemyChar;
        }

        enemyCoords.Add((new int[] { enemyRow, enemyCol }).ToList());
    }
    public static int listiIndex =0;
    public static void MoveEnemies(GameField matrix)
    {
        for (int i = 0; i < enemyCoords.Count; i++)
        {
            int direction = generator.Next(1, 5); // 1 - left; 2 - right; 3 - up; 4 - down;
            int row = enemyCoords[i][0];
            int col = enemyCoords[i][1];
            listiIndex = i;
            if (direction == 1)
            {
                if (matrix[row, col - 1] != GameField.wallChar && col - 1 >= 1)
                {
                    matrix[row, col] = ' ';
                    matrix[row, col - 1] = enemyChar;
                    enemyCoords[i][1] = col - 1;
                }
            }
            else if (direction == 2)
            {
                if (matrix[row, col + 1] != GameField.wallChar && col + 1 < matrix.Cols - 1)
                {
                    matrix[row, col] = ' ';
                    matrix[row, col + 1] = enemyChar;
                    enemyCoords[i][1] = col + 1;
                }
            }
            else if (direction == 3)
            {
                if (matrix[row - 1, col] != GameField.wallChar && row - 1 >= 1)
                {
                    matrix[row, col] = ' ';
                    matrix[row - 1, col] = enemyChar;
                    enemyCoords[i][0] = row - 1;
                }
            }
            else if (direction == 4)
            {
                if (row + 1 < matrix.Rows - 1 && matrix[row + 1, col] != GameField.wallChar)
                {
                    matrix[row, col] = ' ';
                    matrix[row + 1, col] = enemyChar;
                    enemyCoords[i][0] = row + 1;
                }
            }
         }  
    }

}
