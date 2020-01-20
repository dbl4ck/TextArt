using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using TextArt.Generators;
using TextArt.Options;
using TextArt.Constants;

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
            return 
                (int)
                (
                    (double)originalOther * 
                    (
                        (double)newThis / 
                        (double)originalThis
                    )
                );
        }

        internal void Generate()
        {
            ValidateArguments();

            var generator = 
                new TextArtGenerator
                (
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
            var messages = new ResourceManager(typeof(Messages));
            string messageRef = null;

            if (InputImage is null)
                messageRef = MessageRef.ELoadImageFirst;
            if (DesiredHeight < 0)
                messageRef = MessageRef.EDesiredHeightGreaterThanZero;
            if (DesiredWidth < 0)
                messageRef = MessageRef.EDesiredWidthGreaterThanZero;
            if (FontName is null | FontName == String.Empty)
                messageRef = MessageRef.EFontNotSpecified;
            if (MinimumFontSize <= 0)
                messageRef = MessageRef.EMinFontSizeGreaterThanZero;
            if (MaximumFontSize <= 0)
                messageRef = MessageRef.EMaxFontSizeGreaterThanZero;
            if (MaximumFontSize < MinimumFontSize)
                messageRef = MessageRef.EMaxFontSizeGreaterThanMinFontSize;
            if (XStep <= 0)
                messageRef = MessageRef.EXStepGreaterThanZero;
            if (YStep <= 0)
                messageRef = MessageRef.EYStepGreaterThanZero;
            if (Alphabet.Trim().Length == 0)
                messageRef = MessageRef.EAlphabetIsNullOrEmpty;
            if (Scatter < 0)
                messageRef = MessageRef.EScatterGreaterThanZero;

            if (messageRef != null)
            {
                throw new InvalidOperationException
                (
                    messages.GetString(messageRef)
                );
            }
        }
    }
}
