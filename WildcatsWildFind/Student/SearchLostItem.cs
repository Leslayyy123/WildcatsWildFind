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

        private void pbxFilterItem_Click(object sender, EventArgs e)
        {
            FilterItemTimer.Start();
        }
    }
}
