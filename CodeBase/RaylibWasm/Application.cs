using System.Runtime.InteropServices.JavaScript;
using Raylib_cs;
using RayGUI;
using System;

namespace RaylibWasm
{
    public partial class Application
    {
        private static Texture2D logo;
        private static Rectangle rect = new Rectangle(100 ,100 ,100 ,100);

        
        /// <summary>
        /// Application entry point
        /// </summary>
        public static void Main()
        {
            Raylib.InitWindow(512, 512, "RaylibWasm");
            Raylib.SetTargetFPS(60);
            
            logo = Raylib.LoadTexture("Resources/raylib_logo.png");
        }

        /// <summary>
        /// Updates frame
        /// </summary>
        [JSExport]
        public static void UpdateFrame()
        {
            Raylib.BeginDrawing();

            Raylib.ClearBackground(Color.White);

            Raylib.DrawFPS(4, 4);
            Raylib.DrawText("All systems operational!", 4, 32, 20, Color.Maroon);
            if (RayGui.GuiButton(rect, "Hallo"))
            {
                Console.WriteLine("Button is press");
            }

            Raylib.DrawTexture(logo, 4, 64, Color.White);

            Raylib.EndDrawing();
        }
    }
}
