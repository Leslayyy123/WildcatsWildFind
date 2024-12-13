using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WildcatsWildFind
{
    public partial class SearchLostItem : Form
    {
        bool FilterbarExpand;
        public SearchLostItem()
        {
            InitializeComponent();
        }

        private void FilterItemTimer_Tick(object sender, EventArgs e)
        {
            if (FilterbarExpand)
            {
                plFilterItemBar.Height -= 10;
                if (plFilterItemBar.Height == plFilterItemBar.MinimumSize.Height)
                {
                    FilterbarExpand = false;
                    FilterItemTimer.Stop();
                }
            }
            else
            {
                plFilterItemBar.Height += 10;
                if (plFilterItemBar.Height == plFilterItemBar.MaximumSize.Height)
                {
                    FilterbarExpand = true;
                    FilterItemTimer.Stop();
                }
            }
        }

        private void pbxFilterItem_Click(object sender, EventArgs e)
        {
            FilterItemTimer.Start();
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbxMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void plFilterItemBar_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
