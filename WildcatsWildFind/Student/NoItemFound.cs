using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WildcatsWildFind.Student
{
    public partial class NoItemFound : Form
    {
        bool FilterbarExpand;
        public NoItemFound()
        {
            InitializeComponent();
        }

        private void FilterItemTimer_Tick(object sender, EventArgs e)
        {
            if (FilterbarExpand)
            {
                gunaFilterItemBar.Height -= 10;
                if (gunaFilterItemBar.Height == gunaFilterItemBar.MinimumSize.Height)
                {
                    FilterbarExpand = false;
                    FilterItemTimer.Stop();
                }
            }
            else
            {
                gunaFilterItemBar.Height += 10;
                if (gunaFilterItemBar.Height == gunaFilterItemBar.MaximumSize.Height)
                {
                    FilterbarExpand = true;
                    FilterItemTimer.Stop();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FilterItemTimer.Start();
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbxMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void pbxMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRequestRetrieval_Click(object sender, EventArgs e)
        {
            new RequestRetrieval().Show();
            this.Hide();
        }
    }
}
