using System;
using Raylib_cs;

namespace Grunder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej Raylib!");

            // Starta ett fönster
            Raylib.InitWindow(800, 600, "Ett Raylib fönster");

            // Ställ in fps
            Raylib.SetTargetFPS(60);

            // En egen färg
            Color GoldenRod = new Color(218, 165, 32, 170);

            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                // Börja rita
                Raylib.BeginDrawing();

                // Tömma ritytan
                Raylib.ClearBackground(Color.DARKBLUE);

                // Rita en fyrkant
                Raylib.DrawRectangle(100, 100, 200, 100, Color.RED);
                Raylib.DrawRectangle(200, 200, 200, 100, Color.GREEN);

                // Rita en cirkel
                Raylib.DrawCircle(400, 300, 100, GoldenRod);

                // Rita text
                Raylib.DrawText("Det här är en cirkel", 100, 500, 50, Color.RED);

                // Sluta rita
                Raylib.EndDrawing();
            }
        }
    }
}
