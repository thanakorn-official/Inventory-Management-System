using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Warehouse_Management_System.Properties;

namespace Warehouse_Management_System
{
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();

            this.Main_flowLayoutPanel.ControlAdded -= Main_flowLayoutPanel_ControlAdded;

            Load_Data(null);

            this.Main_flowLayoutPanel.ControlAdded += Main_flowLayoutPanel_ControlAdded;
        }

        private int Create_Item(string ID_Text, string Name_Text)
        {
            Color DefaultColor = Color.White;
            Color HoverColor = Color.LightGray;

            Panel Item_Card = new Panel();
            Item_Card.Size = new Size(160, 140);
            Item_Card.BackColor = DefaultColor;
            Item_Card.Margin = new Padding(12);
            Item_Card.BorderStyle = BorderStyle.None;

            if (ID_Text == "0" && Name_Text == "Create_Card")
            {
                Item_Card.Name = Name_Text;

                PictureBox Plus_PictureBox = new PictureBox();
                Plus_PictureBox.Image = Resources.PlusNormal;
                Plus_PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                Plus_PictureBox.Size = new Size(50, 50);
                Plus_PictureBox.Location = new Point((Item_Card.Width - Plus_PictureBox.Width) / 2, (Item_Card.Height - Plus_PictureBox.Height) / 2);
                Item_Card.Controls.Add(Plus_PictureBox);

                Action openNewForm = () =>
                {
                    Category_New Category_New_Form = new Category_New(this);
                    Category_New_Form.ShowDialog();
                };

                Plus_PictureBox.Click += (s, e) => openNewForm();
                Item_Card.Click += (s, e) => openNewForm();

                Action MouseEnter = () =>
                {
                    Plus_PictureBox.Image = Resources.PlusHover;
                    Item_Card.BackColor = HoverColor;
                    Item_Card.Cursor = Cursors.Hand;
                };

                Item_Card.MouseLeave += (s, e) => {
                    Point clientMousePos = Item_Card.PointToClient(Cursor.Position);
                    if (!Item_Card.ClientRectangle.Contains(clientMousePos))
                    {
                        Plus_PictureBox.Image = Resources.PlusNormal;
                        Item_Card.BackColor = DefaultColor;
                    }
                };

                Item_Card.MouseEnter += (s, e) => MouseEnter();
                Item_Card.MouseMove += (s, e) => {
                    if (Item_Card.ClientRectangle.Contains(Item_Card.PointToClient(Cursor.Position))) MouseEnter();
                };

                Main_flowLayoutPanel.Controls.Add(Item_Card);
                Main_flowLayoutPanel.Controls.SetChildIndex(Item_Card, 0);
            }
            else
            {
                Item_Card.Name = "Item_Card_" + ID_Text;

                Label ID_Label = new Label();
                ID_Label.AutoSize = true;
                ID_Label.Location = new Point(12, 12);
                ID_Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                ID_Label.ForeColor = Color.Black;
                ID_Label.Text = "ID: " + ID_Text;
                Item_Card.Controls.Add(ID_Label);

                Label Name_Label = new Label();
                Name_Label.AutoSize = false;
                Name_Label.Size = new Size(136, 50);
                Name_Label.Location = new Point(12, 45);
                Name_Label.Font = new Font("Prompt", 11F, FontStyle.Regular);
                Name_Label.ForeColor = Color.Black;
                Name_Label.Text = Name_Text;
                Item_Card.Controls.Add(Name_Label);

                Label Edit_Label = new Label();
                Edit_Label.Name = "Edit_Button_" + ID_Text;
                Edit_Label.Text = "Edit";
                Edit_Label.TextAlign = ContentAlignment.MiddleCenter;
                Edit_Label.Size = new Size(100, 25);
                Edit_Label.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular);
                Edit_Label.BackColor = Color.Crimson;
                Edit_Label.ForeColor = Color.White;
                Edit_Label.Visible = false;
                Edit_Label.Location = new Point((Item_Card.Width - Edit_Label.Width) / 2, (Item_Card.Height - Edit_Label.Height) / 2);
                Item_Card.Controls.Add(Edit_Label);
                Edit_Label.BringToFront();

                Edit_Label.Click += (s, e) =>
                {
                    Category_Edit Category_Edit_Form = new Category_Edit(this);
                    Category_Edit_Form.Title_label.Text = "Edit " + Name_Label.Text;
                    Category_Edit_Form.ID_label.Text = "ID: " + ID_Text;
                    Category_Edit_Form.ID_label.Tag = ID_Text;
                    Category_Edit_Form.NameEdit_textBox.Text = Name_Label.Text;
                    Category_Edit_Form.NameEdit_textBox.ForeColor = Color.Black;

                    Category_Edit_Form.ShowDialog();

                    Item_Card.BackColor = DefaultColor;
                    Edit_Label.Visible = false;
                };

                Action MouseEnter = () =>
                {
                    Item_Card.BackColor = HoverColor;
                    Item_Card.Cursor = Cursors.Hand;
                    Edit_Label.Visible = true;
                };

                Action MouseLeave = () => {
                    Point clientMousePos = Item_Card.PointToClient(Cursor.Position);
                    if (!Item_Card.ClientRectangle.Contains(clientMousePos))
                    {
                        Item_Card.BackColor = DefaultColor;
                        Edit_Label.Visible = false;
                    }
                };

                Item_Card.MouseEnter += (s, e) => MouseEnter();
                ID_Label.MouseEnter += (s, e) => MouseEnter();
                Name_Label.MouseEnter += (s, e) => MouseEnter();
                Edit_Label.MouseEnter += (s, e) => MouseEnter();

                Item_Card.MouseLeave += (s, e) => MouseLeave();

                Main_flowLayoutPanel.Controls.Add(Item_Card);
            }

            return Main_flowLayoutPanel.Controls.GetChildIndex(Item_Card);
        }

        public void Load_Data(int? ID)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Storage;Integrated Security=True;";

            if (ID.HasValue)
            {
                string query = "SELECT CategoryName FROM Category WHERE CategoryID = @ID";

                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    try
                    {
                        connect.Open();
                        using (SqlCommand cmd = new SqlCommand(query, connect))
                        {
                            cmd.Parameters.AddWithValue("@ID", ID.Value);
                            object result = cmd.ExecuteScalar();
                            string updatedName = result?.ToString();

                            if (!string.IsNullOrEmpty(updatedName))
                            {
                                Control[] foundPanels = Main_flowLayoutPanel.Controls.Find("Item_Card_" + ID.Value, true);

                                if (foundPanels.Length > 0)
                                {
                                    Panel targetCard = (Panel)foundPanels[0];

                                    int originalIndex = Main_flowLayoutPanel.Controls.GetChildIndex(targetCard);

                                    targetCard.Dispose();

                                    int newIndex = Create_Item(ID.ToString(), updatedName);
                                    Main_flowLayoutPanel.Controls.SetChildIndex(Main_flowLayoutPanel.Controls[newIndex], originalIndex);
                                }
                            }
                        }
                    }
                    catch (Exception) { return; }
                }
            }
            else
            {
                Main_flowLayoutPanel.Controls.Clear();

                Create_Item("0", "Create_Card");

                string query = "SELECT CategoryID, CategoryName FROM Category ORDER BY CategoryID ASC";
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    try
                    {
                        connect.Open();
                        using (SqlCommand cmd = new SqlCommand(query, connect))
                        {
                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            {
                                DataTable Data = new DataTable();
                                adapter.Fill(Data);
                                foreach (DataRow row in Data.Rows)
                                {
                                    string id = row["CategoryID"].ToString();
                                    string name = row["CategoryName"].ToString();
                                    Create_Item(id, name);
                                }
                            }
                        }
                    }
                    catch (Exception) { return; }
                }
            }
        }

        private void Main_flowLayoutPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            string cardNameToFind = "Create_Card";
            Control[] foundCards = Main_flowLayoutPanel.Controls.Find(cardNameToFind, true);

            if (foundCards.Length == 0)
            {
                Create_Item("0", cardNameToFind);
            }
        }
    }
}