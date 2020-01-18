using System.Drawing;

namespace TextArt.Options
{
    public class TextArtGeneratorOptions
    {
        public int Seed { get; set; }
        public string Alphabet{ get; set; }
        public Image InputImage { get; set; }
        public int DesiredWidth { get; set; }
        public int DesiredHeight { get; set; }
        public string FontName { get; set; }
        public int MaximumFontSize { get; set; }
        public int MinimumFontSize { get; set; }
        public int XStep { get; set; }
        public int YStep { get; set; }
        public int Scatter { get; set; }
    }
}