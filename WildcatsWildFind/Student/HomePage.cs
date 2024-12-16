using System.Data.OleDb;
using WildcatsWildFind.Student;

namespace WildcatsWildFind
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
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

        private void HomePage_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            
            try
            {

                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=WildFind.mdb;";

                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    
                    string query = "SELECT COUNT(*) FROM ReportedItems";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        conn.Open();

                        int itemCount = (int)cmd.ExecuteScalar();
                        conn.Close();

                        if (itemCount == 0)
                        {
                            
                            NoItemFound notFoundForm = new NoItemFound();
                            notFoundForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            SearchLostItem searchlostitem = new SearchLostItem();
                            searchlostitem.Show();
                            this.Hide();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while checking ReportedItems: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            
            
        }
    }
}
