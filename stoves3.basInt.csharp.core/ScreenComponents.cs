using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace stoves3.basInt.csharp.core
{
    public enum ScreenMode
    {
        Zero = 0,
        One = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Eleven = 11,
        Twelve = 12,
        Thirteen = 13
    }

    public enum Device
    {
        Unknown,
        [Display(Name = "SCRN:")]
        SCRN,
        [Display(Name = "COM1:")]
        COM1,
        [Display(Name = "COM2:")]
        COM2,
        [Display(Name = "LPT1:")]
        LPT1,
        [Display(Name = "LPT2:")]
        LPT2,
        [Display(Name = "LPT3:")]
        LPT3
    }

    public class BasicScreen : IScreen
    {
        public const int MinimumPages = 1;
        public const int MaximumPages = 8;

        public class Resolution
        {
            public int Width { get; set; }
            public int Height { get; set; }

            public Resolution(int width, int height)
            {
                Width = width;
                Height = height;
            }
        }

        public ScreenMode Mode { get; }
        public List<IScreenPage> AllScreenPages { get; }
        public IScreenPage ActivePage => AllScreenPages[_activePage];
        public IScreenPage VisualPage => AllScreenPages[_visualPage];

        private int _activePage;
        private int _visualPage;

        private Resolution _resolution;
        private TextResolution _textResolution;
        private bool _colorEnabled;
        private ColorAttributes _colorAttributes;
        private ColorDepth _colorDepth;
        private int _videoMemoryPages;

        private readonly IUI _ui;

        public BasicScreen(IUI ui, ScreenMode mode, int colorswitch = 0, int activePage = 0, int visualPage = 0)
        {
            _ui = ui;
            Mode = mode;
            _colorEnabled = colorswitch > 0;

            AllScreenPages = new List<IScreenPage>();

            ConfigureScreen();

            SetActivePage(activePage);
            SetVisualPage(visualPage);


        }

        public void SetWidth(TextColumnWidth columns, TextRowHeight rows, int fileNumber = -1)
        {
            _ui.Width((int)columns, (int)rows);
        }

        public void Cls()
        {
            ActivePage.Cls();
            if (_activePage == _visualPage) _ui.Cls();
        }

        public void SetActivePage(int page)
        {
            _activePage = page;
        }

        public void SetVisualPage(int page)
        {
            _visualPage = page;
        }

        private void ConfigureScreen()
        {
            switch (Mode)
            {
                case ScreenMode.Zero:
                    _resolution = null;
                    _textResolution = new TextResolution(TextColumnWidth.Eighty, TextRowHeight.TwentyFive);
                    SetWidth(TextColumnWidth.Eighty, TextRowHeight.TwentyFive);
                    _colorEnabled = true;
                    _colorAttributes = ColorAttributes.Sixteen;
                    _colorDepth = ColorDepth.d4Bit;
                    _videoMemoryPages = MinimumPages;
                    InitPages(PageSize.m2K);
                    break;
                case ScreenMode.One:
                    _resolution = new Resolution(320, 200);
                    break;
                case ScreenMode.Two:
                    _resolution = new Resolution(640, 200);
                    break;
                case ScreenMode.Three:
                    _resolution = new Resolution(720, 348);
                    break;
                case ScreenMode.Four:
                    _resolution = new Resolution(640, 400);
                    break;
                case ScreenMode.Seven:
                    _resolution = new Resolution(320, 200);
                    break;
                case ScreenMode.Eight:
                    _resolution = new Resolution(640, 200);
                    break;
                case ScreenMode.Nine:
                    _resolution = new Resolution(640, 350);
                    break;
                case ScreenMode.Ten:
                    _resolution = new Resolution(640, 350);
                    break;
                case ScreenMode.Eleven:
                    _resolution = new Resolution(640, 480);
                    break;
                case ScreenMode.Twelve:
                    _resolution = new Resolution(640, 480);
                    break;
                case ScreenMode.Thirteen:
                    _resolution = new Resolution(320, 200);
                    break;
            }
        }

        private void InitPages(PageSize pageSize)
        {
            for (var i = 0; i < _videoMemoryPages; i++)
            {
                AllScreenPages.Add(CreateScrenPage(pageSize));
            }
        }

        private IScreenPage CreateScrenPage(PageSize pageSize)
        {
            return new BasicPage(pageSize, _textResolution, _colorDepth, _colorAttributes, _ui);
        }
    }

    public struct Vector2
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Vector2(double x, double y)
        {
            X = x;
            Y = y;
        }
    }

    public class Buffer : ITextBuffer
    {
        public string[,] TextBuffer { get; private set; }

        private int _width;
        private int _height;

        public Buffer(int width, int height)
        {
            _width = width;
            _height = height;

            Reset();
        }

        public void Reset()
        {
            TextBuffer = new string[_width, _height];
        }
    }

    public class BasicPage : IScreenPage
    {
        public IPixel[,] VideoBuffer { get; }
        public IPalette Palette { get; set; }
        public ITextBuffer ScreenTextBuffer { get; }
        public int CurrentForegroundColorIndex { get; private set; }
        public int CurrentBackgroundColorIndex { get; private set; }
        public PageSize PageSize { get; }

        private ColorAttributes _colorAttributes;
        private bool _cursorVisible;

        private TextResolution _textResolution;

        private Vector2 _cursorLoc;

        private readonly List<BlinkingText> _blinkingTexts;

        private bool _textIsBlinking;
        
        private readonly IUI _ui;

        public BasicPage(PageSize pageSize, TextResolution textResolution, ColorDepth depth, ColorAttributes colorAttributes, IUI ui)
        {
            _blinkingTexts = new List<BlinkingText>();

            PageSize = pageSize;
            _textResolution = textResolution;
            ScreenTextBuffer = new Buffer(_textResolution.Width, _textResolution.Height);

            _colorAttributes = colorAttributes;
            CurrentForegroundColorIndex = 15;
            CurrentBackgroundColorIndex = 0;
            Palette = new Palette(colorAttributes, depth);
            _cursorVisible = true;
            _cursorLoc = new Vector2(1, 1);

            _ui = ui;
        }

        public void Color(int foregroundColorIndex, int backgroundColorIndex = -1)
        {
            CurrentForegroundColorIndex = foregroundColorIndex;
            CurrentBackgroundColorIndex = backgroundColorIndex > -1 ? backgroundColorIndex : CurrentBackgroundColorIndex;

            _textIsBlinking = CurrentForegroundColorIndex > Palette.ColorValues.Count;

            _ui.ForegroundColor = Palette.ColorValues[CurrentForegroundColorIndex % Palette.ColorValues.Count];
            _ui.BackgroundColor = Palette.ColorValues[CurrentBackgroundColorIndex % Palette.ColorValues.Count];
        }

        public void Locate(int row, int column, int cursor, int start, int stop)
        {
            _cursorVisible = cursor > 0;

            if (row > 0 || column > 0)
            {
                var newRow = -1;
                if (row > 0) newRow = row;

                var newColumn = -1;
                if (column > 0) newColumn = column;

                _cursorLoc = new Vector2(newColumn > -1 ? newColumn : _cursorLoc.X, newRow > -1 ? newRow : _cursorLoc.Y);
            }

            _ui.Locate(_cursorLoc);

            if (start <= 0 && stop <= 0) return;
        }

        public void Print(int fileNumber, string text, bool tab = false)
        {
            if (_textIsBlinking && !string.IsNullOrWhiteSpace(text)) _blinkingTexts.Add(new BlinkingText {Text = text, Location = _cursorLoc, ColorIndex = CurrentForegroundColorIndex});
            
            _ui.Print(text, !tab);
        }

        public void Cls()
        {
            ScreenTextBuffer.Reset();
            _blinkingTexts.Clear();
            _ui.Cls();
        }

        private class BlinkingText
        {
            public string Text { get; set; }
            public Vector2 Location { get; set; }
            public int ColorIndex { get; set; }
        }
    }
}