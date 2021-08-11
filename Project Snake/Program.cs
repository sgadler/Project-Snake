using System;
using System.Threading;
using System.Collections.Generic;
using Raylib_cs;

namespace Project_Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int screenHeight = 750;
            int screenWidth = 750;

            Raylib.InitWindow(screenHeight,screenWidth, "Snake");

            while(!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);

                Raylib.DrawText("Snake", 225,250,100,Color.BLACK);

                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}
