using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextArt.Generators;
using TextArt.Options;

namespace TextArt.ViewModels
{
    public class MainFormViewModel
    {
        #region "fields"

        private int m_desiredWidth;
        private int m_desiredHeight;

        #endregion 

        #region "simple properties"

        public string Alphabet { get; set; }
        public Image InputImage { get; set; }
        public Image OutputImage { get; set; }
        public bool LockAspectRatio { get; set; }
        public string FontName { get; set; }
        public int MinimumFontSize { get; set; }
        public int MaximumFontSize { get; set; }
        public int RandomSeed { get; set; }
        public Color BackgroundColor { get; set; }
        public int Scatter { get; set; }
        public int XStep { get; set; }
        public int YStep { get; set; }

        #endregion

        #region "advanced properties"

        public int DesiredWidth 
        {
            get
            {
                return m_desiredWidth;
            }
            set
            {
                m_desiredWidth = value;

                if (InputImageIsLoaded() && LockAspectRatio)
                {
                    m_desiredHeight = 
                        GetProportionalOtherDimension
                        ( 
                            m_desiredWidth, 
                            InputImage.Width, 
                            InputImage.Height
                        );
                }

            }
        }

        public int DesiredHeight 
        {
            get
            {
                return m_desiredHeight;
            }
            set
            {
                m_desiredHeight = value;

                if (InputImageIsLoaded() && LockAspectRatio)
                {
                    m_desiredWidth = 
                        GetProportionalOtherDimension
                        (
                            m_desiredHeight,
                            InputImage.Height,
                            InputImage.Width
                        );
                }
            }
        }

        #endregion

        private bool InputImageIsLoaded()
        {
            return InputImage != null;
        }

        private int GetProportionalOtherDimension(int newThis, int originalThis, int originalOther)
        {
            return (int)((double)originalOther * ((double)newThis / (double)originalThis));
        }

        internal void Generate()
        {
            ValidateArguments();

            var generator = new TextArtGenerator(
                InputImage,
                MapOptions()
            );

            OutputImage = generator.Generate();
        }

        private TextArtGeneratorOptions MapOptions()
        {
            return new TextArtGeneratorOptions()
            {
                Alphabet = Alphabet,
                DesiredHeight = DesiredHeight,
                DesiredWidth = DesiredWidth,
                InputImage = InputImage,
                MaximumFontSize = MaximumFontSize,
                MinimumFontSize = MinimumFontSize,
                FontName = FontName,
                XStep = XStep,
                YStep = YStep,
                Seed = RandomSeed,
                Scatter = Scatter
            };
        }

        private void ValidateArguments()
        {
            if (InputImage is null)
                throw new InvalidOperationException("Load an image first.");
            if (DesiredHeight < 0)
                throw new InvalidOperationException("Desired Height must be greater than zero.");
            if (DesiredWidth < 0)
                throw new InvalidOperationException("Desired Width must be greater than zero.");
            if (FontName is null | FontName == String.Empty)
                throw new InvalidOperationException("Font Name not specified.");
            if (MinimumFontSize <= 0)
                throw new InvalidOperationException("Minimum Font Size must be greater than zero.");
            if (MaximumFontSize <= 0)
                throw new InvalidOperationException("Maximum Font Size must be greater than zero.");
            if (MaximumFontSize < MinimumFontSize)
                throw new InvalidOperationException("Maximum Font Size must be greater than or equal to Minimum Font Size.");
            if (XStep <= 0)
                throw new InvalidOperationException("X Step must be greater than zero.");
            if (YStep <= 0)
                throw new InvalidOperationException("Y Step must be greater than zero.");
            if (Alphabet.Trim().Length == 0)
                throw new InvalidOperationException("Alphabet must contain at least one non-whitespace character.");
            if (Scatter < 0)
                throw new InvalidOperationException("Scatter should be greater than or equal to zero.");
        }
    }
}
