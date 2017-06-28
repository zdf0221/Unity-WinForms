﻿namespace System.Drawing
{
    [Flags]
    public enum FontStyle
    {
        Regular = 0,
        Bold = 1,
        Italic = 2,
        Underline = 4,
        Strikeout = 8,
    }

    [Serializable]
    public sealed class Font
    {
        internal UnityEngine.Font UFont;

        private readonly string name;
        private readonly FontStyle style;

        public Font(string familyName, float emSize)
        {
            this.name = familyName;
            Size = emSize;
        }
        public Font(string familyName, float emSize, FontStyle style)
        {
            this.name = familyName;
            this.style = style;
            Size = emSize;
        }

        public string Name { get { return this.name; } }
        public float Size { get; set; }
        public FontStyle Style { get { return this.style; } }

        public override string ToString()
        {
            return string.Format("[{0}, {1}, {2}]", Name, Size, Style);
        }
    }
}
