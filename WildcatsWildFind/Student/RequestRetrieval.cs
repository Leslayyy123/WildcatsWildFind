using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WildcatsWildFind
{
    public partial class RequestRetrieval : Form
    {
        public RequestRetrieval()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RequestRetrieval_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new SearchLostItem().Show();
            this.Hide();
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxName.Text) ||
                string.IsNullOrWhiteSpace(tbxMail.Text) ||
                string.IsNullOrWhiteSpace(tbxItemDesc.Text) ||
                string.IsNullOrWhiteSpace(tbxDLost.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!DateTime.TryParseExact(tbxDLost.Text, "MM/dd/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dateLost))
            {
                MessageBox.Show("Invalid date format. Please use MM/DD/YYYY.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dateLost > DateTime.Now)
            {
                MessageBox.Show("The date lost cannot be in the future.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                byte[] photoBytes = null;
                if (picItem.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        picItem.Image.Save(ms, picItem.Image.RawFormat);
                        photoBytes = ms.ToArray();
                    }
                }
                



                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=WildFind.mdb;";

                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    
                    string query = "INSERT INTO RequestRetrieval (studentName, emailAddress, itemName, itemType, itemDescription, dateLost,photo) " +
                                   "VALUES (@Name, @Mail, @ItemName, @ItemType, @ItemDesc, @DateLost,@Photo)";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@Name", tbxName.Text);
                        cmd.Parameters.AddWithValue("@Mail", tbxMail.Text);
                        cmd.Parameters.AddWithValue("@ItemName", itemLbl.Text);
                        cmd.Parameters.AddWithValue("@ItemType", typeLbl.Text);
                        cmd.Parameters.AddWithValue("@ItemDesc", tbxItemDesc.Text);
                        cmd.Parameters.AddWithValue("@DateLost", tbxDLost.Text);
                        if (picItem.Image != null)
                        {
                            cmd.Parameters.AddWithValue("@Photo", picItem.Image);
                        }
                        

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    picItem.Image = Image.FromFile(openFileDialog.FileName);
                }
            }

        }
    }
}
