using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.OleDb;


public class Items : UserControl
{
    private String DB_connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb;";



    public void AddItem_Lost(string Date, string Name, string Description, string Type)
    {
        string query = "INSERT INTO Items (Date, Name, Description, Type) VALUES (@dateLost, @itemName, @itemDescription, @itemType)";
        //
        //  ADDING NEW DATA TO DATABASE ~ ~ ~
        //
        using (OleDbConnection connection = new OleDbConnection(DB_connString))
        {
            connection.Open();
            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                command.Parameters.AddWithValue("@dateLost", Date);
                command.Parameters.AddWithValue("@itemName", Name);
                command.Parameters.AddWithValue("@itemDescription", Description);
                command.Parameters.AddWithValue("@itemType", Type);
                command.Parameters.AddWithValue("@status", "UnClaimed");
                command.ExecuteNonQuery();
            }
        }
    }

    public void LoadItem_Status(Panel panel, String status)
    {
        string query = "SELECT * FROM Items WHERE Status = @status";
        //
        //  CREATING NEW LABEL OBJECT AND INSERTING DATA FROM THE DATABASE -- NAME
        //  LOOKING FOR STATUS OF THE VALUE OF DATA == "CLAIMED" / "UNCLAIMED"
        //  STATUS ==> VALUE ; PARAMETER
        //  ADDING NEW LABEL TO PANEL
        //
        using (OleDbConnection connection = new OleDbConnection(DB_connString))
        {
            connection.Open();
            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                command.Parameters.AddWithValue("@status", status);

                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    panel.Controls.Clear();
                    while (reader.Read())
                    {
                        Label itemLabel = new Label
                        {
                            Text = $"{reader["Name"]}",
                            AutoSize = true,
                        };
                        panel.Controls.Add(itemLabel);
                    }
                }
            }
        }

    }

    private void InitializeComponent()
    {
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
        btnRetrieve = new Guna.UI2.WinForms.Guna2GradientButton();
        lblItem = new Label();
        lblCounter = new Label();
        pbxImage = new Guna.UI2.WinForms.Guna2PictureBox();
        guna2ShadowPanel1.SuspendLayout();
        ((ISupportInitialize)pbxImage).BeginInit();
        SuspendLayout();
        // 
        // guna2ShadowPanel1
        // 
        guna2ShadowPanel1.BackColor = Color.Transparent;
        guna2ShadowPanel1.Controls.Add(lblCounter);
        guna2ShadowPanel1.Controls.Add(btnRetrieve);
        guna2ShadowPanel1.Controls.Add(lblItem);
        guna2ShadowPanel1.FillColor = Color.White;
        guna2ShadowPanel1.Location = new Point(0, 133);
        guna2ShadowPanel1.Name = "guna2ShadowPanel1";
        guna2ShadowPanel1.Radius = 11;
        guna2ShadowPanel1.ShadowColor = Color.Black;
        guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
        guna2ShadowPanel1.Size = new Size(235, 57);
        guna2ShadowPanel1.TabIndex = 1;

        // 
        // btnRetrieve
        // 
        btnRetrieve.Anchor = AnchorStyles.Left;
        btnRetrieve.BackColor = Color.Transparent;
        btnRetrieve.BorderColor = Color.Transparent;
        btnRetrieve.BorderRadius = 5;
        btnRetrieve.CustomizableEdges = customizableEdges5;
        btnRetrieve.DisabledState.BorderColor = Color.DarkGray;
        btnRetrieve.DisabledState.CustomBorderColor = Color.DarkGray;
        btnRetrieve.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        btnRetrieve.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
        btnRetrieve.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        btnRetrieve.FillColor = Color.FromArgb(177, 8, 8);
        btnRetrieve.FillColor2 = Color.FromArgb(112, 33, 33);
        btnRetrieve.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnRetrieve.ForeColor = Color.White;
        btnRetrieve.Location = new Point(141, 13);
        btnRetrieve.Margin = new Padding(3, 2, 3, 2);
        btnRetrieve.Name = "btnRetrieve";
        btnRetrieve.ShadowDecoration.CustomizableEdges = customizableEdges6;
        btnRetrieve.Size = new Size(79, 25);
        btnRetrieve.TabIndex = 23;
        btnRetrieve.Text = "Retrieve";
        // 
        // lblItem
        // 
        lblItem.AutoSize = true;
        lblItem.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblItem.Location = new Point(24, 5);
        lblItem.Name = "lblItem";
        lblItem.Size = new Size(51, 20);
        lblItem.TabIndex = 24;
        lblItem.Text = "label1";
        // 
        // lblCounter
        // 
        lblCounter.AutoSize = true;
        lblCounter.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblCounter.Location = new Point(24, 25);
        lblCounter.Name = "lblCounter";
        lblCounter.Size = new Size(38, 13);
        lblCounter.TabIndex = 25;
        lblCounter.Text = "label2";
        // 
        // pbxImage
        // 
        pbxImage.BackColor = Color.Transparent;
        pbxImage.CustomizableEdges = customizableEdges7;
        pbxImage.ImageRotate = 0F;
        pbxImage.Location = new Point(0, 0);
        pbxImage.Name = "pbxImage";
        pbxImage.ShadowDecoration.CustomizableEdges = customizableEdges8;
        pbxImage.Size = new Size(235, 179);
        pbxImage.TabIndex = 2;
        pbxImage.TabStop = false;
        pbxImage.Click += guna2PictureBox1_Click;
        // 
        // Items
        // 
        BackColor = Color.Transparent;
        Controls.Add(guna2ShadowPanel1);
        Controls.Add(pbxImage);
        Name = "Items";
        Size = new Size(235, 190);
        Load += Items_Load;
        guna2ShadowPanel1.ResumeLayout(false);
        guna2ShadowPanel1.PerformLayout();
        ((ISupportInitialize)pbxImage).EndInit();
        ResumeLayout(false);
    }

    public void LoadItem_Type(Panel panel, String type)
    {
        string query = "SELECT * FROM Items WHERE Status = @itemType";
        //
        //  CREATING NEW LABEL OBJECT AND INSERTING DATA FROM THE DATABASE -- NAME
        //  LOOKING FOR TYPE OF THE VALUE OF DATA == "ELECTRONICS" / "NON-ELECTRONICS"
        //  TYPE ==> VALUE ; PARAMETER
        //  ADDING NEW LABEL TO PANEL
        //
        using (OleDbConnection connection = new OleDbConnection(DB_connString))
        {
            connection.Open();
            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                command.Parameters.AddWithValue("@itemType", type);

                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    panel.Controls.Clear();
                    while (reader.Read())
                    {
                        Label itemLabel = new Label
                        {
                            Text = $"{reader["Name"]}",
                            AutoSize = true,
                        };
                        panel.Controls.Add(itemLabel);
                    }
                }
            }
        }
    }



    private void guna2PictureBox1_Click(object sender, EventArgs e)
    {

    }

    private void Items_Load(object sender, EventArgs e)
    {

    }

    private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
    private Guna.UI2.WinForms.Guna2GradientButton btnRetrieve;
    private Label lblCounter;
    private Guna.UI2.WinForms.Guna2PictureBox pbxImage;
    private Label lblItem;
}