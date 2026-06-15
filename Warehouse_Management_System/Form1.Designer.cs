namespace Warehouse_Management_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Top_panel = new Panel();
            Windows_Control_panel = new Panel();
            Minimize_pictureBox = new PictureBox();
            Maximum_pictureBox = new PictureBox();
            Exit_pictureBox = new PictureBox();
            Menu_panel = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            Main_panel = new Panel();
            Top_panel.SuspendLayout();
            Windows_Control_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Minimize_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Maximum_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Exit_pictureBox).BeginInit();
            Menu_panel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Top_panel
            // 
            Top_panel.BackColor = Color.Crimson;
            Top_panel.Controls.Add(Windows_Control_panel);
            Top_panel.Dock = DockStyle.Top;
            Top_panel.Location = new Point(0, 0);
            Top_panel.Name = "Top_panel";
            Top_panel.Size = new Size(1262, 50);
            Top_panel.TabIndex = 0;
            Top_panel.MouseDown += TitleDragging_MouseDown;
            Top_panel.MouseMove += TitleDragging_MouseMove;
            Top_panel.MouseUp += TitleDragging_MouseUp;
            // 
            // Windows_Control_panel
            // 
            Windows_Control_panel.BackColor = Color.Transparent;
            Windows_Control_panel.Controls.Add(Minimize_pictureBox);
            Windows_Control_panel.Controls.Add(Maximum_pictureBox);
            Windows_Control_panel.Controls.Add(Exit_pictureBox);
            Windows_Control_panel.Dock = DockStyle.Right;
            Windows_Control_panel.Location = new Point(1112, 0);
            Windows_Control_panel.Name = "Windows_Control_panel";
            Windows_Control_panel.Size = new Size(150, 50);
            Windows_Control_panel.TabIndex = 0;
            // 
            // Minimize_pictureBox
            // 
            Minimize_pictureBox.Dock = DockStyle.Right;
            Minimize_pictureBox.Image = Properties.Resources.Minimum;
            Minimize_pictureBox.Location = new Point(0, 0);
            Minimize_pictureBox.Name = "Minimize_pictureBox";
            Minimize_pictureBox.Size = new Size(50, 50);
            Minimize_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            Minimize_pictureBox.TabIndex = 2;
            Minimize_pictureBox.TabStop = false;
            Minimize_pictureBox.Click += Minimized_Program;
            Minimize_pictureBox.MouseEnter += Enter_Mouse_PictureBox;
            Minimize_pictureBox.MouseLeave += Leave_Mouse_PictureBox;
            // 
            // Maximum_pictureBox
            // 
            Maximum_pictureBox.Dock = DockStyle.Right;
            Maximum_pictureBox.Image = Properties.Resources.Normal;
            Maximum_pictureBox.Location = new Point(50, 0);
            Maximum_pictureBox.Name = "Maximum_pictureBox";
            Maximum_pictureBox.Size = new Size(50, 50);
            Maximum_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            Maximum_pictureBox.TabIndex = 1;
            Maximum_pictureBox.TabStop = false;
            Maximum_pictureBox.Click += Maximized_Program;
            Maximum_pictureBox.MouseEnter += Enter_Mouse_PictureBox;
            Maximum_pictureBox.MouseLeave += Leave_Mouse_PictureBox;
            // 
            // Exit_pictureBox
            // 
            Exit_pictureBox.Dock = DockStyle.Right;
            Exit_pictureBox.Image = Properties.Resources.Exit;
            Exit_pictureBox.Location = new Point(100, 0);
            Exit_pictureBox.Name = "Exit_pictureBox";
            Exit_pictureBox.Size = new Size(50, 50);
            Exit_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            Exit_pictureBox.TabIndex = 0;
            Exit_pictureBox.TabStop = false;
            Exit_pictureBox.Click += Exit_Program;
            Exit_pictureBox.MouseEnter += Enter_Mouse_PictureBox;
            Exit_pictureBox.MouseLeave += Leave_Mouse_PictureBox;
            // 
            // Menu_panel
            // 
            Menu_panel.BackColor = Color.Salmon;
            Menu_panel.Controls.Add(panel2);
            Menu_panel.Controls.Add(panel1);
            Menu_panel.Dock = DockStyle.Left;
            Menu_panel.Location = new Point(0, 50);
            Menu_panel.Name = "Menu_panel";
            Menu_panel.Size = new Size(275, 623);
            Menu_panel.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Cursor = Cursors.Hand;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(5);
            panel2.Size = new Size(275, 60);
            panel2.TabIndex = 1;
            panel2.Tag = "Category";
            panel2.Click += PanelMenu_Click;
            panel2.MouseEnter += PanelMenu_MouseEnter;
            panel2.MouseLeave += PanelMenu_MouseLeave;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Verdana", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(55, 5);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 5, 0, 0);
            label2.Size = new Size(215, 50);
            label2.TabIndex = 1;
            label2.Text = "Category";
            label2.Click += PanelMenu_Click;
            label2.MouseEnter += PanelMenu_MouseEnter;
            label2.MouseLeave += PanelMenu_MouseLeave;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = Properties.Resources.Category;
            pictureBox2.Location = new Point(5, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Padding = new Padding(0, 0, 5, 0);
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += PanelMenu_Click;
            pictureBox2.MouseEnter += PanelMenu_MouseEnter;
            pictureBox2.MouseLeave += PanelMenu_MouseLeave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Cursor = Cursors.Hand;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(275, 60);
            panel1.TabIndex = 0;
            panel1.Tag = "Home";
            panel1.Click += PanelMenu_Click;
            panel1.MouseEnter += PanelMenu_MouseEnter;
            panel1.MouseLeave += PanelMenu_MouseLeave;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Verdana", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(55, 5);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 5, 0, 0);
            label1.Size = new Size(215, 50);
            label1.TabIndex = 1;
            label1.Text = "Home";
            label1.Click += PanelMenu_Click;
            label1.MouseEnter += PanelMenu_MouseEnter;
            label1.MouseLeave += PanelMenu_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.Home;
            pictureBox1.Location = new Point(5, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(0, 0, 5, 0);
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += PanelMenu_Click;
            pictureBox1.MouseEnter += PanelMenu_MouseEnter;
            pictureBox1.MouseLeave += PanelMenu_MouseLeave;
            // 
            // Main_panel
            // 
            Main_panel.BackColor = Color.Transparent;
            Main_panel.Dock = DockStyle.Fill;
            Main_panel.Location = new Point(275, 50);
            Main_panel.Name = "Main_panel";
            Main_panel.Size = new Size(987, 623);
            Main_panel.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1262, 673);
            Controls.Add(Main_panel);
            Controls.Add(Menu_panel);
            Controls.Add(Top_panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Top_panel.ResumeLayout(false);
            Windows_Control_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Minimize_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Maximum_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Exit_pictureBox).EndInit();
            Menu_panel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Top_panel;
        private Panel Windows_Control_panel;
        private PictureBox Exit_pictureBox;
        private PictureBox Minimize_pictureBox;
        private PictureBox Maximum_pictureBox;
        private Panel Menu_panel;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel Main_panel;
    }
}
