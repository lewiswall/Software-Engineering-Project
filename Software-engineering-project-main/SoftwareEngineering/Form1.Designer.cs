namespace SoftwareEngineering
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.MenuQuickButton = new System.Windows.Forms.Button();
            this.MenuFilterButton = new System.Windows.Forms.Button();
            this.MenuAddButton = new System.Windows.Forms.Button();
            this.MenuSearchButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.addEngine1 = new SoftwareEngineering.AddEngine();
            this.viewEngine = new SoftwareEngineering.ViewEngine();
            this.quickFindPanel = new SoftwareEngineering.QuickFind();
            this.advancedFilterPanel = new SoftwareEngineering.AdvancedFilter();
            this.advancedSearchPanel = new SoftwareEngineering.AdvancedSearch();
            this.addVehicle1 = new SoftwareEngineering.AddVehicle();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label1.Font = new System.Drawing.Font("Rockwell Extra Bold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(0, 192);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car Database";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.MenuQuickButton);
            this.panel1.Controls.Add(this.MenuFilterButton);
            this.panel1.Controls.Add(this.MenuAddButton);
            this.panel1.Controls.Add(this.MenuSearchButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 882);
            this.panel1.TabIndex = 4;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 278);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(4);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(14, 80);
            this.SidePanel.TabIndex = 7;
            // 
            // MenuQuickButton
            // 
            this.MenuQuickButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.MenuQuickButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.MenuQuickButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuQuickButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuQuickButton.ForeColor = System.Drawing.Color.Silver;
            this.MenuQuickButton.Image = ((System.Drawing.Image)(resources.GetObject("MenuQuickButton.Image")));
            this.MenuQuickButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuQuickButton.Location = new System.Drawing.Point(0, 278);
            this.MenuQuickButton.Margin = new System.Windows.Forms.Padding(4);
            this.MenuQuickButton.Name = "MenuQuickButton";
            this.MenuQuickButton.Size = new System.Drawing.Size(270, 80);
            this.MenuQuickButton.TabIndex = 6;
            this.MenuQuickButton.Text = "Quick Find";
            this.MenuQuickButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MenuQuickButton.UseVisualStyleBackColor = false;
            this.MenuQuickButton.Click += new System.EventHandler(this.MenuQuickButton_Click);
            // 
            // MenuFilterButton
            // 
            this.MenuFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.MenuFilterButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.MenuFilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuFilterButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuFilterButton.ForeColor = System.Drawing.Color.Silver;
            this.MenuFilterButton.Image = ((System.Drawing.Image)(resources.GetObject("MenuFilterButton.Image")));
            this.MenuFilterButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuFilterButton.Location = new System.Drawing.Point(0, 445);
            this.MenuFilterButton.Margin = new System.Windows.Forms.Padding(4);
            this.MenuFilterButton.Name = "MenuFilterButton";
            this.MenuFilterButton.Size = new System.Drawing.Size(270, 80);
            this.MenuFilterButton.TabIndex = 5;
            this.MenuFilterButton.Text = "Advanced Filter";
            this.MenuFilterButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MenuFilterButton.UseVisualStyleBackColor = false;
            this.MenuFilterButton.Click += new System.EventHandler(this.MenuFilterButton_Click);
            // 
            // MenuAddButton
            // 
            this.MenuAddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.MenuAddButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.MenuAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuAddButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuAddButton.ForeColor = System.Drawing.Color.Silver;
            this.MenuAddButton.Image = ((System.Drawing.Image)(resources.GetObject("MenuAddButton.Image")));
            this.MenuAddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuAddButton.Location = new System.Drawing.Point(0, 771);
            this.MenuAddButton.Margin = new System.Windows.Forms.Padding(4);
            this.MenuAddButton.Name = "MenuAddButton";
            this.MenuAddButton.Size = new System.Drawing.Size(270, 108);
            this.MenuAddButton.TabIndex = 4;
            this.MenuAddButton.Text = "Add Vehicle";
            this.MenuAddButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MenuAddButton.UseVisualStyleBackColor = false;
            this.MenuAddButton.Click += new System.EventHandler(this.MenuAddButton_Click);
            // 
            // MenuSearchButton
            // 
            this.MenuSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.MenuSearchButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.MenuSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuSearchButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuSearchButton.ForeColor = System.Drawing.Color.Silver;
            this.MenuSearchButton.Image = ((System.Drawing.Image)(resources.GetObject("MenuSearchButton.Image")));
            this.MenuSearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuSearchButton.Location = new System.Drawing.Point(0, 357);
            this.MenuSearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.MenuSearchButton.Name = "MenuSearchButton";
            this.MenuSearchButton.Size = new System.Drawing.Size(270, 80);
            this.MenuSearchButton.TabIndex = 3;
            this.MenuSearchButton.Text = "Advanced Search";
            this.MenuSearchButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MenuSearchButton.UseVisualStyleBackColor = false;
            this.MenuSearchButton.Click += new System.EventHandler(this.MenuSearchButton_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 250);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(58, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 533);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 80);
            this.button1.TabIndex = 8;
            this.button1.Text = "Engines";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Silver;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 665);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(270, 108);
            this.button2.TabIndex = 9;
            this.button2.Text = "Add Engine";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleLabel.Font = new System.Drawing.Font("Myanmar Text", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.Silver;
            this.TitleLabel.Image = ((System.Drawing.Image)(resources.GetObject("TitleLabel.Image")));
            this.TitleLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TitleLabel.Location = new System.Drawing.Point(270, 0);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(1426, 135);
            this.TitleLabel.TabIndex = 5;
            this.TitleLabel.Text = "Database- Quick Find";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.TitleLabel.Click += new System.EventHandler(this.TitleLabel_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel5.Controls.Add(this.ExitButton);
            this.panel5.Location = new System.Drawing.Point(270, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1450, 56);
            this.panel5.TabIndex = 8;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.Location = new System.Drawing.Point(1354, 9);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(60, 46);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // addEngine1
            // 
            this.addEngine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(54)))));
            this.addEngine1.Location = new System.Drawing.Point(285, 154);
            this.addEngine1.Name = "addEngine1";
            this.addEngine1.Size = new System.Drawing.Size(1414, 728);
            this.addEngine1.TabIndex = 12;
            // 
            // viewEngine
            // 
            this.viewEngine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(54)))));
            this.viewEngine.Location = new System.Drawing.Point(285, 154);
            this.viewEngine.Name = "viewEngine";
            this.viewEngine.Size = new System.Drawing.Size(1414, 725);
            this.viewEngine.TabIndex = 11;
            // 
            // quickFindPanel
            // 
            this.quickFindPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(54)))));
            this.quickFindPanel.Location = new System.Drawing.Point(284, 154);
            this.quickFindPanel.Margin = new System.Windows.Forms.Padding(2);
            this.quickFindPanel.Name = "quickFindPanel";
            this.quickFindPanel.Size = new System.Drawing.Size(1415, 728);
            this.quickFindPanel.TabIndex = 9;
            this.quickFindPanel.Load += new System.EventHandler(this.quickFindPanel_Load);
            // 
            // advancedFilterPanel
            // 
            this.advancedFilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(54)))));
            this.advancedFilterPanel.Location = new System.Drawing.Point(285, 154);
            this.advancedFilterPanel.Margin = new System.Windows.Forms.Padding(2);
            this.advancedFilterPanel.Name = "advancedFilterPanel";
            this.advancedFilterPanel.Size = new System.Drawing.Size(1414, 728);
            this.advancedFilterPanel.TabIndex = 8;
            // 
            // advancedSearchPanel
            // 
            this.advancedSearchPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(54)))));
            this.advancedSearchPanel.Location = new System.Drawing.Point(284, 154);
            this.advancedSearchPanel.Margin = new System.Windows.Forms.Padding(2);
            this.advancedSearchPanel.Name = "advancedSearchPanel";
            this.advancedSearchPanel.Size = new System.Drawing.Size(1415, 728);
            this.advancedSearchPanel.TabIndex = 8;
            // 
            // addVehicle1
            // 
            this.addVehicle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(54)))));
            this.addVehicle1.Location = new System.Drawing.Point(285, 154);
            this.addVehicle1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.addVehicle1.Name = "addVehicle1";
            this.addVehicle1.Size = new System.Drawing.Size(1414, 728);
            this.addVehicle1.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1696, 882);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addEngine1);
            this.Controls.Add(this.viewEngine);
            this.Controls.Add(this.quickFindPanel);
            this.Controls.Add(this.advancedFilterPanel);
            this.Controls.Add(this.advancedSearchPanel);
            this.Controls.Add(this.addVehicle1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        //Controls
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button MenuFilterButton;
        private System.Windows.Forms.Button MenuAddButton;
        private System.Windows.Forms.Button MenuSearchButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button MenuQuickButton;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button ExitButton;
        private QuickFind quickFindPanel;
        private AdvancedSearch advancedSearchPanel;
        private AdvancedFilter advancedFilterPanel;
        private AddVehicle addVehicle1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private ViewEngine viewEngine;
        private AddEngine addEngine1;
    }
}

