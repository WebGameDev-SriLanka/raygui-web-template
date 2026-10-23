using System.Runtime.InteropServices.JavaScript;
using Raylib_cs;
using RayGUI;
using System;

namespace RaylibWasm
{
    public partial class Application
    {
        private static Texture2D logo;

        // Gui Slider Params
        private static Rectangle sliderRect = new Rectangle(100, 250, 120, 70);
        private static float sliderValue = 0.5f;

        // Gui TextBox Params
        private static Rectangle textBoxRect = new Rectangle(100, 100, 120, 70);
        private static string textBoxStore = "";
        private static bool editMode = true;

        // Gui Button Params
        private static Rectangle btnRect = new Rectangle(150, 270, 120, 80);

        // Gui Label Params
        private static Rectangle labelRect = new Rectangle(150, 360, 120, 80);

        // Gui Toggle Params
        private static bool state = false;
        private static Rectangle toggleRect = new Rectangle(150, 210, 120, 80);

        // Gui CheckBox Params
        private static bool isChecked = false;
        private static Rectangle checkBoxRect = new Rectangle(150, 80, 120, 80);


        
        /// <summary>
        /// Application entry point
        /// </summary>
        public static void Main()
        {
            Raylib.InitWindow(1024, 1024, "RayGUI Web Template");
            Raylib.SetTargetFPS(60);
            
        }

        /// <summary>
        /// Updates frame
        /// </summary>
        [JSExport]
        public static void UpdateFrame()
        {
            Raylib.BeginDrawing();

            Raylib.ClearBackground(Color.Pink);

            // GUI TextBox
            Raylib.DrawText("Text Box", 100, 60, 30, Color.Black);
            RayGui.GuiTextBox(textBoxRect, ref textBoxStore, 100, editMode);

            // GUI Slider
            Raylib.DrawText("Gui Slider", 100, 190, 30, Color.Black);
            RayGui.GuiSlider(sliderRect, "Min", "Max", ref sliderValue, 0, 1);

            // Gui CheckBox
            Raylib.DrawText("Gui CheckBox", 150, 60, 30, Color.Black);
            RayGui.GuiCheckBox(checkBoxRect, "Check Box", ref isChecked);

            // Gui Toggle
            Raylib.DrawText("Gui Toggle Button", 150, 190, 30, Color.Black);
            RayGui.GuiToggle(toggleRect, "Toggle State", ref state);

            // Gui Button
            Raylib.DrawText("Gui Button", 150, 250, 30, Color.Black);
            bool x = RayGui.GuiButton(btnRect, "Button");

            if (x) Console.WriteLine("Button Has Been Pressed!");

            // Gui Label
            Raylib.DrawText("Gui Label", 150, 340, 30, Color.Black);
            RayGui.GuiLabel(labelRect, "Label");

            Raylib.EndDrawing();
        }
    }
}
