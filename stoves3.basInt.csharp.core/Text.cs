namespace stoves3.basInt.csharp.core
{
    public enum TextRowHeight
    {
        TwentyFive = 25,
        Thirty = 30,
        FourtyThree = 43,
        Fifty = 50,
        Sixty = 60
    }

    public enum TextColumnWidth
    {
        Eighty = 80,
        Fourty = 40
    }

    public class TextResolution
    {
        public int Height { get; }
        public int Width { get; }

        private TextRowHeight RowHeight { get; }
        private TextColumnWidth ColumnWidth { get; }

        public TextResolution(TextColumnWidth columns, TextRowHeight rows)
        {
            RowHeight = rows;
            ColumnWidth = columns;

            Height = (int)RowHeight;
            Width = (int)ColumnWidth;
        }
    }
}
