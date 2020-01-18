namespace TextArt.Views
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtDesiredWidth = new System.Windows.Forms.TextBox();
            this.txtDesiredHeight = new System.Windows.Forms.TextBox();
            this.lblDesiredWidth = new System.Windows.Forms.Label();
            this.lblDesiredHeight = new System.Windows.Forms.Label();
            this.btnLoadImageFromFile = new System.Windows.Forms.Button();
            this.chkConstrainAspectRatio = new System.Windows.Forms.CheckBox();
            this.dlgLoadImage = new System.Windows.Forms.OpenFileDialog();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.tcImages = new System.Windows.Forms.TabControl();
            this.tabOriginalImage = new System.Windows.Forms.TabPage();
            this.pbOriginalImage = new System.Windows.Forms.PictureBox();
            this.tabGeneratedImage = new System.Windows.Forms.TabPage();
            this.pbGeneratedImage = new System.Windows.Forms.PictureBox();
            this.lblMaxFontSize = new System.Windows.Forms.Label();
            this.lblMinFontSize = new System.Windows.Forms.Label();
            this.txtMaxFontSize = new System.Windows.Forms.TextBox();
            this.txtMinFontSize = new System.Windows.Forms.TextBox();
            this.lblFontName = new System.Windows.Forms.Label();
            this.txtFontName = new System.Windows.Forms.TextBox();
            this.btnLoadImageFromURL = new System.Windows.Forms.Button();
            this.grpLoadImage = new System.Windows.Forms.GroupBox();
            this.lblYStep = new System.Windows.Forms.Label();
            this.txtYStep = new System.Windows.Forms.TextBox();
            this.lblXStep = new System.Windows.Forms.Label();
            this.txtXStep = new System.Windows.Forms.TextBox();
            this.lblAlphabet = new System.Windows.Forms.Label();
            this.txtAlphabet = new System.Windows.Forms.TextBox();
            this.lblRandomSeed = new System.Windows.Forms.Label();
            this.txtRandomSeed = new System.Windows.Forms.TextBox();
            this.ViewModelBinding = new System.Windows.Forms.BindingSource(this.components);
            this.tcImages.SuspendLayout();
            this.tabOriginalImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginalImage)).BeginInit();
            this.tabGeneratedImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGeneratedImage)).BeginInit();
            this.grpLoadImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewModelBinding)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDesiredWidth
            // 
            this.txtDesiredWidth.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ViewModelBinding, "DesiredWidth", true));
            this.txtDesiredWidth.Location = new System.Drawing.Point(203, 230);
            this.txtDesiredWidth.Name = "txtDesiredWidth";
            this.txtDesiredWidth.Size = new System.Drawing.Size(100, 31);
            this.txtDesiredWidth.TabIndex = 0;
            // 
            // txtDesiredHeight
            // 
            this.txtDesiredHeight.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ViewModelBinding, "DesiredHeight", true));
            this.txtDesiredHeight.Location = new System.Drawing.Point(203, 281);
            this.txtDesiredHeight.Name = "txtDesiredHeight";
            this.txtDesiredHeight.Size = new System.Drawing.Size(100, 31);
            this.txtDesiredHeight.TabIndex = 1;
            // 
            // lblDesiredWidth
            // 
            this.lblDesiredWidth.AutoSize = true;
            this.lblDesiredWidth.Location = new System.Drawing.Point(37, 233);
            this.lblDesiredWidth.Name = "lblDesiredWidth";
            this.lblDesiredWidth.Size = new System.Drawing.Size(153, 25);
            this.lblDesiredWidth.TabIndex = 2;
            this.lblDesiredWidth.Text = "Desired Width:";
            // 
            // lblDesiredHeight
            // 
            this.lblDesiredHeight.AutoSize = true;
            this.lblDesiredHeight.Location = new System.Drawing.Point(37, 284);
            this.lblDesiredHeight.Name = "lblDesiredHeight";
            this.lblDesiredHeight.Size = new System.Drawing.Size(160, 25);
            this.lblDesiredHeight.TabIndex = 3;
            this.lblDesiredHeight.Text = "Desired Height:";
            // 
            // btnLoadImageFromFile
            // 
            this.btnLoadImageFromFile.Location = new System.Drawing.Point(17, 42);
            this.btnLoadImageFromFile.Name = "btnLoadImageFromFile";
            this.btnLoadImageFromFile.Size = new System.Drawing.Size(225, 63);
            this.btnLoadImageFromFile.TabIndex = 4;
            this.btnLoadImageFromFile.Text = "From File";
            this.btnLoadImageFromFile.UseVisualStyleBackColor = true;
            this.btnLoadImageFromFile.Click += new System.EventHandler(this.btnLoadImageFromFile_Click);
            // 
            // chkConstrainAspectRatio
            // 
            this.chkConstrainAspectRatio.AutoSize = true;
            this.chkConstrainAspectRatio.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.ViewModelBinding, "LockAspectRatio", true));
            this.chkConstrainAspectRatio.Location = new System.Drawing.Point(40, 339);
            this.chkConstrainAspectRatio.Name = "chkConstrainAspectRatio";
            this.chkConstrainAspectRatio.Size = new System.Drawing.Size(264, 29);
            this.chkConstrainAspectRatio.TabIndex = 5;
            this.chkConstrainAspectRatio.Text = "Constrain Aspect Ratio";
            this.chkConstrainAspectRatio.UseVisualStyleBackColor = true;
            // 
            // dlgLoadImage
            // 
            this.dlgLoadImage.Filter = "Image Files|*.png;*.jpg";
            this.dlgLoadImage.Title = "Load Image";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(42, 892);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(261, 77);
            this.btnGenerate.TabIndex = 7;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // tcImages
            // 
            this.tcImages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcImages.Controls.Add(this.tabOriginalImage);
            this.tcImages.Controls.Add(this.tabGeneratedImage);
            this.tcImages.Location = new System.Drawing.Point(346, 12);
            this.tcImages.Name = "tcImages";
            this.tcImages.SelectedIndex = 0;
            this.tcImages.Size = new System.Drawing.Size(1340, 1119);
            this.tcImages.TabIndex = 9;
            // 
            // tabOriginalImage
            // 
            this.tabOriginalImage.AutoScroll = true;
            this.tabOriginalImage.Controls.Add(this.pbOriginalImage);
            this.tabOriginalImage.Location = new System.Drawing.Point(8, 39);
            this.tabOriginalImage.Name = "tabOriginalImage";
            this.tabOriginalImage.Padding = new System.Windows.Forms.Padding(3);
            this.tabOriginalImage.Size = new System.Drawing.Size(1324, 1072);
            this.tabOriginalImage.TabIndex = 0;
            this.tabOriginalImage.Text = "Original";
            this.tabOriginalImage.UseVisualStyleBackColor = true;
            // 
            // pbOriginalImage
            // 
            this.pbOriginalImage.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.ViewModelBinding, "InputImage", true));
            this.pbOriginalImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbOriginalImage.Location = new System.Drawing.Point(3, 3);
            this.pbOriginalImage.Name = "pbOriginalImage";
            this.pbOriginalImage.Size = new System.Drawing.Size(1318, 1066);
            this.pbOriginalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbOriginalImage.TabIndex = 9;
            this.pbOriginalImage.TabStop = false;
            // 
            // tabGeneratedImage
            // 
            this.tabGeneratedImage.AutoScroll = true;
            this.tabGeneratedImage.Controls.Add(this.pbGeneratedImage);
            this.tabGeneratedImage.Location = new System.Drawing.Point(8, 39);
            this.tabGeneratedImage.Name = "tabGeneratedImage";
            this.tabGeneratedImage.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneratedImage.Size = new System.Drawing.Size(1324, 1072);
            this.tabGeneratedImage.TabIndex = 1;
            this.tabGeneratedImage.Text = "Generated";
            this.tabGeneratedImage.UseVisualStyleBackColor = true;
            // 
            // pbGeneratedImage
            // 
            this.pbGeneratedImage.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.ViewModelBinding, "OutputImage", true));
            this.pbGeneratedImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbGeneratedImage.Location = new System.Drawing.Point(3, 3);
            this.pbGeneratedImage.Name = "pbGeneratedImage";
            this.pbGeneratedImage.Size = new System.Drawing.Size(1318, 1066);
            this.pbGeneratedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbGeneratedImage.TabIndex = 10;
            this.pbGeneratedImage.TabStop = false;
            // 
            // lblMaxFontSize
            // 
            this.lblMaxFontSize.AutoSize = true;
            this.lblMaxFontSize.Location = new System.Drawing.Point(37, 459);
            this.lblMaxFontSize.Name = "lblMaxFontSize";
            this.lblMaxFontSize.Size = new System.Drawing.Size(162, 25);
            this.lblMaxFontSize.TabIndex = 13;
            this.lblMaxFontSize.Text = "Max. Font Size:";
            // 
            // lblMinFontSize
            // 
            this.lblMinFontSize.AutoSize = true;
            this.lblMinFontSize.Location = new System.Drawing.Point(37, 408);
            this.lblMinFontSize.Name = "lblMinFontSize";
            this.lblMinFontSize.Size = new System.Drawing.Size(156, 25);
            this.lblMinFontSize.TabIndex = 12;
            this.lblMinFontSize.Text = "Min. Font Size:";
            // 
            // txtMaxFontSize
            // 
            this.txtMaxFontSize.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ViewModelBinding, "MaximumFontSize", true));
            this.txtMaxFontSize.Location = new System.Drawing.Point(203, 456);
            this.txtMaxFontSize.Name = "txtMaxFontSize";
            this.txtMaxFontSize.Size = new System.Drawing.Size(100, 31);
            this.txtMaxFontSize.TabIndex = 11;
            // 
            // txtMinFontSize
            // 
            this.txtMinFontSize.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ViewModelBinding, "MinimumFontSize", true));
            this.txtMinFontSize.Location = new System.Drawing.Point(203, 405);
            this.txtMinFontSize.Name = "txtMinFontSize";
            this.txtMinFontSize.Size = new System.Drawing.Size(100, 31);
            this.txtMinFontSize.TabIndex = 10;
            // 
            // lblFontName
            // 
            this.lblFontName.AutoSize = true;
            this.lblFontName.Location = new System.Drawing.Point(37, 512);
            this.lblFontName.Name = "lblFontName";
            this.lblFontName.Size = new System.Drawing.Size(123, 25);
            this.lblFontName.TabIndex = 15;
            this.lblFontName.Text = "Font Name:";
            // 
            // txtFontName
            // 
            this.txtFontName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ViewModelBinding, "FontName", true));
            this.txtFontName.Location = new System.Drawing.Point(203, 509);
            this.txtFontName.Name = "txtFontName";
            this.txtFontName.Size = new System.Drawing.Size(100, 31);
            this.txtFontName.TabIndex = 14;
            // 
            // btnLoadImageFromURL
            // 
            this.btnLoadImageFromURL.Location = new System.Drawing.Point(17, 111);
            this.btnLoadImageFromURL.Name = "btnLoadImageFromURL";
            this.btnLoadImageFromURL.Size = new System.Drawing.Size(225, 63);
            this.btnLoadImageFromURL.TabIndex = 16;
            this.btnLoadImageFromURL.Text = "From URL";
            this.btnLoadImageFromURL.UseVisualStyleBackColor = true;
            this.btnLoadImageFromURL.Click += new System.EventHandler(this.btnLoadImageFromURL_Click);
            // 
            // grpLoadImage
            // 
            this.grpLoadImage.Controls.Add(this.btnLoadImageFromFile);
            this.grpLoadImage.Controls.Add(this.btnLoadImageFromURL);
            this.grpLoadImage.Location = new System.Drawing.Point(40, 12);
            this.grpLoadImage.Name = "grpLoadImage";
            this.grpLoadImage.Size = new System.Drawing.Size(263, 191);
            this.grpLoadImage.TabIndex = 17;
            this.grpLoadImage.TabStop = false;
            this.grpLoadImage.Text = "Load Image";
            // 
            // lblYStep
            // 
            this.lblYStep.AutoSize = true;
            this.lblYStep.Location = new System.Drawing.Point(37, 618);
            this.lblYStep.Name = "lblYStep";
            this.lblYStep.Size = new System.Drawing.Size(83, 25);
            this.lblYStep.TabIndex = 21;
            this.lblYStep.Text = "Y Step:";
            // 
            // txtYStep
            // 
            this.txtYStep.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ViewModelBinding, "YStep", true));
            this.txtYStep.Location = new System.Drawing.Point(203, 615);
            this.txtYStep.Name = "txtYStep";
            this.txtYStep.Size = new System.Drawing.Size(100, 31);
            this.txtYStep.TabIndex = 20;
            // 
            // lblXStep
            // 
            this.lblXStep.AutoSize = true;
            this.lblXStep.Location = new System.Drawing.Point(37, 565);
            this.lblXStep.Name = "lblXStep";
            this.lblXStep.Size = new System.Drawing.Size(82, 25);
            this.lblXStep.TabIndex = 19;
            this.lblXStep.Text = "X Step:";
            // 
            // txtXStep
            // 
            this.txtXStep.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ViewModelBinding, "XStep", true));
            this.txtXStep.Location = new System.Drawing.Point(203, 562);
            this.txtXStep.Name = "txtXStep";
            this.txtXStep.Size = new System.Drawing.Size(100, 31);
            this.txtXStep.TabIndex = 18;
            // 
            // lblAlphabet
            // 
            this.lblAlphabet.AutoSize = true;
            this.lblAlphabet.Location = new System.Drawing.Point(37, 673);
            this.lblAlphabet.Name = "lblAlphabet";
            this.lblAlphabet.Size = new System.Drawing.Size(103, 25);
            this.lblAlphabet.TabIndex = 23;
            this.lblAlphabet.Text = "Alphabet:";
            // 
            // txtAlphabet
            // 
            this.txtAlphabet.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ViewModelBinding, "Alphabet", true));
            this.txtAlphabet.Location = new System.Drawing.Point(40, 704);
            this.txtAlphabet.Multiline = true;
            this.txtAlphabet.Name = "txtAlphabet";
            this.txtAlphabet.Size = new System.Drawing.Size(264, 96);
            this.txtAlphabet.TabIndex = 22;
            // 
            // lblRandomSeed
            // 
            this.lblRandomSeed.AutoSize = true;
            this.lblRandomSeed.Location = new System.Drawing.Point(35, 842);
            this.lblRandomSeed.Name = "lblRandomSeed";
            this.lblRandomSeed.Size = new System.Drawing.Size(68, 25);
            this.lblRandomSeed.TabIndex = 25;
            this.lblRandomSeed.Text = "Seed:";
            // 
            // txtRandomSeed
            // 
            this.txtRandomSeed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ViewModelBinding, "RandomSeed", true));
            this.txtRandomSeed.Location = new System.Drawing.Point(201, 839);
            this.txtRandomSeed.Name = "txtRandomSeed";
            this.txtRandomSeed.Size = new System.Drawing.Size(100, 31);
            this.txtRandomSeed.TabIndex = 24;
            // 
            // ViewModelBinding
            // 
            this.ViewModelBinding.DataSource = typeof(TextArt.ViewModels.MainFormViewModel);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1698, 1143);
            this.Controls.Add(this.lblRandomSeed);
            this.Controls.Add(this.txtRandomSeed);
            this.Controls.Add(this.lblAlphabet);
            this.Controls.Add(this.txtAlphabet);
            this.Controls.Add(this.lblYStep);
            this.Controls.Add(this.txtYStep);
            this.Controls.Add(this.lblXStep);
            this.Controls.Add(this.txtXStep);
            this.Controls.Add(this.grpLoadImage);
            this.Controls.Add(this.lblFontName);
            this.Controls.Add(this.txtFontName);
            this.Controls.Add(this.lblMaxFontSize);
            this.Controls.Add(this.lblMinFontSize);
            this.Controls.Add(this.txtMaxFontSize);
            this.Controls.Add(this.txtMinFontSize);
            this.Controls.Add(this.tcImages);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.chkConstrainAspectRatio);
            this.Controls.Add(this.lblDesiredHeight);
            this.Controls.Add(this.lblDesiredWidth);
            this.Controls.Add(this.txtDesiredHeight);
            this.Controls.Add(this.txtDesiredWidth);
            this.Name = "MainForm";
            this.Text = "TextArt";
            this.tcImages.ResumeLayout(false);
            this.tabOriginalImage.ResumeLayout(false);
            this.tabOriginalImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginalImage)).EndInit();
            this.tabGeneratedImage.ResumeLayout(false);
            this.tabGeneratedImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGeneratedImage)).EndInit();
            this.grpLoadImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ViewModelBinding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource ViewModelBinding;
        private System.Windows.Forms.TextBox txtDesiredWidth;
        private System.Windows.Forms.TextBox txtDesiredHeight;
        private System.Windows.Forms.Label lblDesiredWidth;
        private System.Windows.Forms.Label lblDesiredHeight;
        private System.Windows.Forms.Button btnLoadImageFromFile;
        private System.Windows.Forms.CheckBox chkConstrainAspectRatio;
        private System.Windows.Forms.OpenFileDialog dlgLoadImage;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TabControl tcImages;
        private System.Windows.Forms.TabPage tabOriginalImage;
        private System.Windows.Forms.TabPage tabGeneratedImage;
        private System.Windows.Forms.PictureBox pbOriginalImage;
        private System.Windows.Forms.PictureBox pbGeneratedImage;
        private System.Windows.Forms.Label lblMaxFontSize;
        private System.Windows.Forms.Label lblMinFontSize;
        private System.Windows.Forms.TextBox txtMaxFontSize;
        private System.Windows.Forms.TextBox txtMinFontSize;
        private System.Windows.Forms.Label lblFontName;
        private System.Windows.Forms.TextBox txtFontName;
        private System.Windows.Forms.Button btnLoadImageFromURL;
        private System.Windows.Forms.GroupBox grpLoadImage;
        private System.Windows.Forms.Label lblYStep;
        private System.Windows.Forms.TextBox txtYStep;
        private System.Windows.Forms.Label lblXStep;
        private System.Windows.Forms.TextBox txtXStep;
        private System.Windows.Forms.Label lblAlphabet;
        private System.Windows.Forms.TextBox txtAlphabet;
        private System.Windows.Forms.Label lblRandomSeed;
        private System.Windows.Forms.TextBox txtRandomSeed;
    }
}

