using System;
using System.Threading;
using stoves3.basInt.csharp.core;

namespace stoves3.basInt.csharp.basFuncs
{
    public static class SharedFunctions
    {

        public static void CLS(this IScreen screen)
        {
            screen.ActivePage.ScreenTextBuffer.Reset();
        }

        public static IScreen Screen(int mode, int colorswitch = 0, int activePage = 0, int visualPage = 0)
        {
            return new BasicScreen(mode, colorswitch, activePage, visualPage);
        }

        public static void Color(this IScreen screen, int colorIndex)
        {
            screen.ActivePage.Color(colorIndex);
        }

        public static void Locate(this IScreen screen, int row = 1, int column = 1, int cursor = 0, int start = 0, int stop = 0)
        {
            if (row < 1) row = 1;
            if (column < 1) column = 1;

            screen.ActivePage.Locate(row, column, cursor, start, stop);
        }

        public static void Print(this IScreen screen, int fileNumber = -1, string text = null, bool tab = false)
        {
            screen.ActivePage.Print(fileNumber, text, tab);
        }

        public static void Sleep(int seconds)
        {
            Thread.Sleep(new TimeSpan(0, 0, seconds));
        }

        public static int Val(string text)
        {
            return int.Parse(text);
        }

        public static string INKEYṨ(this IScreen screen, IInput input)
        {
            return input.INKEYṨ(screen);
        }

        public static string Input(this IScreen screen, IInput input, string displayQuestionText)
        {
            var inputDisplay = $"{displayQuestionText}? ";
            screen.Print(text: inputDisplay);
            return input.Input(screen);
        }

        public static string Ucase(string text)
        {
            return text.ToUpper();
        }

        public static void Play(this ISound sound, string musicString)
        {
            sound.Play(musicString);
        }
    }
}
