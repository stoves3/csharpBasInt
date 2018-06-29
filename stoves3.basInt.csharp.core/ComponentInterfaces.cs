using System.Collections.Generic;

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
        void Color(int colorIndex);
        void Locate(int row, int column, int cursor, int start, int stop);
        void Print(int fileNumber, string line, bool tab);
    }

    public interface IScreen
    {
        int Mode { get; }
        List<IScreenPage> AllScreenPages { get; }
        IScreenPage ActivePage { get; }
        IScreenPage VisualPage { get; }
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
