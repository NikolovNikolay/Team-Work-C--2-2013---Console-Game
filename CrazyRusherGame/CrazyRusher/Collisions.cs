using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Collisions
{
    public static void EnemyShot(GameField matrix, List<List<int>> enemyCoords, int i)
    {
        if ((Player.row - 1 == '|' && Enemy.enemyRow == Player.row - 1 && Enemy.enemyCol == Player.col)) //|| 
            //(Player.row - 2 == '|' && Enemy.enemyRow == Player.row - 2 && Enemy.enemyCol == Player.col))
        {
            matrix[Enemy.enemyRow, Enemy.enemyCol] = ' ';
            enemyCoords.RemoveAt(i);
        }
        else if ((Player.row + 1 == '|' && Enemy.enemyRow == Player.row + 1 && Enemy.enemyCol == Player.col) ||
            (Player.row + 2 == '|' && Enemy.enemyRow == Player.row + 2 && Enemy.enemyCol == Player.col))
        {
            matrix[Enemy.enemyRow, Enemy.enemyCol] = ' ';
            enemyCoords.RemoveAt(i);
        }
        else if ((Player.col + 1 == '-' && Enemy.enemyCol == Player.col + 1 && Enemy.enemyRow == Player.row) ||
            (Player.col + 2 == '-' && Enemy.enemyCol == Player.col + 2 && Enemy.enemyCol == Player.col))
        {
            matrix[Enemy.enemyRow, Enemy.enemyCol] = ' ';
            enemyCoords.RemoveAt(i);
        }
        else if ((Player.col - 1 == '-' && Enemy.enemyCol == Player.col - 1 && Enemy.enemyRow == Player.row) ||
            (Player.col - 2 == '-' && Enemy.enemyCol == Player.col - 2 && Enemy.enemyCol == Player.col))
        {
            matrix[Enemy.enemyRow, Enemy.enemyCol] = ' ';
            enemyCoords.RemoveAt(i);
        }
    }
}