namespace Warehouse_Management_System
{
    partial class Category_Edit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Top_panel = new Panel();
            pictureBox1 = new PictureBox();
            Title_label = new Label();
            Main_flowLayoutPanel = new FlowLayoutPanel();
            ID_label = new Label();
            Name_label = new Label();
            NameEdit_textBox = new TextBox();
            Bottom_panel = new Panel();
            Save_button = new Button();
            Cancel_button = new Button();
            Delete_button = new Button();
            Top_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Main_flowLayoutPanel.SuspendLayout();
            Bottom_panel.SuspendLayout();
            SuspendLayout();
            // 
            // Top_panel
            // 
            Top_panel.BackColor = Color.Crimson;
            Top_panel.Controls.Add(pictureBox1);
            Top_panel.Controls.Add(Title_label);
            Top_panel.Dock = DockStyle.Top;
            Top_panel.Location = new Point(0, 0);
            Top_panel.Name = "Top_panel";
            Top_panel.Size = new Size(800, 50);
            Top_panel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.Edit;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Title_label
            // 
            Title_label.BackColor = Color.Transparent;
            Title_label.Dock = DockStyle.Fill;
            Title_label.Font = new Font("Segoe UI", 20F);
            Title_label.ForeColor = Color.Transparent;
            Title_label.Location = new Point(0, 0);
            Title_label.Name = "Title_label";
            Title_label.Padding = new Padding(50, 0, 0, 0);
            Title_label.Size = new Size(800, 50);
            Title_label.TabIndex = 1;
            Title_label.Text = "Edit";
            // 
            // Main_flowLayoutPanel
            // 
            Main_flowLayoutPanel.BackColor = Color.Transparent;
            Main_flowLayoutPanel.Controls.Add(ID_label);
            Main_flowLayoutPanel.Controls.Add(Name_label);
            Main_flowLayoutPanel.Controls.Add(NameEdit_textBox);
            Main_flowLayoutPanel.Dock = DockStyle.Fill;
            Main_flowLayoutPanel.Location = new Point(0, 50);
            Main_flowLayoutPanel.Name = "Main_flowLayoutPanel";
            Main_flowLayoutPanel.Size = new Size(800, 400);
            Main_flowLayoutPanel.TabIndex = 2;
            // 
            // ID_label
            // 
            ID_label.Font = new Font("Segoe UI", 16F);
            ID_label.ImageAlign = ContentAlignment.MiddleLeft;
            ID_label.Location = new Point(3, 0);
            ID_label.Margin = new Padding(3, 0, 3, 10);
            ID_label.Name = "ID_label";
            ID_label.Size = new Size(797, 45);
            ID_label.TabIndex = 0;
            ID_label.Text = "ID";
            ID_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Name_label
            // 
            Name_label.Font = new Font("Segoe UI", 16F);
            Name_label.Location = new Point(3, 55);
            Name_label.Margin = new Padding(3, 0, 3, 10);
            Name_label.Name = "Name_label";
            Name_label.Size = new Size(100, 50);
            Name_label.TabIndex = 1;
            Name_label.Text = "Name";
            Name_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // NameEdit_textBox
            // 
            NameEdit_textBox.Font = new Font("Segoe UI", 16F);
            NameEdit_textBox.ForeColor = Color.DarkGray;
            NameEdit_textBox.Location = new Point(109, 58);
            NameEdit_textBox.Name = "NameEdit_textBox";
            NameEdit_textBox.Size = new Size(650, 43);
            NameEdit_textBox.TabIndex = 2;
            NameEdit_textBox.Text = "Name_Text";
            NameEdit_textBox.Enter += Enter_Textbox;
            NameEdit_textBox.Leave += Leave_Textbox;
            // 
            // Bottom_panel
            // 
            Bottom_panel.BackColor = Color.Transparent;
            Bottom_panel.Controls.Add(Save_button);
            Bottom_panel.Controls.Add(Cancel_button);
            Bottom_panel.Controls.Add(Delete_button);
            Bottom_panel.Dock = DockStyle.Bottom;
            Bottom_panel.Location = new Point(0, 400);
            Bottom_panel.Name = "Bottom_panel";
            Bottom_panel.Size = new Size(800, 50);
            Bottom_panel.TabIndex = 4;
            // 
            // Save_button
            // 
            Save_button.BackColor = Color.LightGreen;
            Save_button.Dock = DockStyle.Right;
            Save_button.Font = new Font("Segoe UI", 16F);
            Save_button.ForeColor = Color.Black;
            Save_button.Location = new Point(500, 0);
            Save_button.Name = "Save_button";
            Save_button.Size = new Size(150, 50);
            Save_button.TabIndex = 8;
            Save_button.Text = "Save";
            Save_button.UseVisualStyleBackColor = false;
            Save_button.Click += Save_Button;
            // 
            // Cancel_button
            // 
            Cancel_button.BackColor = Color.Crimson;
            Cancel_button.Dock = DockStyle.Right;
            Cancel_button.Font = new Font("Segoe UI", 16F);
            Cancel_button.ForeColor = Color.White;
            Cancel_button.Location = new Point(650, 0);
            Cancel_button.Name = "Cancel_button";
            Cancel_button.Size = new Size(150, 50);
            Cancel_button.TabIndex = 7;
            Cancel_button.Text = "Cancel";
            Cancel_button.UseVisualStyleBackColor = false;
            Cancel_button.Click += Cancel_Button;
            // 
            // Delete_button
            // 
            Delete_button.BackColor = Color.Crimson;
            Delete_button.Dock = DockStyle.Left;
            Delete_button.Font = new Font("Segoe UI", 16F);
            Delete_button.ForeColor = Color.White;
            Delete_button.Location = new Point(0, 0);
            Delete_button.Name = "Delete_button";
            Delete_button.Size = new Size(150, 50);
            Delete_button.TabIndex = 9;
            Delete_button.Text = "Delete";
            Delete_button.UseVisualStyleBackColor = false;
            Delete_button.Click += Delete_Button_Click;
            // 
            // Category_Edit
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(800, 450);
            Controls.Add(Bottom_panel);
            Controls.Add(Main_flowLayoutPanel);
            Controls.Add(Top_panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Category_Edit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Category_Edit";
            Top_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Main_flowLayoutPanel.ResumeLayout(false);
            Main_flowLayoutPanel.PerformLayout();
            Bottom_panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public Panel Top_panel;
        public FlowLayoutPanel Main_flowLayoutPanel;
        public Label ID_label;
        public Label Name_label;
        public TextBox NameEdit_textBox;
        public PictureBox pictureBox1;
        public Label Title_label;
        private Panel Bottom_panel;
        public Button Save_button;
        public Button Cancel_button;
        public Button Delete_button;
    }
}