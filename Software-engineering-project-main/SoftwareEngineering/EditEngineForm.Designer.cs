namespace SoftwareEngineering
{
    partial class EditEngineForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RPMLabel = new System.Windows.Forms.Label();
            this.BHPLabel = new System.Windows.Forms.Label();
            this.CompLabel = new System.Windows.Forms.Label();
            this.StrokeLabel = new System.Windows.Forms.Label();
            this.CylinderLabel = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.BoreLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.AspirationLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SystemLabel = new System.Windows.Forms.Label();
            this.FuelLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.comboEngType = new System.Windows.Forms.ComboBox();
            this.comboAsp = new System.Windows.Forms.ComboBox();
            this.comboFuelType = new System.Windows.Forms.ComboBox();
            this.comboFuelSys = new System.Windows.Forms.ComboBox();
            this.numStroke = new System.Windows.Forms.NumericUpDown();
            this.numBore = new System.Windows.Forms.NumericUpDown();
            this.numComp = new System.Windows.Forms.NumericUpDown();
            this.numSize = new System.Windows.Forms.NumericUpDown();
            this.numCylinder = new System.Windows.Forms.NumericUpDown();
            this.numBHP = new System.Windows.Forms.NumericUpDown();
            this.numRPM = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStroke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numComp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCylinder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRPM)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.Controls.Add(this.numRPM);
            this.groupBox1.Controls.Add(this.numBHP);
            this.groupBox1.Controls.Add(this.numCylinder);
            this.groupBox1.Controls.Add(this.numSize);
            this.groupBox1.Controls.Add(this.numComp);
            this.groupBox1.Controls.Add(this.numBore);
            this.groupBox1.Controls.Add(this.numStroke);
            this.groupBox1.Controls.Add(this.comboAsp);
            this.groupBox1.Controls.Add(this.comboEngType);
            this.groupBox1.Controls.Add(this.RPMLabel);
            this.groupBox1.Controls.Add(this.BHPLabel);
            this.groupBox1.Controls.Add(this.CompLabel);
            this.groupBox1.Controls.Add(this.StrokeLabel);
            this.groupBox1.Controls.Add(this.CylinderLabel);
            this.groupBox1.Controls.Add(this.SizeLabel);
            this.groupBox1.Controls.Add(this.BoreLabel);
            this.groupBox1.Controls.Add(this.TypeLabel);
            this.groupBox1.Controls.Add(this.AspirationLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(16, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 189);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic";
            // 
            // RPMLabel
            // 
            this.RPMLabel.AutoSize = true;
            this.RPMLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RPMLabel.Location = new System.Drawing.Point(12, 160);
            this.RPMLabel.Name = "RPMLabel";
            this.RPMLabel.Size = new System.Drawing.Size(42, 13);
            this.RPMLabel.TabIndex = 9;
            this.RPMLabel.Text = "RPM: ";
            // 
            // BHPLabel
            // 
            this.BHPLabel.AutoSize = true;
            this.BHPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BHPLabel.Location = new System.Drawing.Point(13, 132);
            this.BHPLabel.Name = "BHPLabel";
            this.BHPLabel.Size = new System.Drawing.Size(32, 13);
            this.BHPLabel.TabIndex = 8;
            this.BHPLabel.Text = "BHP";
            // 
            // CompLabel
            // 
            this.CompLabel.AutoSize = true;
            this.CompLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompLabel.Location = new System.Drawing.Point(239, 77);
            this.CompLabel.Name = "CompLabel";
            this.CompLabel.Size = new System.Drawing.Size(120, 13);
            this.CompLabel.TabIndex = 7;
            this.CompLabel.Text = "Compression Ratio: ";
            // 
            // StrokeLabel
            // 
            this.StrokeLabel.AutoSize = true;
            this.StrokeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrokeLabel.Location = new System.Drawing.Point(239, 20);
            this.StrokeLabel.Name = "StrokeLabel";
            this.StrokeLabel.Size = new System.Drawing.Size(48, 13);
            this.StrokeLabel.TabIndex = 6;
            this.StrokeLabel.Text = "Stroke:";
            // 
            // CylinderLabel
            // 
            this.CylinderLabel.AutoSize = true;
            this.CylinderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CylinderLabel.Location = new System.Drawing.Point(12, 104);
            this.CylinderLabel.Name = "CylinderLabel";
            this.CylinderLabel.Size = new System.Drawing.Size(62, 13);
            this.CylinderLabel.TabIndex = 4;
            this.CylinderLabel.Text = "Cylinders:";
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeLabel.Location = new System.Drawing.Point(13, 77);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(35, 13);
            this.SizeLabel.TabIndex = 3;
            this.SizeLabel.Text = "Size:";
            // 
            // BoreLabel
            // 
            this.BoreLabel.AutoSize = true;
            this.BoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoreLabel.Location = new System.Drawing.Point(239, 47);
            this.BoreLabel.Name = "BoreLabel";
            this.BoreLabel.Size = new System.Drawing.Size(71, 13);
            this.BoreLabel.TabIndex = 5;
            this.BoreLabel.Text = "Bore Ratio:";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLabel.Location = new System.Drawing.Point(12, 20);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(39, 13);
            this.TypeLabel.TabIndex = 1;
            this.TypeLabel.Text = "Type:";
            // 
            // AspirationLabel
            // 
            this.AspirationLabel.AutoSize = true;
            this.AspirationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AspirationLabel.Location = new System.Drawing.Point(12, 49);
            this.AspirationLabel.Name = "AspirationLabel";
            this.AspirationLabel.Size = new System.Drawing.Size(67, 13);
            this.AspirationLabel.TabIndex = 0;
            this.AspirationLabel.Text = "Aspiration:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Peru;
            this.groupBox2.Controls.Add(this.comboFuelSys);
            this.groupBox2.Controls.Add(this.comboFuelType);
            this.groupBox2.Controls.Add(this.SystemLabel);
            this.groupBox2.Controls.Add(this.FuelLabel);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(16, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(466, 70);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Basic";
            // 
            // SystemLabel
            // 
            this.SystemLabel.AutoSize = true;
            this.SystemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SystemLabel.Location = new System.Drawing.Point(180, 24);
            this.SystemLabel.Name = "SystemLabel";
            this.SystemLabel.Size = new System.Drawing.Size(79, 13);
            this.SystemLabel.TabIndex = 6;
            this.SystemLabel.Text = "Fuel System:";
            // 
            // FuelLabel
            // 
            this.FuelLabel.AutoSize = true;
            this.FuelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuelLabel.Location = new System.Drawing.Point(12, 24);
            this.FuelLabel.Name = "FuelLabel";
            this.FuelLabel.Size = new System.Drawing.Size(35, 13);
            this.FuelLabel.TabIndex = 1;
            this.FuelLabel.Text = "Fuel:";
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(151)))), ((int)(((byte)(193)))));
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(182, 307);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(121, 23);
            this.submitButton.TabIndex = 11;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // comboEngType
            // 
            this.comboEngType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.comboEngType.FormattingEnabled = true;
            this.comboEngType.Location = new System.Drawing.Point(57, 17);
            this.comboEngType.Name = "comboEngType";
            this.comboEngType.Size = new System.Drawing.Size(176, 21);
            this.comboEngType.TabIndex = 10;
            // 
            // comboAsp
            // 
            this.comboAsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.comboAsp.FormattingEnabled = true;
            this.comboAsp.Location = new System.Drawing.Point(84, 46);
            this.comboAsp.Name = "comboAsp";
            this.comboAsp.Size = new System.Drawing.Size(121, 21);
            this.comboAsp.TabIndex = 11;
            // 
            // comboFuelType
            // 
            this.comboFuelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.comboFuelType.FormattingEnabled = true;
            this.comboFuelType.Location = new System.Drawing.Point(53, 20);
            this.comboFuelType.Name = "comboFuelType";
            this.comboFuelType.Size = new System.Drawing.Size(121, 21);
            this.comboFuelType.TabIndex = 12;
            // 
            // comboFuelSys
            // 
            this.comboFuelSys.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.comboFuelSys.FormattingEnabled = true;
            this.comboFuelSys.Location = new System.Drawing.Point(265, 20);
            this.comboFuelSys.Name = "comboFuelSys";
            this.comboFuelSys.Size = new System.Drawing.Size(168, 21);
            this.comboFuelSys.TabIndex = 13;
            // 
            // numStroke
            // 
            this.numStroke.DecimalPlaces = 2;
            this.numStroke.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numStroke.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numStroke.Location = new System.Drawing.Point(294, 18);
            this.numStroke.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numStroke.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numStroke.Name = "numStroke";
            this.numStroke.Size = new System.Drawing.Size(93, 20);
            this.numStroke.TabIndex = 13;
            // 
            // numBore
            // 
            this.numBore.DecimalPlaces = 2;
            this.numBore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBore.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numBore.Location = new System.Drawing.Point(317, 46);
            this.numBore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numBore.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numBore.Name = "numBore";
            this.numBore.Size = new System.Drawing.Size(93, 20);
            this.numBore.TabIndex = 14;
            // 
            // numComp
            // 
            this.numComp.DecimalPlaces = 2;
            this.numComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numComp.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numComp.Location = new System.Drawing.Point(366, 74);
            this.numComp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numComp.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numComp.Name = "numComp";
            this.numComp.Size = new System.Drawing.Size(93, 20);
            this.numComp.TabIndex = 15;
            // 
            // numSize
            // 
            this.numSize.DecimalPlaces = 2;
            this.numSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSize.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numSize.Location = new System.Drawing.Point(55, 74);
            this.numSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numSize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSize.Name = "numSize";
            this.numSize.Size = new System.Drawing.Size(93, 20);
            this.numSize.TabIndex = 16;
            // 
            // numCylinder
            // 
            this.numCylinder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCylinder.Location = new System.Drawing.Point(81, 102);
            this.numCylinder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numCylinder.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numCylinder.Name = "numCylinder";
            this.numCylinder.Size = new System.Drawing.Size(93, 20);
            this.numCylinder.TabIndex = 17;
            // 
            // numBHP
            // 
            this.numBHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBHP.Location = new System.Drawing.Point(52, 130);
            this.numBHP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numBHP.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numBHP.Name = "numBHP";
            this.numBHP.Size = new System.Drawing.Size(93, 20);
            this.numBHP.TabIndex = 18;
            // 
            // numRPM
            // 
            this.numRPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numRPM.Location = new System.Drawing.Point(53, 158);
            this.numRPM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numRPM.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numRPM.Name = "numRPM";
            this.numRPM.Size = new System.Drawing.Size(93, 20);
            this.numRPM.TabIndex = 19;
            // 
            // EditEngineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(494, 342);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditEngineForm";
            this.Text = "EngineDetailsForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStroke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numComp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCylinder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRPM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label CompLabel;
        private System.Windows.Forms.Label StrokeLabel;
        private System.Windows.Forms.Label CylinderLabel;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Label BoreLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label AspirationLabel;
        private System.Windows.Forms.Label BHPLabel;
        private System.Windows.Forms.Label RPMLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label SystemLabel;
        private System.Windows.Forms.Label FuelLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.ComboBox comboEngType;
        private System.Windows.Forms.ComboBox comboAsp;
        private System.Windows.Forms.ComboBox comboFuelSys;
        private System.Windows.Forms.ComboBox comboFuelType;
        private System.Windows.Forms.NumericUpDown numSize;
        private System.Windows.Forms.NumericUpDown numComp;
        private System.Windows.Forms.NumericUpDown numBore;
        private System.Windows.Forms.NumericUpDown numStroke;
        private System.Windows.Forms.NumericUpDown numRPM;
        private System.Windows.Forms.NumericUpDown numBHP;
        private System.Windows.Forms.NumericUpDown numCylinder;
    }
}