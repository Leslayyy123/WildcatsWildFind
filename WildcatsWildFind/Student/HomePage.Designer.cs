namespace WildcatsWildFind
{
    partial class HomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pbxClose = new PictureBox();
            pbxMax = new PictureBox();
            pbxMin = new PictureBox();
            guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)pbxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxMin).BeginInit();
            SuspendLayout();
            // 
            // pbxClose
            // 
            pbxClose.BackColor = Color.Transparent;
            pbxClose.BackgroundImage = Properties.Resources.close__2_;
            pbxClose.BackgroundImageLayout = ImageLayout.Stretch;
            pbxClose.Location = new Point(1403, 14);
            pbxClose.Name = "pbxClose";
            pbxClose.Size = new Size(25, 25);
            pbxClose.TabIndex = 10;
            pbxClose.TabStop = false;
            pbxClose.Click += pbxClose_Click;
            // 
            // pbxMax
            // 
            pbxMax.BackColor = Color.Transparent;
            pbxMax.BackgroundImage = (Image)resources.GetObject("pbxMax.BackgroundImage");
            pbxMax.BackgroundImageLayout = ImageLayout.Stretch;
            pbxMax.Location = new Point(1364, 12);
            pbxMax.Name = "pbxMax";
            pbxMax.Size = new Size(24, 28);
            pbxMax.TabIndex = 11;
            pbxMax.TabStop = false;
            pbxMax.Click += pbxMax_Click;
            // 
            // pbxMin
            // 
            pbxMin.BackColor = Color.Transparent;
            pbxMin.BackgroundImage = (Image)resources.GetObject("pbxMin.BackgroundImage");
            pbxMin.BackgroundImageLayout = ImageLayout.Stretch;
            pbxMin.Location = new Point(1325, 12);
            pbxMin.Name = "pbxMin";
            pbxMin.Size = new Size(24, 28);
            pbxMin.TabIndex = 12;
            pbxMin.TabStop = false;
            pbxMin.Click += pbxMin_Click;
            // 
            // guna2GradientButton1
            // 
            guna2GradientButton1.BackColor = Color.Transparent;
            guna2GradientButton1.BorderColor = Color.Transparent;
            guna2GradientButton1.BorderRadius = 15;
            guna2GradientButton1.CustomizableEdges = customizableEdges1;
            guna2GradientButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2GradientButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2GradientButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2GradientButton1.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            guna2GradientButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2GradientButton1.FillColor = Color.Gold;
            guna2GradientButton1.FillColor2 = Color.FromArgb(153, 129, 0);
            guna2GradientButton1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2GradientButton1.ForeColor = Color.White;
            guna2GradientButton1.Location = new Point(563, 738);
            guna2GradientButton1.Name = "guna2GradientButton1";
            guna2GradientButton1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2GradientButton1.Size = new Size(336, 60);
            guna2GradientButton1.TabIndex = 15;
            guna2GradientButton1.Text = "Go to Dashboard";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Home_Page__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1440, 1024);
            Controls.Add(pbxMin);
            Controls.Add(pbxMax);
            Controls.Add(pbxClose);
            Controls.Add(guna2GradientButton1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomePage";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxMin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbxClose;
        private PictureBox pbxMax;
        private PictureBox pbxMin;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
    }
}
