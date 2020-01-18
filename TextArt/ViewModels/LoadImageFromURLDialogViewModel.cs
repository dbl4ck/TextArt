using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextArt.ViewModels
{
    public class LoadImageFromURLDialogViewModel
    {
        public Uri Uri { get; set; }

        public Image Image { get; set; }
    }
}
