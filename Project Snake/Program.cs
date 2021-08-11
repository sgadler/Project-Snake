using System;
using System.Threading;
using System.Collections.Generic;
using System.Collections;
using Raylib_cs;

namespace Project_Snake
{
    class Program
    {

        public static int screenHeight = 750;
        public static int screenWidth = 750;
        static void Main(string[] args)
        {

            Raylib.InitWindow(screenHeight,screenWidth, "Snake");

            while(!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);

                int heightStart = (screenWidth/2 - 250);
                int widthStart = 550;
                int heightQuit = (screenWidth/2 + 110);
                int widthQuit = 550;

                Raylib.DrawText("Snake", 225,250,100,Color.BLACK);
                Raylib.DrawRectangle(heightStart, widthStart, 160, 80,Color.GREEN);
                Raylib.DrawRectangle(heightQuit, widthQuit, 160, 80,Color.RED);
                Raylib.DrawText("Start(A)",screenWidth/2 - 250, 550,50,Color.BLACK);
                Raylib.DrawText("Quit(D)",screenWidth/2 + 110,550,50,Color.BLACK);

                Raylib.EndDrawing();

                if(Raylib.IsKeyPressed(KeyboardKey.KEY_A) == true)
                {
                    Raylib.CloseWindow();
                    SnakeGame();
                }
                if(Raylib.IsKeyPressed(KeyboardKey.KEY_D) == true)
                {
                    System.Environment.Exit(1);
                }
            }

            Raylib.CloseWindow();
        }

        static void SnakeGame()
        {
            Raylib.InitWindow(screenHeight,screenWidth,"SnakeGame");

            while(!Raylib.WindowShouldClose())
            {
            Raylib.BeginDrawing();

            Raylib.ClearBackground(Color.GREEN);
            Raylib.DrawText("Get Rekt", 1,1,100,Color.PINK);

            Raylib.EndDrawing();
            }
        }
    }
}
