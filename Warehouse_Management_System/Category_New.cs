using Microsoft.Data.SqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Warehouse_Management_System
{
    public partial class Category_New : Form
    {
        private Category _Load_Category_Form;
        private string placeholderText = "";

        public Category_New(Category Load_Category_Form)
        {
            InitializeComponent();
            _Load_Category_Form = Load_Category_Form;

            placeholderText = NameEdit_textBox.Text;

            int nextID = GetNextCategoryID();
            ID_label.Text = "ID: " + nextID.ToString();
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

        private int GetNextCategoryID()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Storage;Integrated Security=True;";
            string query = "SELECT ISNULL(MAX(CategoryID), 0) + 1 FROM Category";

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    connect.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            return Convert.ToInt32(result);
                        }
                    }
                }
                catch (Exception) { return 1; }
            }
            return 1;
        }

        private void Create_Button(object sender, EventArgs e)
        {
            string newName = NameEdit_textBox.Text.Trim();

            if (string.IsNullOrEmpty(newName) || newName == placeholderText)
            {
                MessageBox.Show("Please enter a valid Category Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Storage;Integrated Security=True;";
            string query = "INSERT INTO Category(CategoryName) OUTPUT INSERTED.CategoryID VALUES(@NewName)";

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    connect.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@NewName", newName);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            int newID = Convert.ToInt32(result);

                            _Load_Category_Form.Load_Data(null);
                            this.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Cancel_Button(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}