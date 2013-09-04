using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


class CrazyRusher
{
    
    static void Main()
    {
        Console.CursorVisible = false;
        GameField matrix = new GameField();
        DateTime saveStartTime = DateTime.Now;

        GameID.PrintGameName();
        GameField.DrawBorderLines();
        for (int i = 0; i < 7; i++)
        {
            GameField.EnemyCoordinates(matrix);

        }
        while (true)
        {
            DrawInitialGameField(matrix);
            Player.MovePlayer(matrix);
            Enemy.MoveEnemies(matrix);
            
        }
    }

    static void DrawInitialGameField(GameField matrix)
    {
        GameField.SetConsoleDimensions();
        GameField.SetMatrixContent(matrix);
        GameField.PlayerCoordinates(matrix);
        GameField.PrintMatrix(matrix);
        
    }


}
