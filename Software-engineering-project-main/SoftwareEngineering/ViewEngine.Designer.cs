namespace SoftwareEngineering
{
    partial class ViewEngine
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
            this.FilterGrid = new System.Windows.Forms.DataGridView();
            this.FilterStrokeBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.FilterBHPBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.FilterSizeBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FilterCylinderBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FilterFuelTypeBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FilterFuelSysBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FilterAspBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FilterTypeBox = new System.Windows.Forms.ComboBox();
            this.blabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FilterGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // FilterGrid
            // 
            this.FilterGrid.BackgroundColor = System.Drawing.Color.White;
            this.FilterGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FilterGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.FilterGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FilterGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.FilterGrid.Location = new System.Drawing.Point(216, 3);
            this.FilterGrid.Name = "FilterGrid";
            this.FilterGrid.RowHeadersWidth = 62;
            this.FilterGrid.RowTemplate.Height = 28;
            this.FilterGrid.Size = new System.Drawing.Size(1190, 685);
            this.FilterGrid.TabIndex = 113;
            this.FilterGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FilterGrid_CellDoubleClick);
            this.FilterGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FilterGrid_CellDoubleClick);
            // 
            // FilterStrokeBox
            // 
            this.FilterStrokeBox.BackColor = System.Drawing.Color.Honeydew;
            this.FilterStrokeBox.FormattingEnabled = true;
            this.FilterStrokeBox.Location = new System.Drawing.Point(29, 666);
            this.FilterStrokeBox.Name = "FilterStrokeBox";
            this.FilterStrokeBox.Size = new System.Drawing.Size(150, 28);
            this.FilterStrokeBox.TabIndex = 130;
            this.FilterStrokeBox.SelectedIndexChanged += new System.EventHandler(this.comboChange);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(54)))));
            this.label8.Font = new System.Drawing.Font("Myanmar Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label8.Location = new System.Drawing.Point(21, 614);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 49);
            this.label8.TabIndex = 129;
            this.label8.Text = "Stroke";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FilterBHPBox
            // 
            this.FilterBHPBox.BackColor = System.Drawing.Color.Honeydew;
            this.FilterBHPBox.FormattingEnabled = true;
            this.FilterBHPBox.Location = new System.Drawing.Point(29, 583);
            this.FilterBHPBox.Name = "FilterBHPBox";
            this.FilterBHPBox.Size = new System.Drawing.Size(150, 28);
            this.FilterBHPBox.TabIndex = 128;
            this.FilterBHPBox.SelectedIndexChanged += new System.EventHandler(this.comboChange);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(54)))));
            this.label7.Font = new System.Drawing.Font("Myanmar Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label7.Location = new System.Drawing.Point(8, 535);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 49);
            this.label7.TabIndex = 127;
            this.label7.Text = "BHP";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FilterSizeBox
            // 
            this.FilterSizeBox.BackColor = System.Drawing.Color.Honeydew;
            this.FilterSizeBox.FormattingEnabled = true;
            this.FilterSizeBox.Location = new System.Drawing.Point(29, 512);
            this.FilterSizeBox.Name = "FilterSizeBox";
            this.FilterSizeBox.Size = new System.Drawing.Size(150, 28);
            this.FilterSizeBox.TabIndex = 126;
            this.FilterSizeBox.SelectedIndexChanged += new System.EventHandler(this.comboChange);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(54)))));
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(21, 460);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 49);
            this.label6.TabIndex = 125;
            this.label6.Text = "Size";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FilterCylinderBox
            // 
            this.FilterCylinderBox.BackColor = System.Drawing.Color.Honeydew;
            this.FilterCylinderBox.FormattingEnabled = true;
            this.FilterCylinderBox.Location = new System.Drawing.Point(29, 429);
            this.FilterCylinderBox.Name = "FilterCylinderBox";
            this.FilterCylinderBox.Size = new System.Drawing.Size(150, 28);
            this.FilterCylinderBox.TabIndex = 124;
            this.FilterCylinderBox.SelectedIndexChanged += new System.EventHandler(this.comboChange);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(54)))));
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(21, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 49);
            this.label5.TabIndex = 123;
            this.label5.Text = "Cylinders";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FilterFuelTypeBox
            // 
            this.FilterFuelTypeBox.BackColor = System.Drawing.Color.Honeydew;
            this.FilterFuelTypeBox.FormattingEnabled = true;
            this.FilterFuelTypeBox.Location = new System.Drawing.Point(27, 338);
            this.FilterFuelTypeBox.Name = "FilterFuelTypeBox";
            this.FilterFuelTypeBox.Size = new System.Drawing.Size(150, 28);
            this.FilterFuelTypeBox.TabIndex = 122;
            this.FilterFuelTypeBox.SelectedIndexChanged += new System.EventHandler(this.comboChange);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(54)))));
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(12, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 49);
            this.label4.TabIndex = 121;
            this.label4.Text = "Fuel Type";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FilterFuelSysBox
            // 
            this.FilterFuelSysBox.BackColor = System.Drawing.Color.Honeydew;
            this.FilterFuelSysBox.FormattingEnabled = true;
            this.FilterFuelSysBox.Location = new System.Drawing.Point(27, 257);
            this.FilterFuelSysBox.Name = "FilterFuelSysBox";
            this.FilterFuelSysBox.Size = new System.Drawing.Size(150, 28);
            this.FilterFuelSysBox.TabIndex = 120;
            this.FilterFuelSysBox.SelectedIndexChanged += new System.EventHandler(this.comboChange);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(54)))));
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(12, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 49);
            this.label2.TabIndex = 119;
            this.label2.Text = "Fuel System";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FilterAspBox
            // 
            this.FilterAspBox.BackColor = System.Drawing.Color.Honeydew;
            this.FilterAspBox.FormattingEnabled = true;
            this.FilterAspBox.Location = new System.Drawing.Point(27, 172);
            this.FilterAspBox.Name = "FilterAspBox";
            this.FilterAspBox.Size = new System.Drawing.Size(150, 28);
            this.FilterAspBox.TabIndex = 118;
            this.FilterAspBox.SelectedIndexChanged += new System.EventHandler(this.comboChange);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(54)))));
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(12, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 49);
            this.label1.TabIndex = 117;
            this.label1.Text = "Aspiration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FilterTypeBox
            // 
            this.FilterTypeBox.BackColor = System.Drawing.Color.Honeydew;
            this.FilterTypeBox.FormattingEnabled = true;
            this.FilterTypeBox.Location = new System.Drawing.Point(27, 95);
            this.FilterTypeBox.Name = "FilterTypeBox";
            this.FilterTypeBox.Size = new System.Drawing.Size(150, 28);
            this.FilterTypeBox.TabIndex = 116;
            this.FilterTypeBox.SelectedIndexChanged += new System.EventHandler(this.comboChange);
            // 
            // blabel
            // 
            this.blabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(54)))));
            this.blabel.Font = new System.Drawing.Font("Myanmar Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.blabel.Location = new System.Drawing.Point(12, 46);
            this.blabel.Name = "blabel";
            this.blabel.Size = new System.Drawing.Size(180, 49);
            this.blabel.TabIndex = 115;
            this.blabel.Text = "Type";
            this.blabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(54)))));
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 49);
            this.label3.TabIndex = 114;
            this.label3.Text = "Find";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewEngine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.FilterStrokeBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.FilterBHPBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FilterSizeBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FilterCylinderBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FilterFuelTypeBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FilterFuelSysBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FilterAspBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FilterTypeBox);
            this.Controls.Add(this.blabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FilterGrid);
            this.Name = "ViewEngine";
            this.Size = new System.Drawing.Size(1420, 706);
            ((System.ComponentModel.ISupportInitialize)(this.FilterGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView FilterGrid;
        private System.Windows.Forms.ComboBox FilterStrokeBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox FilterBHPBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox FilterSizeBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox FilterCylinderBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox FilterFuelTypeBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox FilterFuelSysBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FilterAspBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FilterTypeBox;
        private System.Windows.Forms.Label blabel;
        private System.Windows.Forms.Label label3;
    }
}
