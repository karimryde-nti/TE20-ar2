using System;
using Raylib_cs;

namespace Dodgers
{
    class Program
    {
        static int fönsterB = 800;
        static int fönsterH = 600;
        static Random generator = new Random();
        static Rectangle mynt1 = new Rectangle(400, 0, 50, 50);
        static Rectangle mynt2 = new Rectangle(400, 0, 50, 50);
        static Rectangle monster = new Rectangle(400, 0, 50, 50);
        static Rectangle spelare = new Rectangle(100, fönsterH - 50, 100, 10);
        static int poäng = 0;
        static int liv = 3;

        static void Main(string[] args)
        {
            // Initialisering
            //--------------------------------------------------------------------------------------

            Raylib.InitWindow(fönsterB, fönsterH, "Dodgers");
            Raylib.SetTargetFPS(60);

            // Game state variabler
            float tid = 0;
            int hastighet = 1;

            //--------------------------------------------------------------------------------------

            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                // Updatering
                //----------------------------------------------------------------------------------
                // Räkna upp tiden
                tid += Raylib.GetFrameTime();
                if (tid >= 30)
                {
                    hastighet = 2;
                }

                // Hastigheter och nedre gräns
                Hastigheter(hastighet);

                // Lyssna på tangenter
                Input();

                // Kollisioner
                Kollisioner();
                //----------------------------------------------------------------------------------

                // Rita
                //----------------------------------------------------------------------------------
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.DARKBLUE);

                Raylib.DrawRectangleRec(mynt1, Color.GOLD);
                Raylib.DrawRectangleRec(mynt2, Color.GOLD);
                Raylib.DrawRectangleRec(monster, Color.RED);
                Raylib.DrawRectangleRec(spelare, Color.WHITE);
                Raylib.DrawText($"Poäng:{poäng} Liv:{liv} Tid:{(int)tid}", 10, 10, 20, Color.YELLOW);

                Raylib.EndDrawing();
                //----------------------------------------------------------------------------------
            }
        }

        static void Input()
        {
            if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
            {
                if (spelare.x > 0)
                {
                    spelare.x -= 3;
                }
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
            {
                if (spelare.x < fönsterB - 100)
                {
                    spelare.x += 3;
                }
            }
        }

        static void Hastigheter(int hastighet)
        {
            mynt1.y += hastighet;
            if (mynt1.y > fönsterH)
            {
                mynt1.y = -100;
                mynt1.x = generator.Next(0, fönsterB);
            }
            mynt2.y += hastighet;
            if (mynt2.y > fönsterH)
            {
                mynt2.y = -100;
                mynt2.x = generator.Next(0, fönsterB);
            }
            monster.y += hastighet;
            if (monster.y > fönsterH)
            {
                monster.y = -100;
                monster.x = generator.Next(0, fönsterB);
            }
        }

        static void Kollisioner()
        {
            // Om spelaren träffar ett mynt
            if (Raylib.CheckCollisionRecs(spelare, mynt1))
            {
                mynt1.y = 0;
                mynt1.x = generator.Next(0, fönsterB);
                poäng += 5;
            }
            if (Raylib.CheckCollisionRecs(spelare, mynt2))
            {
                mynt2.y = 0;
                mynt2.x = generator.Next(0, fönsterB);
                poäng += 5;
            }
            // Om spelaren träffar ett monster
            if (Raylib.CheckCollisionRecs(spelare, monster))
            {
                monster.y = 0;
                monster.x = generator.Next(0, fönsterB);
                liv--;
            }
        }
    }
}
