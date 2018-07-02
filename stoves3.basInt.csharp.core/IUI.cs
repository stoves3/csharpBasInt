using System.Drawing;

namespace stoves3.basInt.csharp.core
{
    public interface IUI
    {
        Color ForegroundColor { get; set; }
        Color BackgroundColor { get; set; }
        void Width(int columns, int rows);
        void Print(string text, bool newLine);
        void Locate(Vector2 cursorLoc);
        void Cls();
        string GetChar();
        string GetInput();
    }
}
