using System;
using System.Drawing;
using stoves3.basInt.csharp.core;

namespace stoves3.basInt.csharp.UI
{
    public class Console : IUI
    {
        private Color _foregroundColor;
        public Color ForegroundColor { get { return _foregroundColor; } set { SetForegroundColor(value); } }

        private Color _backgroundColor;
        public Color BackgroundColor { get { return _backgroundColor; } set { SetBackgroundColor(value); } }

        public void Width(int columns, int rows)
        {
            System.Console.SetWindowSize(columns, rows);
        }
        public void Print(string text, bool newLine)
        {
            text = string.IsNullOrEmpty(text) ? (newLine ? Environment.NewLine : " ") : text;
            if (newLine)
                Print(text);
            else
                PrintLine(text);
        }

        private void Print(string text)
        {
            System.Console.Write(text);
        }

        private void PrintLine(string text)
        {
            System.Console.WriteLine(text);
        }

        public void Locate(Vector2 cursorLoc)
        {
            System.Console.SetCursorPosition((int)cursorLoc.X, (int)cursorLoc.Y);
        }

        public void Cls()
        {
            System.Console.Clear();
        }

        private void SetForegroundColor(Color value)
        {
            _foregroundColor = value;
            System.Console.ForegroundColor = _foregroundColor.FromColor();
        }

        private void SetBackgroundColor(Color value)
        {
            _backgroundColor = value;
            System.Console.BackgroundColor = _backgroundColor.FromColor();
        }

        public string GetChar()
        {
            return System.Console.ReadKey().KeyChar.ToString();
        }

        public string GetInput()
        {
            return System.Console.ReadLine();
        }
    }

    public static class ColorExtensions
    {
        public static System.ConsoleColor FromColor(this Color color)
        {
            int index = (color.R > 128 | color.G > 128 | color.B > 128) ? 8 : 0; // Bright bit
            index |= (color.R > 64) ? 4 : 0; // Red bit
            index |= (color.G > 64) ? 2 : 0; // Green bit
            index |= (color.B > 64) ? 1 : 0; // Blue bit
            return (System.ConsoleColor) index;
        }
    }
}
