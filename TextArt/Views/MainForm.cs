using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextArt.ViewModels;

namespace TextArt.Views
{
    public partial class MainForm : Form
    {

        private MainFormViewModel m_viewmodel { get; set; }

        public MainForm()
        {
            InitializeComponent();
            
        }

        public MainForm(MainFormViewModel viewmodel) : this()
        {
            m_viewmodel = viewmodel;
            ViewModelBinding.DataSource = m_viewmodel;
        }

        private void btnLoadImageFromFile_Click(object sender, EventArgs e)
        {
            var dialog = dlgLoadImage;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var image = Image.FromFile(dialog.FileName);
                SetOriginalImage(image);
            }

        }

        private void SetOriginalImage(Image image)
        {
            m_viewmodel.InputImage = image;
            m_viewmodel.DesiredHeight = image.Height;
            m_viewmodel.DesiredWidth = image.Width;

            RefreshBindings();

            tcImages.SelectedTab = tabOriginalImage;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            m_viewmodel.Generate();
            RefreshBindings();
        }

        private void RefreshBindings()
        {
            ViewModelBinding.ResetBindings(true);
            tcImages.SelectedTab = tabGeneratedImage;
        }

        private void btnLoadImageFromURL_Click(object sender, EventArgs e)
        {
            var dlg = new LoadImageFromURLDialog(new LoadImageFromURLDialogViewModel());

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                SetOriginalImage(dlg.Image);
            }
        }
    }
}
