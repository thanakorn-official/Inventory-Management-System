using Microsoft.Data.SqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Warehouse_Management_System
{
    public partial class Category_Edit : Form
    {
        private Category _Load_Category_Form;
        private string placeholderText;

        public Category_Edit(Category Load_Category_Form)
        {
            InitializeComponent();
            _Load_Category_Form = Load_Category_Form;
            placeholderText = NameEdit_textBox.Text;

            this.Click += (s, e) => { this.ActiveControl = null; };
            if (Main_flowLayoutPanel != null) Main_flowLayoutPanel.Click += (s, e) => { this.ActiveControl = null; };
            if (Bottom_panel != null) Bottom_panel.Click += (s, e) => { this.ActiveControl = null; };
            Title_label.Click += (s, e) => { this.ActiveControl = null; };
            Name_label.Click += (s, e) => { this.ActiveControl = null; };
            ID_label.Click += (s, e) => { this.ActiveControl = null; };

            this.Activated += (s, e) => { this.ActiveControl = null; };
        }

        private void Enter_Textbox(object sender, EventArgs e)
        {
            if (NameEdit_textBox.Text == placeholderText)
            {
                NameEdit_textBox.Text = "";
            }
            NameEdit_textBox.ForeColor = Color.Black;
        }

        private void Leave_Textbox(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameEdit_textBox.Text))
            {
                NameEdit_textBox.Text = placeholderText;
                NameEdit_textBox.ForeColor = Color.DarkGray;
            }
        }

        private void Save_Button(object sender, EventArgs e)
        {
            if (ID_label.Tag == null) return;
            int targetID = int.Parse(ID_label.Tag.ToString());
            string newName = NameEdit_textBox.Text.Trim();

            if (string.IsNullOrEmpty(newName) || newName == placeholderText)
            {
                MessageBox.Show("Category name cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Storage;Integrated Security=True;";
            string query = "UPDATE Category SET CategoryName = @NewName WHERE CategoryID = @ID";

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    connect.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@NewName", newName);
                        cmd.Parameters.AddWithValue("@ID", targetID);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            _Load_Category_Form.Load_Data(targetID);
                            this.Close();
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show("Error updating: " + ex.Message); }
            }
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            if (ID_label.Tag == null) return;
            int targetID = int.Parse(ID_label.Tag.ToString());

            DialogResult dialogResult = MessageBox.Show("Do you want to Delete this category?", "Delete Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Storage;Integrated Security=True;";
                string query = "DELETE FROM Category WHERE CategoryID = @ID";

                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    try
                    {
                        connect.Open();
                        using (SqlCommand cmd = new SqlCommand(query, connect))
                        {
                            cmd.Parameters.AddWithValue("@ID", targetID);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                Control[] foundPanels = _Load_Category_Form.Main_flowLayoutPanel.Controls.Find("Item_Card_" + targetID, true);

                                if (foundPanels.Length > 0)
                                {
                                    _Load_Category_Form.Main_flowLayoutPanel.Controls.Remove(foundPanels[0]);
                                    foundPanels[0].Dispose();
                                }

                                this.Close();
                            }
                        }
                    }
                    catch (Exception ex) { MessageBox.Show("Error deleting: " + ex.Message); }
                }
            }
        }

        private void Cancel_Button(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}