using System;
using Raylib_cs;

namespace Snöflingor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialisering
            //--------------------------------------------------------------------------------------
            const int fönsterB = 800;
            const int fönsterH = 600;

            Raylib.InitWindow(fönsterB, fönsterH, "Snöflingor");
            Raylib.SetTargetFPS(60);

            // Skapa en snöflinga
            Random generator = new Random();

            // Array [] för många snöflingor
            Rectangle[] flingor = new Rectangle[100];

            // Loopa igenom arrayen och fyll med snöflingor
            for (int i = 0; i < flingor.Length; i++)
            {
                flingor[i] = new Rectangle(0, 0, 10, 10);
                flingor[i].x = generator.Next(0, fönsterB);
                flingor[i].y = generator.Next(0, fönsterH) - fönsterH;
            }

            // Array [] för snöflingornas fallhastighet
            int[] hastigheter = new int[100];

            // Loopa igenom arrayen och fyll i snöflingornas hastighet
            for (int i = 0; i < flingor.Length; i++)
            {
                hastigheter[i] = generator.Next(1, 6);
            }
            //--------------------------------------------------------------------------------------

            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                // Updatering
                //----------------------------------------------------------------------------------
                for (int i = 0; i < flingor.Length; i++)
                {
                    flingor[i].y += hastigheter[i];
                    if (flingor[i].y > fönsterH)
                    {
                        flingor[i].y = 0;
                    }
                }

                //----------------------------------------------------------------------------------

                // Rita
                //----------------------------------------------------------------------------------
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.DARKBLUE);

                for (int i = 0; i < flingor.Length; i++)
                {
                    Raylib.DrawRectangleRec(flingor[i], Color.WHITE);
                }

                Raylib.EndDrawing();
                //----------------------------------------------------------------------------------
            }
        }
    }
}