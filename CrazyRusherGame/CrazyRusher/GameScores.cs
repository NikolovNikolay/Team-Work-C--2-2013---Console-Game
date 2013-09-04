using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class GameScores
{                       //shooting bad guys scores = true, eaten by bad guys = false;  CALL FROM COLLISION
    static void CollisionScores(bool ShootedOREaten, DateTime saveStartTime) // saveStartTime is needed here to calculate the elapsed time when the game is over
    {
        int scores = 0;
        int lives = 3;

        if (ShootedOREaten == true)
        {
            scores += 10;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(7, 49);
            Console.Write("Score: {0}", scores);
        }

        else
        {
            lives--;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(9, 49);
            Console.Write("Lives: {0}", lives);
        }

        if (lives == 0)
        {
            DateTime saveFinishTime = DateTime.Now;
            GameOver();
            int elapsed = CalculateTimeElapsed(saveStartTime, saveFinishTime);
            WriteHiScoresHistory(scores, elapsed);
        }
    }

    static void GameOver()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Red;

        Console.SetCursorPosition(Console.WindowWidth / 2 - 4, Console.WindowHeight / 2);
        Console.WriteLine("GAME OVER");

    }

    static int CalculateTimeElapsed(DateTime saveStartTime, DateTime saveFinishTime)
    {
        int startTime = saveStartTime.Second;
        int finishTime = saveFinishTime.Second;
        int elapsed = finishTime - startTime;
        return elapsed;
    }

    static void WriteHiScoresHistory(int scores, int elapsed)
    {
        Console.SetCursorPosition(20, 0);
        Console.CursorVisible = true;
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        string path = @"C:\Users\DESISLAVA\Desktop\Scores.txt";

        StreamWriter hiScores = File.AppendText(path);
        int scoresInFile = scores * (1000 - elapsed);
        using (hiScores)
        {
            Console.WriteLine();
            hiScores.Write(name);
            hiScores.Write("            {0}", elapsed);
            hiScores.WriteLine("            {0}", scoresInFile);
        }


        string line = "";
        using (StreamReader displayHiScores = File.OpenText(path))
        {
            while ((line = displayHiScores.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
