using System;
using System.Threading;
using stoves3.basInt.csharp.core;

namespace stoves3.basInt.csharp.basFuncs
{
    public static class SharedFunctions
    {
        #region IScreen

        public static void Cls(this IScreen screen)
        {
            screen.Cls();
        }

        public static IScreen Screen(IUI ui, int mode, int colorswitch = 0, int activePage = 0, int visualPage = 0)
        {
            return new BasicScreen(ui, (ScreenMode)mode, colorswitch, activePage, visualPage);
        }

        public static void Color(this IScreen screen, int foregroundColorIndex, int backgroundColorIndex = -1)
        {
            screen.ActivePage.Color(foregroundColorIndex, backgroundColorIndex);
        }

        public static void Locate(this IScreen screen, int row = 1, int column = 1, int cursor = 1, int start = 0, int stop = 0)
        {
            if (row < 1) row = 1;
            if (column < 1) column = 1;

            screen.ActivePage.Locate(row, column, cursor, start, stop);
        }

        public static void Print(this IScreen screen, int fileNumber = -1, string text = null, bool tab = false)
        {
            screen.ActivePage.Print(fileNumber, text, tab);
        }

        public static void Width(this IScreen screen, TextColumnWidth columns, TextRowHeight rows)
        {
            screen.SetWidth(columns, rows);
        }

        public static void Width(this IScreen screen, int fileNumber, TextColumnWidth columns, TextRowHeight rows)
        {

        }

        #endregion

        #region IInput

        public static string InkeyṨ(this IScreen screen, IInput input)
        {
            return input.INKEYṨ(screen);
        }

        public static string Input(this IScreen screen, IInput input, string displayQuestionText)
        {
            var inputDisplay = $"{displayQuestionText}? ";
            screen.Print(text: inputDisplay);
            return input.Input(screen);
        }

        #endregion

        #region ISound

        public static void Play(this ISound sound, string musicString)
        {
            sound.Play(musicString);
        }

        #endregion

        #region Misc

        public static void Sleep(int seconds)
        {
            Thread.Sleep(new TimeSpan(0, 0, seconds));
        }

        public static int Val(string text)
        {
            return int.Parse(text);
        }

        public static string Ucase(string text)
        {
            return text.ToUpper();
        }

        #endregion
    }
}
