namespace Warehouse_Management_System
{
    partial class Category
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
            Main_flowLayoutPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // Main_flowLayoutPanel
            // 
            Main_flowLayoutPanel.AutoScroll = true;
            Main_flowLayoutPanel.BackColor = Color.Transparent;
            Main_flowLayoutPanel.Dock = DockStyle.Fill;
            Main_flowLayoutPanel.FlowDirection = FlowDirection.RightToLeft;
            Main_flowLayoutPanel.Location = new Point(0, 0);
            Main_flowLayoutPanel.Name = "Main_flowLayoutPanel";
            Main_flowLayoutPanel.RightToLeft = RightToLeft.Yes;
            Main_flowLayoutPanel.Size = new Size(1000, 500);
            Main_flowLayoutPanel.TabIndex = 1;
            Main_flowLayoutPanel.ControlAdded += Main_flowLayoutPanel_ControlAdded;
            // 
            // Category
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 500);
            Controls.Add(Main_flowLayoutPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Category";
            Text = "Category";
            ResumeLayout(false);
        }

        #endregion

        public FlowLayoutPanel Main_flowLayoutPanel;
    }
}