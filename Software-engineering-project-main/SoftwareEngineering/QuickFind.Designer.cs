namespace SoftwareEngineering
{
    partial class QuickFind
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.FilterBodyBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FilterFuelBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FilterModelBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FilterBrandBox = new System.Windows.Forms.ComboBox();
            this.blabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FilterEngineBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FilterBHPBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FilterMPGBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.FilterPriceBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(214, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1130, 718);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.FilterBodyBox);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.FilterFuelBox);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.FilterModelBox);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.FilterBrandBox);
            this.panel4.Controls.Add(this.blabel);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(9, 8);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 718);
            this.panel4.TabIndex = 9;
            // 
            // FilterBodyBox
            // 
            this.FilterBodyBox.BackColor = System.Drawing.Color.Honeydew;
            this.FilterBodyBox.FormattingEnabled = true;
            this.FilterBodyBox.Location = new System.Drawing.Point(27, 335);
            this.FilterBodyBox.Name = "FilterBodyBox";
            this.FilterBodyBox.Size = new System.Drawing.Size(150, 28);
            this.FilterBodyBox.TabIndex = 15;
            this.FilterBodyBox.SelectedIndexChanged += new System.EventHandler(this.comboChange);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(54)))));
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(12, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 49);
            this.label4.TabIndex = 14;
            this.label4.Text = "Body Type";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FilterFuelBox
            // 
            this.FilterFuelBox.BackColor = System.Drawing.Color.Honeydew;
            this.FilterFuelBox.FormattingEnabled = true;
            this.FilterFuelBox.Location = new System.Drawing.Point(27, 254);
            this.FilterFuelBox.Name = "FilterFuelBox";
            this.FilterFuelBox.Size = new System.Drawing.Size(150, 28);
            this.FilterFuelBox.TabIndex = 13;
            this.FilterFuelBox.SelectedIndexChanged += new System.EventHandler(this.comboChange);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(54)))));
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(12, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 49);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fuel Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FilterModelBox
            // 
            this.FilterModelBox.BackColor = System.Drawing.Color.Honeydew;
            this.FilterModelBox.FormattingEnabled = true;
            this.FilterModelBox.Location = new System.Drawing.Point(27, 169);
            this.FilterModelBox.Name = "FilterModelBox";
            this.FilterModelBox.Size = new System.Drawing.Size(150, 28);
            this.FilterModelBox.TabIndex = 11;
            this.FilterModelBox.SelectedIndexChanged += new System.EventHandler(this.comboChange);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(54)))));
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(12, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 49);
            this.label1.TabIndex = 10;
            this.label1.Text = "Model";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FilterBrandBox
            // 
            this.FilterBrandBox.BackColor = System.Drawing.Color.Honeydew;
            this.FilterBrandBox.FormattingEnabled = true;
            this.FilterBrandBox.Location = new System.Drawing.Point(27, 92);
            this.FilterBrandBox.Name = "FilterBrandBox";
            this.FilterBrandBox.Size = new System.Drawing.Size(150, 28);
            this.FilterBrandBox.TabIndex = 9;
            this.FilterBrandBox.SelectedIndexChanged += new System.EventHandler(this.comboChange);
            // 
            // blabel
            // 
            this.blabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(54)))));
            this.blabel.Font = new System.Drawing.Font("Myanmar Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.blabel.Location = new System.Drawing.Point(12, 43);
            this.blabel.Name = "blabel";
            this.blabel.Size = new System.Drawing.Size(180, 49);
            this.blabel.TabIndex = 8;
            this.blabel.Text = "Brand";
            this.blabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(54)))));
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 49);
            this.label3.TabIndex = 2;
            this.label3.Text = "Find";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FilterEngineBox
            // 
            this.FilterEngineBox.BackColor = System.Drawing.Color.Honeydew;
            this.FilterEngineBox.FormattingEnabled = true;
            this.FilterEngineBox.Location = new System.Drawing.Point(36, 423);
            this.FilterEngineBox.Name = "FilterEngineBox";
            this.FilterEngineBox.Size = new System.Drawing.Size(150, 28);
            this.FilterEngineBox.TabIndex = 17;
            this.FilterEngineBox.SelectedIndexChanged += new System.EventHandler(this.comboChange);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(54)))));
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(21, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 49);
            this.label5.TabIndex = 16;
            this.label5.Text = "Engine Size";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FilterBHPBox
            // 
            this.FilterBHPBox.BackColor = System.Drawing.Color.Honeydew;
            this.FilterBHPBox.FormattingEnabled = true;
            this.FilterBHPBox.Location = new System.Drawing.Point(36, 506);
            this.FilterBHPBox.Name = "FilterBHPBox";
            this.FilterBHPBox.Size = new System.Drawing.Size(150, 28);
            this.FilterBHPBox.TabIndex = 19;
            this.FilterBHPBox.SelectedIndexChanged += new System.EventHandler(this.comboChange);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(54)))));
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(21, 457);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 49);
            this.label6.TabIndex = 18;
            this.label6.Text = "BHP";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FilterMPGBox
            // 
            this.FilterMPGBox.BackColor = System.Drawing.Color.Honeydew;
            this.FilterMPGBox.FormattingEnabled = true;
            this.FilterMPGBox.Location = new System.Drawing.Point(36, 582);
            this.FilterMPGBox.Name = "FilterMPGBox";
            this.FilterMPGBox.Size = new System.Drawing.Size(150, 28);
            this.FilterMPGBox.TabIndex = 21;
            this.FilterMPGBox.SelectedIndexChanged += new System.EventHandler(this.comboChange);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(54)))));
            this.label7.Font = new System.Drawing.Font("Myanmar Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label7.Location = new System.Drawing.Point(8, 532);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 49);
            this.label7.TabIndex = 20;
            this.label7.Text = "Combined MPG";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FilterPriceBox
            // 
            this.FilterPriceBox.BackColor = System.Drawing.Color.Honeydew;
            this.FilterPriceBox.FormattingEnabled = true;
            this.FilterPriceBox.Location = new System.Drawing.Point(36, 660);
            this.FilterPriceBox.Name = "FilterPriceBox";
            this.FilterPriceBox.Size = new System.Drawing.Size(150, 28);
            this.FilterPriceBox.TabIndex = 23;
            this.FilterPriceBox.SelectedIndexChanged += new System.EventHandler(this.comboChange);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(54)))));
            this.label8.Font = new System.Drawing.Font("Myanmar Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label8.Location = new System.Drawing.Point(21, 611);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 49);
            this.label8.TabIndex = 22;
            this.label8.Text = "Price";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuickFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.FilterPriceBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.FilterMPGBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FilterBHPBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FilterEngineBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel4);
            this.Name = "QuickFind";
            this.Size = new System.Drawing.Size(1400, 788);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox FilterBrandBox;
        private System.Windows.Forms.Label blabel;
        private System.Windows.Forms.ComboBox FilterBodyBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox FilterFuelBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FilterModelBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FilterEngineBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox FilterBHPBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox FilterMPGBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox FilterPriceBox;
        private System.Windows.Forms.Label label8;
    }
}
