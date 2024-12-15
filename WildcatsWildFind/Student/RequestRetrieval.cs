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
            new HomePage().Show();
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
            try
            {
                
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=WildFind.mdb;";

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    
                    string query = "INSERT INTO RequestRetrieval (studentName, emailAddress, itemName, itemType, itemDescription, dateLost) " +
                                   "VALUES (@Name, @Mail, @ItemName, @ItemType, @ItemDesc, @DateLost)";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        
                        command.Parameters.AddWithValue("@Name", tbxName.Text);
                        command.Parameters.AddWithValue("@Mail", tbxMail.Text);
                        command.Parameters.AddWithValue("@ItemName", itemLbl.Text);
                        command.Parameters.AddWithValue("@ItemType", typeLbl.Text);
                        command.Parameters.AddWithValue("@ItemDesc", tbxItemDesc.Text);
                        command.Parameters.AddWithValue("@DateLost", tbxDLost.Text);

                        
                        connection.Open();
                        command.ExecuteNonQuery();

                        MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connection.Close();
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
