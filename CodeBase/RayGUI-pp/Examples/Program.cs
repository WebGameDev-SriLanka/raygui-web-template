
using System.Numerics;
using RayGUI;
using Raylib_cs;
using Example;

bool previousState = ToggleParams.isTriggered;
Raylib.InitWindow(WindowParams.screenWidth, WindowParams.screenHeight, WindowParams.title);
Raylib.SetTargetFPS(WindowParams.fps);

while (!Raylib.WindowShouldClose())
{
    Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.RayWhite);
        if (RayGui.GuiButton(new Rectangle(new Vector2(10, 10), new Vector2(200, 100)), "button"))
        {
            Console.WriteLine("Button was Clicked");   
        }

        if (RayGui.GuiToggle(new Rectangle(new Vector2(220, 10), new Vector2(100, 100)), "isTriggered", ref ToggleParams.isTriggered))
        {
            if (previousState != ToggleParams.isTriggered)
            {
                if (ToggleParams.isTriggered == true)
                {
                    Console.WriteLine("Toggle Button: This is True");
                }
                else
                {
                    Console.WriteLine("Toggle Button: This is False");
                }   
            }
        }
    Raylib.EndDrawing();
}

Raylib.CloseWindow();