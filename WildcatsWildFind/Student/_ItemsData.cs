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
using System.Windows.Forms.PropertyGridInternal;


public class Items
{
    private String DB_connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\School\CPEPE361\project\WildcatsWildFind\WildcatsWildFind\bin\Debug\net8.0-windows\WildFind.mdb;";
    // private String projRoot = Directory.GetParent(Application.StartupPath).Parent.FullName;
    public Items(){}

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
        string query = "SELECT * FROM ReportedItems WHERE Status = @status";
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

    public void LoadItem_Type(Panel panel, String type)
    {
        // try{
            string query = "SELECT * FROM ReportedItems WHERE itemType = @itemType";
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
                        // DEBUGER :: CHECKING IF ROWS // COLUMS HAVE ITEMS
                        // if(!reader.HasRows){
                        //     MessageBox.Show("No Rows");
                        // }

                        // ADJUST THE Y/X POSITION OF THE INDICATED LABEL/IMAGE SO IT FITS THE PANEL
                        int lblXPos = 40;

                        while (reader.Read())
                        {
                            // DEBUGGING FOR INSTANCES OF items
                            // string itemName = reader["itemType"].ToString();
                            // Console.WriteLine(itemName);
                            
                            PictureBox itemImage = new PictureBox{
                                Size = new Size(50,50),
                                Location = new Point(lblXPos, 50),
                                Image = Image.FromFile(@"C:\School\CPEPE361\project\WildcatsWildFind\WildcatsWildFind\Resources\question.png"),
                                SizeMode = PictureBoxSizeMode.StretchImage,
                            };

                            Label itemLabel = new Label
                            {
                                Text = $"{reader["itemName"]}",
                                AutoSize = true,
                                Location = new Point (lblXPos, itemImage.Bottom + 5),
                                Font = new Font("Arial", 16, FontStyle.Bold),
                            };
                            panel.Controls.Add(itemLabel);
                            panel.Controls.Add(itemImage);

                            lblXPos += itemLabel.Width + 10;
                            Console.WriteLine(lblXPos + "\n");
                        }
                    }
                }
            }
        // } catch (OleDbException dbEx){
        //     // Catch specific OleDb exceptions
        //     MessageBox.Show($"Database error: {dbEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        // } catch (InvalidOperationException ioEx){
        //     // Catch invalid operation exceptions (e.g., connection issues)
        //     MessageBox.Show($"Operation error: {ioEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        // } catch (Exception ex) {
        //     // Catch any other general exceptions
        //     MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        // }
    }
}