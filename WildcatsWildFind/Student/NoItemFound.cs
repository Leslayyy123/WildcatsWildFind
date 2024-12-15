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
        // BOOLEAN : TRACK STATE OF FILTER BAR "FilterbarExpand"
        // CONSTRUCTOR INITIALIZED 
        bool FilterbarExpand;
        public NoItemFound()
        {
            InitializeComponent();
        }
        // HANDLER FOR FILTER BAR'S ANIMATION
        // condition:
        // if:
        // the filter bar is expanded, reduce its height gradually
        // timer stop when it reach minimum height
        // else: 
        //  increase height gradually
        //  Stop when it reaches the maximum height
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
        // ANIMATE THE FILTER BAR
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FilterItemTimer.Start();
        }
        // WINDOW EVENT HANDLER : MAX SCREEN SIZE, MIN SCREEN SIZE, CLOSE
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
    }
}
