﻿using System;
using Raylib_cs;

namespace Kollision
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initiera grafikmotorn
            Raylib.InitWindow(800, 600, "Mitt Raylib fönster");
            Raylib.SetTargetFPS(60);

            // Några variabler
            int hastighet = 5;
            Random generator = new Random();
            int poäng = 0;
            int timer = 0;

            /* Skapa objekt */
            Rectangle spelare = new Rectangle(100, 100, 50, 50);
            // Spawna fram en startposition med slump
            Rectangle fiende = new Rectangle(
                generator.Next(400, 720),
                generator.Next(0, 520),
                80, 80);

            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                // Räkna antalet frames
                timer++;

                /* Rita ut grafiken */
                // Börja rita
                Raylib.BeginDrawing();

                // Avbryt spelet efter 60 sek
                if (timer > 1000)
                {
                    Raylib.ClearBackground(Color.DARKBLUE);
                    Raylib.DrawText("Game Over", 100, 200, 100, Color.GOLD);
                    
                    // Ritat ut på fönstret
                    Raylib.EndDrawing();
                }
                else
                {
                    Raylib.ClearBackground(Color.DARKBLUE);

                    // Rita ut objekt
                    Raylib.DrawRectangleRec(fiende, Color.BLACK);
                    Raylib.DrawRectangleRec(spelare, Color.RED);

                    // Visa poängen
                    Raylib.DrawText($"Tid {timer/10} Poäng {poäng}", 400, 50, 50, Color.GOLD);

                    // Upptäcka kollision
                    if (Raylib.CheckCollisionRecs(spelare, fiende))
                    {
                        poäng++;

                        // Spawna om fiende med slump
                        fiende.x = generator.Next(400, 720);
                        fiende.y = generator.Next(0, 520);
                    }

                    // Ritat ut på fönstret
                    Raylib.EndDrawing();

                    /* Interaktion med användare */
                    // Lyssna på tangenter
                    if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
                    {
                        spelare.x += hastighet;
                    }
                    if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
                    {
                        spelare.x -= hastighet;
                    }
                    if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
                    {
                        spelare.y += hastighet;
                    }
                    if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
                    {
                        spelare.y -= hastighet;
                    }
                }

            }
        }
    }
}
