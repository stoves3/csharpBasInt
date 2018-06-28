using System;
using System.Collections.Generic;
using System.Text;

namespace stoves3.basInt.csharp.core
{
    public class BasicScreen : IScreen
    {
        public int Mode { get; }
        public List<IScreenPage> AllScreenPages { get; }
        public IScreenPage ActivePage => AllScreenPages[_activePage];
        public IScreenPage VisualPage => AllScreenPages[_visualPage];

        private readonly bool _colorEnabled;
        private int _activePage;
        private int _visualPage;

        public BasicScreen(int mode, int colorswitch = 0, int activePage = 0, int visualPage = 0)
        {
            Mode = mode;
            _colorEnabled = colorswitch > 0;
            _activePage = activePage;
            _visualPage = visualPage;

            AllScreenPages = new List<IScreenPage>();

            ConfiguraeScreen();

            SetActivePage(_activePage);
            SetVisualPage(visualPage);
        }

        public void SetActivePage(int page)
        {
            _activePage = page;
        }

        public void SetVisualPage(int page)
        {
            _visualPage = page;
        }

        private void ConfiguraeScreen()
        {


            switch (Mode)
            {
            }
        }
    }

    public class BasicPage : IScreenPage
    {
        private static readonly Encoding _outputEncoding = System.Text.Encoding.ASCII;

        public IPixel[,] VideoBuffer { get; }
        public IPalette Palette { get; set; }
        public ITextBuffer ScreenTextBuffer { get; }

        public void Color(int colorIndex)
        {
            throw new System.NotImplementedException();
        }

        public void Locate(int row, int column, int cursor, int start, int stop)
        {
            throw new System.NotImplementedException();
        }

        public void Print(int fileNumber, string text, bool tab = false)
        {
            Console.OutputEncoding = _outputEncoding;
            throw new System.NotImplementedException();
        }
    }
}