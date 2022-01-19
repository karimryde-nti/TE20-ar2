using System;
using Raylib_cs;

namespace Bilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Starta grafikmotorn
            Raylib.InitWindow(800, 600, "Mitt Raylib fönster");

            // Bestäm skärmuppdatering
            Raylib.SetTargetFPS(60);

            // Skapa en spelare av en rektangel
            Rectangle spelare = new Rectangle(100, 100, 64, 64);
            
            // Ladda bild för spelaren
            Texture2D ufo = Raylib.LoadTexture(@"./resurser/ufo.png");

            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                /* Rita ut grafiken */
                // Börja rita
                Raylib.BeginDrawing();

                // Töm ritytan
                Raylib.ClearBackground(Color.DARKBLUE);

                // Rita ut spelarens bild istället för rektangeln
                Raylib.DrawTexture(ufo, (int)spelare.x, (int)spelare.y, Color.WHITE);
            
                // Ritat ut på fönstret
                Raylib.EndDrawing();

                /* Interaktion med användaren */
                // Lyssna på tangenter
                if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
                {
                    spelare.x += 4;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
                {
                    spelare.x -= 4;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
                {
                    spelare.y += 4;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
                {
                    spelare.y -= 4;
                }
            }
        }
    }
}
