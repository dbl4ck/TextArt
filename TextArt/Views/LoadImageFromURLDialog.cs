using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextArt.ViewModels;

namespace TextArt.Views
{
    public partial class LoadImageFromURLDialog : Form
    {
        private LoadImageFromURLDialogViewModel m_viewmodel { get; set; }

        public LoadImageFromURLDialog()
        {
            InitializeComponent();
        }

        public LoadImageFromURLDialog(LoadImageFromURLDialogViewModel viewmodel) : this()
        {
            m_viewmodel = viewmodel;
            ViewModelBinding.DataSource = m_viewmodel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var uri = m_viewmodel.Uri;

            if (uri == null || !uri.IsAbsoluteUri)
            {
                this.DialogResult = DialogResult.Cancel;
            }
            else
            {
                m_viewmodel.Image = DownloadImage();
                this.DialogResult = DialogResult.OK;
            }

            this.FindForm().Close();
        }

        private Image DownloadImage()
        {
            Stream stream = null;

            using (var client = new HttpClient())
            {
                var worker = client.GetStreamAsync(m_viewmodel.Uri);
                worker.Wait();

                if (worker.IsCompleted)
                {
                    stream = worker.Result;
                }
            }

            return Image.FromStream(stream);
        }

        public Image Image
        {
            get
            {
                return m_viewmodel.Image;
            }
        }
    }
}
