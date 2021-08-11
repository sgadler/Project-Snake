using System;
using System.Threading;
using System.Collections.Generic;
using System.Collections;
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

                int heightStart = (screenWidth/2 - 250);
                int widthStart = 550;
                int heightQuit = (screenWidth/2 + 110);
                int widthQuit = 550;

                Raylib.DrawText("Snake", 225,250,100,Color.BLACK);
                Raylib.DrawRectangle(heightStart, widthStart, 160, 80,Color.GREEN);
                Raylib.DrawRectangle(heightQuit, widthQuit, 160, 80,Color.RED);
                Raylib.DrawText("Start",screenWidth/2 - 250, 550,50,Color.BLACK);
                Raylib.DrawText("Quit",screenWidth/2 + 110,550,50,Color.BLACK);

                if(Raylib.CheckCollisionPointRec(Raylib.GetMousePosition,))
                {

                }


                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}
