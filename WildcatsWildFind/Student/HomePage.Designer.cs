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
            btnDashboard = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)pbxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxMin).BeginInit();
            SuspendLayout();
            // 
            // pbxClose
            // 
            pbxClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbxClose.BackColor = Color.Transparent;
            pbxClose.BackgroundImage = Properties.Resources.close__2_;
            pbxClose.BackgroundImageLayout = ImageLayout.Stretch;
            pbxClose.Location = new Point(1403, 13);
            pbxClose.Name = "pbxClose";
            pbxClose.Size = new Size(25, 25);
            pbxClose.TabIndex = 10;
            pbxClose.TabStop = false;
            pbxClose.Click += pbxClose_Click;
            // 
            // pbxMax
            // 
            pbxMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbxMax.BackColor = Color.Transparent;
            pbxMax.BackgroundImage = (Image)resources.GetObject("pbxMax.BackgroundImage");
            pbxMax.BackgroundImageLayout = ImageLayout.Stretch;
            pbxMax.Location = new Point(1365, 12);
            pbxMax.Name = "pbxMax";
            pbxMax.Size = new Size(24, 28);
            pbxMax.TabIndex = 11;
            pbxMax.TabStop = false;
            pbxMax.Click += pbxMax_Click;
            // 
            // pbxMin
            // 
            pbxMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            // btnDashboard
            // 
            btnDashboard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.BorderColor = Color.Transparent;
            btnDashboard.BorderRadius = 15;
            btnDashboard.CustomizableEdges = customizableEdges1;
            btnDashboard.DisabledState.BorderColor = Color.DarkGray;
            btnDashboard.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDashboard.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDashboard.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnDashboard.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDashboard.FillColor = Color.Gold;
            btnDashboard.FillColor2 = Color.FromArgb(153, 129, 0);
            btnDashboard.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(563, 739);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnDashboard.Size = new Size(336, 60);
            btnDashboard.TabIndex = 15;
            btnDashboard.Text = "Go to Dashboard";
            btnDashboard.Click += guna2GradientButton1_Click;
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
            Controls.Add(btnDashboard);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomePage";
            Padding = new Padding(10, 11, 10, 11);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += HomePage_Load;
            ((System.ComponentModel.ISupportInitialize)pbxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxMin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbxClose;
        private PictureBox pbxMax;
        private PictureBox pbxMin;
        private Guna.UI2.WinForms.Guna2GradientButton btnDashboard;
    }
}
