using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace stoves3.basInt.csharp.core
{
    public interface IPixel
    {
    }

    public interface IColor
    {
    }

    public interface IPalette
    {
        List<Color> ColorValues { get; }
        ColorAttributes ColorAttributes { get; }
    }

    public interface ITextBuffer
    {
        string[,] TextBuffer { get; }
        void Reset();
    }

    public interface IScreenPage
    {
        IPixel[,] VideoBuffer { get; }
        IPalette Palette { get; set; }
        ITextBuffer ScreenTextBuffer { get; }
        int CurrentForegroundColorIndex { get; }
        int CurrentBackgroundColorIndex { get; }
        void Color(int foregroundColorIndex, int backgroundColorIndex = -1);
        void Locate(int row, int column, int cursor, int start, int stop);
        void Print(int fileNumber, string line, bool tab);
        void Cls();
    }

    public interface IScreen
    {
        ScreenMode Mode { get; }
        List<IScreenPage> AllScreenPages { get; }
        IScreenPage ActivePage { get; }
        IScreenPage VisualPage { get; }

        void Width(TextColumnWidth columns, TextRowHeight rows, int fileNumber);
        void Cls();
    }

    public interface ISound
    {
        void Play(string musicString);
    }

    public interface IInput
    {
        string Input(IScreen screen);
        string INKEYṨ(IScreen screen);
    }
}
