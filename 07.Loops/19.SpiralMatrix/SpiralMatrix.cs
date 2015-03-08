﻿using System;
class SpiralMatrix
{
    static void Main()
    {
        Console.Write("Input integer number: ");
        int n = int.Parse(Console.ReadLine());

        if (n >= 1 && n <= 20)
        {
            int[,] matrix = new int[n,n];
            int row = 0;
            int col = 0;
            string direction = "right";
            int maxRotations = n * n;

            for (int i = 1; i <= n * n; i++)
            {
                if (direction == "right" && (col > n - 1 || matrix[row, col] != 0))
                {
                    direction = "down";
                    col--;
                    row++;
                }
                if (direction == "down" && (row > n - 1 || matrix[row, col] != 0))
                {
                    direction = "left";
                    row--;
                    col--;
                }
                if (direction == "left" && (col < 0 || matrix[row, col] != 0))
                {
                    direction = "up";
                    col++;
                    row--;
                }
                if (direction == "up" && (row < 0 || matrix[row, col] != 0))
                {
                    direction = "right";
                    row++;
                    col++;
                }

                matrix[row, col] = i;

                switch (direction)
                {
                    case "right":
                        col++;
                        break;
                    case "down":
                        row++;
                        break;
                    case "left":
                        col--;
                        break;
                    case "up":
                        row--;
                        break;
                }
            }

            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write("{0,5}", matrix[r, c]);
                }
                Console.WriteLine();
            }
        }
    }
}