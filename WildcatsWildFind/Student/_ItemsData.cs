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


public class Items : UserControl{
    private String DB_connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb;";

    public Items(){}

    public void AddItem_Lost(string Date, string Name, string Description, string Type){
        string query = "INSERT INTO Items (Date, Name, Description, Type) VALUES (@dateLost, @itemName, @itemDescription, @itemType)";
        //
        //  ADDING NEW DATA TO DATABASE ~ ~ ~
        //
        using (OleDbConnection connection = new OleDbConnection(DB_connString)){
            connection.Open();
            using (OleDbCommand command = new OleDbCommand(query, connection)){
                command.Parameters.AddWithValue("@dateLost", Date);
                command.Parameters.AddWithValue("@itemName", Name);
                command.Parameters.AddWithValue("@itemDescription", Description);
                command.Parameters.AddWithValue("@itemType", Type);
                command.Parameters.AddWithValue("@status", "UnClaimed");
                command.ExecuteNonQuery();
            }
        }
    }

    public void LoadItem_Status(Panel panel, String status){
        string query = "SELECT * FROM Items WHERE Status = @status";
        //
        //  CREATING NEW LABEL OBJECT AND INSERTING DATA FROM THE DATABASE -- NAME
        //  LOOKING FOR STATUS OF THE VALUE OF DATA == "CLAIMED" / "UNCLAIMED"
        //  STATUS ==> VALUE ; PARAMETER
        //  ADDING NEW LABEL TO PANEL
        //
        using(OleDbConnection connection = new OleDbConnection(DB_connString)){
            connection.Open();
            using(OleDbCommand command = new OleDbCommand(query, connection)){
                command.Parameters.AddWithValue("@status", status);
            
                using(OleDbDataReader reader = command.ExecuteReader()){
                    panel.Controls.Clear();
                    while(reader.Read()){
                        Label itemLabel = new Label{
                            Text = $"{reader["Name"]}",
                            AutoSize = true,
                        };
                        panel.Controls.Add(itemLabel);
                    }
                }
            }
        }

    }

    public void LoadItem_Type(Panel panel, String type){
        string query = "SELECT * FROM Items WHERE Status = @itemType";
        //
        //  CREATING NEW LABEL OBJECT AND INSERTING DATA FROM THE DATABASE -- NAME
        //  LOOKING FOR TYPE OF THE VALUE OF DATA == "ELECTRONICS" / "NON-ELECTRONICS"
        //  TYPE ==> VALUE ; PARAMETER
        //  ADDING NEW LABEL TO PANEL
        //
        using(OleDbConnection connection = new OleDbConnection(DB_connString)){
            connection.Open();
            using(OleDbCommand command = new OleDbCommand(query, connection)){
                command.Parameters.AddWithValue("@itemType", type);
            
                using(OleDbDataReader reader = command.ExecuteReader()){
                    panel.Controls.Clear();
                    while(reader.Read()){
                        Label itemLabel = new Label{
                            Text = $"{reader["Name"]}",
                            AutoSize = true,
                        };
                        panel.Controls.Add(itemLabel);
                    }
                }
            }
        }
    }


}