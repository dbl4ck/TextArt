using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextArt.ViewModels;
using System.Drawing;

namespace TextArt.Factories
{
    public class Form1ViewModelFactory
    {
        public ViewModels.MainFormViewModel Create()
        {
            return new MainFormViewModel()
            {
                BackgroundColor = Color.Black,
                MaximumFontSize = 40,
                MinimumFontSize = 10,
                DesiredWidth = 800,
                DesiredHeight = 600,
                LockAspectRatio = true,
                FontName = "Arial",
                XStep = 20,
                YStep = 20,
                Alphabet = "abcdefghijklmnopqrstuvwxyz"
            };
        }
    }
}
