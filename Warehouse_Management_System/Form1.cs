namespace Warehouse_Management_System
{
    public partial class Form1 : Form
    {
        Color Menu_Normal_Color = Color.Transparent;
        Color Menu_Hover_Color = Color.LightSalmon;
        Color Menu_Active_Color = Color.DarkRed;

        Panel ActiveMenu = null;

        private bool Title_Dragging = false;
        private Point Title_StartPos = new Point(0, 0);
        private Point dragOffset;
        public Form1()
        {
            InitializeComponent();
            Defalut_Panel_BackColor(Top_panel);
            Defalut_Panel_BackColor(Menu_panel);
        }
        private void Defalut_Panel_BackColor(Panel selectPanel)
        {
            foreach (Control ctrl in selectPanel.Controls)
            {
                if (ctrl is PictureBox || ctrl is Panel)
                {
                    ctrl.BackColor = Color.Transparent;
                }
            }
        }
        private void Enter_Mouse_PictureBox(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
            btn.BackColor = Color.DarkGray;
        }
        private void Leave_Mouse_PictureBox(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
            btn.BackColor = Color.Transparent;
        }
        private void Exit_Program(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimized_Program(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Maximized_Program(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                Maximum_pictureBox.Image = Properties.Resources.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                Maximum_pictureBox.Image = Properties.Resources.Maximized;
            }
        }
        private void TitleDragging_MouseDown(object sender, MouseEventArgs e)
        {
            Title_Dragging = true;
            Title_StartPos = Control.MousePosition;
            dragOffset = e.Location;
        }
        private void TitleDragging_MouseUp(object sender, MouseEventArgs e)
        {
            Title_Dragging = false;
        }
        private void TitleDragging_MouseMove(object sender, MouseEventArgs e)
        {
            if (Title_Dragging)
            {
                Point currentPos = Control.MousePosition;

                if (this.WindowState == FormWindowState.Maximized)
                {
                    double percentX = (double)dragOffset.X / this.Width;

                    this.WindowState = FormWindowState.Normal;
                    Maximum_pictureBox.Image = Properties.Resources.Normal;

                    this.Left = currentPos.X - (int)(this.Width * percentX);
                    this.Top = currentPos.Y - dragOffset.Y;

                    Title_StartPos = currentPos;
                }

                this.Left += currentPos.X - Title_StartPos.X;
                this.Top += currentPos.Y - Title_StartPos.Y;
                Title_StartPos = currentPos;
            }
        }
        private void SelectMenu(Panel selectPanel)
        {
            if (ActiveMenu != null)
            {
                ActiveMenu.Tag = null;
                ActiveMenu.BackColor = Menu_Normal_Color;
            }
            ActiveMenu = selectPanel;
            ActiveMenu.Tag = "Active";
            ActiveMenu.BackColor = Menu_Active_Color;
            ActiveMenu.Cursor = Cursors.Default;

        }
        private void PanelMenu_MouseEnter(object sender, EventArgs e)
        {
            Panel currentPanel;
            if (!(sender is Panel))
            { currentPanel = (Panel)((Control)sender).Parent; }
            else
            { currentPanel = (Panel)sender; }

            if (currentPanel.Tag != null && currentPanel.Tag.ToString() == "Active") return;
            currentPanel.BackColor = Menu_Hover_Color;
            currentPanel.Cursor = Cursors.Hand;
        }
        private void PanelMenu_MouseLeave(object sender, EventArgs e)
        {
            Panel currentPanel;
            if (!(sender is Panel))
            { currentPanel = (Panel)((Control)sender).Parent; }
            else
            { currentPanel = (Panel)sender; }

            if (currentPanel.Tag != null && currentPanel.Tag.ToString() == "Active") return;
            currentPanel.BackColor = Menu_Normal_Color;
            currentPanel.Cursor = Cursors.Hand;
        }
        private void PanelMenu_Click(object sender, EventArgs e)
        {
            Panel currentPanel;
            if (!(sender is Panel))
            { currentPanel = (Panel)((Control)sender).Parent; }
            else
            { currentPanel = (Panel)sender; }

            SelectMenu(currentPanel);
            if (currentPanel.Tag != null)
            {
                Home HomePage = new Home();
                Category CategoryPage = new Category();

                if (currentPanel.Name == "panel1") { Page(HomePage); }
                if (currentPanel.Name == "panel2") { Page(CategoryPage); }
            }
        }
        private void Page(Form Page)
        {
            Main_panel.Controls.Clear();

            Page.TopLevel = false;
            Page.Dock = DockStyle.Fill;
            Page.Show();

            Main_panel.Controls.Add(Page);
        }
    }
}
