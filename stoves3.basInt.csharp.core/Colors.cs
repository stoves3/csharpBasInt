﻿using System.Collections.Generic;
using System.Drawing;

namespace stoves3.basInt.csharp.core
{
    public enum ColorAttributes
    {
        Sixteen = 16,
        TwoFiftySix = 256,
        Two = 2,
        Four = 4
    }

    public enum ColorDepth
    {
        d4Bit = 16,
        d6Bit = 64,
        d8Bit = 256
    }

    public enum BaseColorIndex
    {
        Black = 0,
        Blue = 1,
        Green = 2,
        Cyan = 3,
        Red = 4,
        Magenta = 5,
        Brown = 6,
        White = 7,
        Gray = 8,
        LightBlue = 9,
        LightGreen = 10,
        LightCyan = 11,
        LightRed = 12,
        LightMagenta = 13,
        Yellow = 14,
        HighIntensityWhite = 15
    }

    public class Palette : IPalette
    {
        public List<Color> ColorValues { get; }

        public ColorAttributes ColorAttributes { get; }

        private readonly ColorDepth _depth;

        public Palette(ColorAttributes colorAttributes, ColorDepth depth)
        {
            ColorValues = new List<Color>();
            ColorAttributes = colorAttributes;
            _depth = depth;

            for (var i = 0; i < (int)ColorAttributes; i++)
            {
                ColorValues.Add(DefaultPalleteColors[i]);
            }
        }

        public Dictionary<BaseColorIndex, Color> DefaultBaseColors = new Dictionary<BaseColorIndex, Color>
        {
            {BaseColorIndex.Black, Color.FromArgb(0, 0, 0)},
            {BaseColorIndex.Blue, Color.FromArgb(0, 0, 170)},
            {BaseColorIndex.Green, Color.FromArgb(0, 170, 0)},
            {BaseColorIndex.Cyan, Color.FromArgb(0, 170, 170)},
            {BaseColorIndex.Red, Color.FromArgb(170, 0, 0)},
            {BaseColorIndex.Magenta, Color.FromArgb(170, 0, 170)},
            {BaseColorIndex.Brown, Color.FromArgb(170, 85, 0)},
            {BaseColorIndex.White, Color.FromArgb(170, 170, 170)},
            {BaseColorIndex.Gray, Color.FromArgb(85, 85, 85)},
            {BaseColorIndex.LightBlue, Color.FromArgb(85, 85, 255)},
            {BaseColorIndex.LightGreen, Color.FromArgb(85, 255, 85)},
            {BaseColorIndex.LightCyan, Color.FromArgb(85, 255, 255)},
            {BaseColorIndex.LightRed, Color.FromArgb(255, 85, 85)},
            {BaseColorIndex.LightMagenta, Color.FromArgb(255, 85, 255)},
            {BaseColorIndex.Yellow, Color.FromArgb(255, 255, 85)},
            {BaseColorIndex.HighIntensityWhite, Color.FromArgb(255, 255, 255)}
        };

        public List<Color> DefaultPalleteColors = new List<Color>
        {
            Color.FromArgb(0, 0, 0),
            Color.FromArgb(0, 0, 170),
            Color.FromArgb(0, 170, 0),
            Color.FromArgb(0, 170, 170),
            Color.FromArgb(170, 0, 0),
            Color.FromArgb(170, 0, 170),
            Color.FromArgb(170, 85, 0),
            Color.FromArgb(170, 170, 170),
            Color.FromArgb(85, 85, 85),
            Color.FromArgb(85, 85, 255),
            Color.FromArgb(85, 255, 85),
            Color.FromArgb(85, 255, 255),
            Color.FromArgb(255, 85, 85),
            Color.FromArgb(255, 85, 255),
            Color.FromArgb(255, 255, 85),
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(0, 0, 0),
            Color.FromArgb(20, 20, 20),
            Color.FromArgb(32, 32, 32),
            Color.FromArgb(44, 44, 44),
            Color.FromArgb(56, 56, 56),
            Color.FromArgb(68, 68, 68),
            Color.FromArgb(80, 80, 80),
            Color.FromArgb(97, 97, 97),
            Color.FromArgb(113, 113, 113),
            Color.FromArgb(129, 129, 129),
            Color.FromArgb(145, 145, 145),
            Color.FromArgb(161, 161, 161),
            Color.FromArgb(182, 182, 182),
            Color.FromArgb(202, 202, 202),
            Color.FromArgb(226, 226, 226),
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(0, 0, 255),
            Color.FromArgb(64, 0, 255),
            Color.FromArgb(125, 0, 255),
            Color.FromArgb(190, 0, 255),
            Color.FromArgb(255, 0, 255),
            Color.FromArgb(255, 0, 190),
            Color.FromArgb(255, 0, 125),
            Color.FromArgb(255, 0, 64),
            Color.FromArgb(255, 0, 0),
            Color.FromArgb(255, 64, 0),
            Color.FromArgb(255, 125, 0),
            Color.FromArgb(255, 190, 0),
            Color.FromArgb(255, 255, 0),
            Color.FromArgb(190, 255, 0),
            Color.FromArgb(125, 255, 0),
            Color.FromArgb(64, 255, 0),
            Color.FromArgb(0, 255, 0),
            Color.FromArgb(0, 255, 64),
            Color.FromArgb(0, 255, 125),
            Color.FromArgb(0, 255, 190),
            Color.FromArgb(0, 255, 255),
            Color.FromArgb(0, 190, 255),
            Color.FromArgb(0, 125, 255),
            Color.FromArgb(0, 64, 255),
            Color.FromArgb(125, 125, 255),
            Color.FromArgb(157, 125, 255),
            Color.FromArgb(190, 125, 255),
            Color.FromArgb(222, 125, 255),
            Color.FromArgb(255, 125, 255),
            Color.FromArgb(255, 125, 222),
            Color.FromArgb(255, 125, 190),
            Color.FromArgb(255, 125, 157),
            Color.FromArgb(255, 125, 125),
            Color.FromArgb(255, 157, 125),
            Color.FromArgb(255, 190, 125),
            Color.FromArgb(255, 222, 125),
            Color.FromArgb(255, 255, 125),
            Color.FromArgb(222, 255, 125),
            Color.FromArgb(190, 255, 125),
            Color.FromArgb(157, 255, 125),
            Color.FromArgb(125, 255, 125),
            Color.FromArgb(125, 255, 157),
            Color.FromArgb(125, 255, 190),
            Color.FromArgb(125, 255, 222),
            Color.FromArgb(125, 255, 255),
            Color.FromArgb(125, 222, 255),
            Color.FromArgb(125, 190, 255),
            Color.FromArgb(125, 157, 255),
            Color.FromArgb(182, 182, 255),
            Color.FromArgb(198, 182, 255),
            Color.FromArgb(218, 182, 255),
            Color.FromArgb(234, 182, 255),
            Color.FromArgb(255, 182, 255),
            Color.FromArgb(255, 182, 234),
            Color.FromArgb(255, 182, 218),
            Color.FromArgb(255, 182, 198),
            Color.FromArgb(255, 182, 182),
            Color.FromArgb(255, 198, 182),
            Color.FromArgb(255, 218, 182),
            Color.FromArgb(255, 234, 182),
            Color.FromArgb(255, 255, 182),
            Color.FromArgb(234, 255, 182),
            Color.FromArgb(218, 255, 182),
            Color.FromArgb(198, 255, 182),
            Color.FromArgb(182, 255, 182),
            Color.FromArgb(182, 255, 198),
            Color.FromArgb(182, 255, 218),
            Color.FromArgb(182, 255, 234),
            Color.FromArgb(182, 255, 255),
            Color.FromArgb(182, 234, 255),
            Color.FromArgb(182, 218, 255),
            Color.FromArgb(182, 198, 255),
            Color.FromArgb(0, 0, 113),
            Color.FromArgb(28, 0, 113),
            Color.FromArgb(56, 0, 113),
            Color.FromArgb(85, 0, 113),
            Color.FromArgb(113, 0, 113),
            Color.FromArgb(113, 0, 85),
            Color.FromArgb(113, 0, 56),
            Color.FromArgb(113, 0, 28),
            Color.FromArgb(113, 0, 0),
            Color.FromArgb(113, 28, 0),
            Color.FromArgb(113, 56, 0),
            Color.FromArgb(113, 85, 0),
            Color.FromArgb(113, 113, 0),
            Color.FromArgb(85, 113, 0),
            Color.FromArgb(56, 113, 0),
            Color.FromArgb(28, 113, 0),
            Color.FromArgb(0, 113, 0),
            Color.FromArgb(0, 113, 28),
            Color.FromArgb(0, 113, 56),
            Color.FromArgb(0, 113, 85),
            Color.FromArgb(0, 113, 113),
            Color.FromArgb(0, 85, 113),
            Color.FromArgb(0, 56, 113),
            Color.FromArgb(0, 28, 113),
            Color.FromArgb(56, 56, 113),
            Color.FromArgb(68, 56, 113),
            Color.FromArgb(85, 56, 113),
            Color.FromArgb(97, 56, 113),
            Color.FromArgb(113, 56, 113),
            Color.FromArgb(113, 56, 97),
            Color.FromArgb(113, 56, 85),
            Color.FromArgb(113, 56, 68),
            Color.FromArgb(113, 56, 56),
            Color.FromArgb(113, 68, 56),
            Color.FromArgb(113, 85, 56),
            Color.FromArgb(113, 97, 56),
            Color.FromArgb(113, 113, 56),
            Color.FromArgb(97, 113, 56),
            Color.FromArgb(85, 113, 56),
            Color.FromArgb(68, 113, 56),
            Color.FromArgb(56, 113, 56),
            Color.FromArgb(56, 113, 68),
            Color.FromArgb(56, 113, 85),
            Color.FromArgb(56, 113, 97),
            Color.FromArgb(56, 113, 113),
            Color.FromArgb(56, 97, 113),
            Color.FromArgb(56, 85, 113),
            Color.FromArgb(56, 68, 113),
            Color.FromArgb(80, 80, 113),
            Color.FromArgb(89, 80, 113),
            Color.FromArgb(97, 80, 113),
            Color.FromArgb(105, 80, 113),
            Color.FromArgb(113, 80, 113),
            Color.FromArgb(113, 80, 105),
            Color.FromArgb(113, 80, 97),
            Color.FromArgb(113, 80, 89),
            Color.FromArgb(113, 80, 80),
            Color.FromArgb(113, 89, 80),
            Color.FromArgb(113, 97, 80),
            Color.FromArgb(113, 105, 80),
            Color.FromArgb(113, 113, 80),
            Color.FromArgb(105, 113, 80),
            Color.FromArgb(97, 113, 80),
            Color.FromArgb(89, 113, 80),
            Color.FromArgb(80, 113, 80),
            Color.FromArgb(80, 113, 89),
            Color.FromArgb(80, 113, 97),
            Color.FromArgb(80, 113, 105),
            Color.FromArgb(80, 113, 113),
            Color.FromArgb(80, 105, 113),
            Color.FromArgb(80, 97, 113),
            Color.FromArgb(80, 89, 113),
            Color.FromArgb(0, 0, 64),
            Color.FromArgb(16, 0, 64),
            Color.FromArgb(32, 0, 64),
            Color.FromArgb(48, 0, 64),
            Color.FromArgb(64, 0, 64),
            Color.FromArgb(64, 0, 48),
            Color.FromArgb(64, 0, 32),
            Color.FromArgb(64, 0, 16),
            Color.FromArgb(64, 0, 0),
            Color.FromArgb(64, 16, 0),
            Color.FromArgb(64, 32, 0),
            Color.FromArgb(64, 48, 0),
            Color.FromArgb(64, 64, 0),
            Color.FromArgb(48, 64, 0),
            Color.FromArgb(32, 64, 0),
            Color.FromArgb(16, 64, 0),
            Color.FromArgb(0, 64, 0),
            Color.FromArgb(0, 64, 16),
            Color.FromArgb(0, 64, 32),
            Color.FromArgb(0, 64, 48),
            Color.FromArgb(0, 64, 64),
            Color.FromArgb(0, 48, 64),
            Color.FromArgb(0, 32, 64),
            Color.FromArgb(0, 16, 64),
            Color.FromArgb(32, 32, 64),
            Color.FromArgb(40, 32, 64),
            Color.FromArgb(48, 32, 64),
            Color.FromArgb(56, 32, 64),
            Color.FromArgb(64, 32, 64),
            Color.FromArgb(64, 32, 56),
            Color.FromArgb(64, 32, 48),
            Color.FromArgb(64, 32, 40),
            Color.FromArgb(64, 32, 32),
            Color.FromArgb(64, 40, 32),
            Color.FromArgb(64, 48, 32),
            Color.FromArgb(64, 56, 32),
            Color.FromArgb(64, 64, 32),
            Color.FromArgb(56, 64, 32),
            Color.FromArgb(48, 64, 32),
            Color.FromArgb(40, 64, 32),
            Color.FromArgb(32, 64, 32),
            Color.FromArgb(32, 64, 40),
            Color.FromArgb(32, 64, 48),
            Color.FromArgb(32, 64, 56),
            Color.FromArgb(32, 64, 64),
            Color.FromArgb(32, 56, 64),
            Color.FromArgb(32, 48, 64),
            Color.FromArgb(32, 40, 64),
            Color.FromArgb(44, 44, 64),
            Color.FromArgb(48, 44, 64),
            Color.FromArgb(52, 44, 64),
            Color.FromArgb(60, 44, 64),
            Color.FromArgb(64, 44, 64),
            Color.FromArgb(64, 44, 60),
            Color.FromArgb(64, 44, 52),
            Color.FromArgb(64, 44, 48),
            Color.FromArgb(64, 44, 44),
            Color.FromArgb(64, 48, 44),
            Color.FromArgb(64, 52, 44),
            Color.FromArgb(64, 60, 44),
            Color.FromArgb(64, 64, 44),
            Color.FromArgb(60, 64, 44),
            Color.FromArgb(52, 64, 44),
            Color.FromArgb(48, 64, 44),
            Color.FromArgb(44, 64, 44),
            Color.FromArgb(44, 64, 48),
            Color.FromArgb(44, 64, 52),
            Color.FromArgb(44, 64, 60),
            Color.FromArgb(44, 64, 64),
            Color.FromArgb(44, 60, 64),
            Color.FromArgb(44, 52, 64),
            Color.FromArgb(44, 48, 64),
            Color.FromArgb(0, 0, 0),
            Color.FromArgb(0, 0, 0),
            Color.FromArgb(0, 0, 0),
            Color.FromArgb(0, 0, 0),
            Color.FromArgb(0, 0, 0),
            Color.FromArgb(0, 0, 0),
            Color.FromArgb(0, 0, 0),
            Color.FromArgb(0, 0, 0)
        };
    }
}
