namespace CayleyTree
{
    partial class ControlPanel
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
            this.btnRedraw = new System.Windows.Forms.Button();
            this.tkbNum = new System.Windows.Forms.TrackBar();
            this.labNum = new System.Windows.Forms.Label();
            this.tkbAng = new System.Windows.Forms.TrackBar();
            this.labAng = new System.Windows.Forms.Label();
            this.tkbSize = new System.Windows.Forms.TrackBar();
            this.labSize = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ckbB = new System.Windows.Forms.CheckBox();
            this.ckbG = new System.Windows.Forms.CheckBox();
            this.ckbR = new System.Windows.Forms.CheckBox();
            this.numB = new System.Windows.Forms.NumericUpDown();
            this.numG = new System.Windows.Forms.NumericUpDown();
            this.numR = new System.Windows.Forms.NumericUpDown();
            this.rdbMode2 = new System.Windows.Forms.RadioButton();
            this.cbxColor = new System.Windows.Forms.ComboBox();
            this.rdbMode1 = new System.Windows.Forms.RadioButton();
            this.btnDefault = new System.Windows.Forms.Button();
            this.tkbLen = new System.Windows.Forms.TrackBar();
            this.labLen = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numSubT = new System.Windows.Forms.NumericUpDown();
            this.numPos = new System.Windows.Forms.NumericUpDown();
            this.numAng = new System.Windows.Forms.NumericUpDown();
            this.numLen = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRondom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tkbNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbAng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbSize)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbLen)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSubT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLen)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRedraw
            // 
            this.btnRedraw.Location = new System.Drawing.Point(102, 502);
            this.btnRedraw.Name = "btnRedraw";
            this.btnRedraw.Size = new System.Drawing.Size(78, 52);
            this.btnRedraw.TabIndex = 0;
            this.btnRedraw.Text = "Redraw";
            this.btnRedraw.UseVisualStyleBackColor = true;
            this.btnRedraw.Click += new System.EventHandler(this.btnRedraw_Click);
            // 
            // tkbNum
            // 
            this.tkbNum.AutoSize = false;
            this.tkbNum.Location = new System.Drawing.Point(6, 21);
            this.tkbNum.Maximum = 15;
            this.tkbNum.Minimum = 5;
            this.tkbNum.Name = "tkbNum";
            this.tkbNum.Size = new System.Drawing.Size(200, 30);
            this.tkbNum.TabIndex = 1;
            this.tkbNum.Value = 13;
            this.tkbNum.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // labNum
            // 
            this.labNum.AutoSize = true;
            this.labNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNum.Location = new System.Drawing.Point(206, 26);
            this.labNum.Name = "labNum";
            this.labNum.Size = new System.Drawing.Size(24, 17);
            this.labNum.TabIndex = 3;
            this.labNum.Text = "13";
            // 
            // tkbAng
            // 
            this.tkbAng.AutoSize = false;
            this.tkbAng.Location = new System.Drawing.Point(6, 57);
            this.tkbAng.Maximum = 50;
            this.tkbAng.Minimum = 25;
            this.tkbAng.Name = "tkbAng";
            this.tkbAng.Size = new System.Drawing.Size(200, 30);
            this.tkbAng.TabIndex = 1;
            this.tkbAng.TickFrequency = 2;
            this.tkbAng.Value = 30;
            this.tkbAng.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // labAng
            // 
            this.labAng.AutoSize = true;
            this.labAng.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAng.Location = new System.Drawing.Point(206, 62);
            this.labAng.Name = "labAng";
            this.labAng.Size = new System.Drawing.Size(24, 17);
            this.labAng.TabIndex = 3;
            this.labAng.Text = "30";
            // 
            // tkbSize
            // 
            this.tkbSize.AutoSize = false;
            this.tkbSize.Location = new System.Drawing.Point(6, 21);
            this.tkbSize.Maximum = 20;
            this.tkbSize.Minimum = 1;
            this.tkbSize.Name = "tkbSize";
            this.tkbSize.Size = new System.Drawing.Size(200, 30);
            this.tkbSize.TabIndex = 1;
            this.tkbSize.Value = 10;
            this.tkbSize.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // labSize
            // 
            this.labSize.AutoSize = true;
            this.labSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSize.Location = new System.Drawing.Point(207, 25);
            this.labSize.Name = "labSize";
            this.labSize.Size = new System.Drawing.Size(24, 17);
            this.labSize.TabIndex = 3;
            this.labSize.Text = "10";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.ckbB);
            this.groupBox6.Controls.Add(this.ckbG);
            this.groupBox6.Controls.Add(this.ckbR);
            this.groupBox6.Controls.Add(this.numB);
            this.groupBox6.Controls.Add(this.numG);
            this.groupBox6.Controls.Add(this.numR);
            this.groupBox6.Controls.Add(this.rdbMode2);
            this.groupBox6.Controls.Add(this.cbxColor);
            this.groupBox6.Controls.Add(this.rdbMode1);
            this.groupBox6.Location = new System.Drawing.Point(9, 388);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(262, 108);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Color";
            // 
            // ckbB
            // 
            this.ckbB.AutoSize = true;
            this.ckbB.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbB.Checked = true;
            this.ckbB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbB.Location = new System.Drawing.Point(119, 77);
            this.ckbB.Name = "ckbB";
            this.ckbB.Size = new System.Drawing.Size(39, 21);
            this.ckbB.TabIndex = 4;
            this.ckbB.Text = "B";
            this.ckbB.UseVisualStyleBackColor = true;
            this.ckbB.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // ckbG
            // 
            this.ckbG.AutoSize = true;
            this.ckbG.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbG.Location = new System.Drawing.Point(117, 50);
            this.ckbG.Name = "ckbG";
            this.ckbG.Size = new System.Drawing.Size(41, 21);
            this.ckbG.TabIndex = 4;
            this.ckbG.Text = "G";
            this.ckbG.UseVisualStyleBackColor = true;
            this.ckbG.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // ckbR
            // 
            this.ckbR.AutoSize = true;
            this.ckbR.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbR.Location = new System.Drawing.Point(118, 23);
            this.ckbR.Name = "ckbR";
            this.ckbR.Size = new System.Drawing.Size(40, 21);
            this.ckbR.TabIndex = 4;
            this.ckbR.Text = "R";
            this.ckbR.UseVisualStyleBackColor = true;
            this.ckbR.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // numB
            // 
            this.numB.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numB.Location = new System.Drawing.Point(173, 77);
            this.numB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numB.Name = "numB";
            this.numB.Size = new System.Drawing.Size(59, 22);
            this.numB.TabIndex = 3;
            this.numB.Value = new decimal(new int[] {
            111,
            0,
            0,
            0});
            this.numB.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numG
            // 
            this.numG.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numG.Location = new System.Drawing.Point(173, 49);
            this.numG.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numG.Name = "numG";
            this.numG.Size = new System.Drawing.Size(59, 22);
            this.numG.TabIndex = 3;
            this.numG.Value = new decimal(new int[] {
            222,
            0,
            0,
            0});
            this.numG.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numR
            // 
            this.numR.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numR.Location = new System.Drawing.Point(173, 21);
            this.numR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numR.Name = "numR";
            this.numR.Size = new System.Drawing.Size(59, 22);
            this.numR.TabIndex = 3;
            this.numR.Value = new decimal(new int[] {
            111,
            0,
            0,
            0});
            this.numR.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // rdbMode2
            // 
            this.rdbMode2.AutoSize = true;
            this.rdbMode2.Location = new System.Drawing.Point(26, 77);
            this.rdbMode2.Name = "rdbMode2";
            this.rdbMode2.Size = new System.Drawing.Size(76, 21);
            this.rdbMode2.TabIndex = 2;
            this.rdbMode2.Text = "Mode 2";
            this.rdbMode2.UseVisualStyleBackColor = true;
            this.rdbMode2.Click += new System.EventHandler(this.rdbMode_CheckedChanged);
            // 
            // cbxColor
            // 
            this.cbxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxColor.FormattingEnabled = true;
            this.cbxColor.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue",
            "Random"});
            this.cbxColor.Location = new System.Drawing.Point(26, 21);
            this.cbxColor.Name = "cbxColor";
            this.cbxColor.Size = new System.Drawing.Size(76, 24);
            this.cbxColor.TabIndex = 1;
            this.cbxColor.SelectedIndexChanged += new System.EventHandler(this.cbxColor_SelectedIndexChanged);
            // 
            // rdbMode1
            // 
            this.rdbMode1.AutoSize = true;
            this.rdbMode1.Checked = true;
            this.rdbMode1.Location = new System.Drawing.Point(26, 51);
            this.rdbMode1.Name = "rdbMode1";
            this.rdbMode1.Size = new System.Drawing.Size(76, 21);
            this.rdbMode1.TabIndex = 2;
            this.rdbMode1.TabStop = true;
            this.rdbMode1.Text = "Mode 1";
            this.rdbMode1.UseVisualStyleBackColor = true;
            this.rdbMode1.CheckedChanged += new System.EventHandler(this.rdbMode_CheckedChanged);
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(9, 502);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(78, 52);
            this.btnDefault.TabIndex = 6;
            this.btnDefault.Text = "Default";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // tkbLen
            // 
            this.tkbLen.AutoSize = false;
            this.tkbLen.Location = new System.Drawing.Point(6, 57);
            this.tkbLen.Maximum = 150;
            this.tkbLen.Minimum = 50;
            this.tkbLen.Name = "tkbLen";
            this.tkbLen.Size = new System.Drawing.Size(200, 30);
            this.tkbLen.SmallChange = 10;
            this.tkbLen.TabIndex = 1;
            this.tkbLen.TickFrequency = 10;
            this.tkbLen.Value = 100;
            this.tkbLen.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // labLen
            // 
            this.labLen.AutoSize = true;
            this.labLen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLen.Location = new System.Drawing.Point(207, 61);
            this.labLen.Name = "labLen";
            this.labLen.Size = new System.Drawing.Size(32, 17);
            this.labLen.TabIndex = 3;
            this.labLen.Text = "100";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.numSubT);
            this.groupBox4.Controls.Add(this.numPos);
            this.groupBox4.Controls.Add(this.numAng);
            this.groupBox4.Controls.Add(this.numLen);
            this.groupBox4.Location = new System.Drawing.Point(9, 226);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(263, 156);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branch (Others)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "SubTruck";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Postion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Angle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Length";
            // 
            // numSubT
            // 
            this.numSubT.DecimalPlaces = 2;
            this.numSubT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSubT.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numSubT.Location = new System.Drawing.Point(132, 114);
            this.numSubT.Maximum = new decimal(new int[] {
            101,
            0,
            0,
            131072});
            this.numSubT.Minimum = new decimal(new int[] {
            59,
            0,
            0,
            131072});
            this.numSubT.Name = "numSubT";
            this.numSubT.Size = new System.Drawing.Size(100, 24);
            this.numSubT.TabIndex = 1;
            this.numSubT.Value = new decimal(new int[] {
            80,
            0,
            0,
            131072});
            // 
            // numPos
            // 
            this.numPos.DecimalPlaces = 2;
            this.numPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPos.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numPos.Location = new System.Drawing.Point(132, 84);
            this.numPos.Maximum = new decimal(new int[] {
            115,
            0,
            0,
            131072});
            this.numPos.Minimum = new decimal(new int[] {
            85,
            0,
            0,
            131072});
            this.numPos.Name = "numPos";
            this.numPos.Size = new System.Drawing.Size(100, 24);
            this.numPos.TabIndex = 1;
            this.numPos.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            // 
            // numAng
            // 
            this.numAng.DecimalPlaces = 2;
            this.numAng.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAng.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numAng.Location = new System.Drawing.Point(132, 54);
            this.numAng.Maximum = new decimal(new int[] {
            115,
            0,
            0,
            131072});
            this.numAng.Minimum = new decimal(new int[] {
            85,
            0,
            0,
            131072});
            this.numAng.Name = "numAng";
            this.numAng.Size = new System.Drawing.Size(100, 24);
            this.numAng.TabIndex = 1;
            this.numAng.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            // 
            // numLen
            // 
            this.numLen.DecimalPlaces = 2;
            this.numLen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLen.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numLen.Location = new System.Drawing.Point(132, 23);
            this.numLen.Maximum = new decimal(new int[] {
            115,
            0,
            0,
            131072});
            this.numLen.Minimum = new decimal(new int[] {
            85,
            0,
            0,
            131072});
            this.numLen.Name = "numLen";
            this.numLen.Size = new System.Drawing.Size(100, 24);
            this.numLen.TabIndex = 1;
            this.numLen.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tkbAng);
            this.groupBox1.Controls.Add(this.labAng);
            this.groupBox1.Controls.Add(this.tkbNum);
            this.groupBox1.Controls.Add(this.labNum);
            this.groupBox1.Location = new System.Drawing.Point(9, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Branch (Num/Angle)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tkbSize);
            this.groupBox3.Controls.Add(this.tkbLen);
            this.groupBox3.Controls.Add(this.labLen);
            this.groupBox3.Controls.Add(this.labSize);
            this.groupBox3.Location = new System.Drawing.Point(9, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Trunk (Size/Length)";
            // 
            // btnRondom
            // 
            this.btnRondom.Location = new System.Drawing.Point(193, 502);
            this.btnRondom.Name = "btnRondom";
            this.btnRondom.Size = new System.Drawing.Size(78, 52);
            this.btnRondom.TabIndex = 7;
            this.btnRondom.Text = "Random";
            this.btnRondom.UseVisualStyleBackColor = true;
            this.btnRondom.Click += new System.EventHandler(this.btnRondom_Click);
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 563);
            this.Controls.Add(this.btnRondom);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRedraw);
            this.Location = new System.Drawing.Point(20, 50);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ControlPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Control Panel";
            ((System.ComponentModel.ISupportInitialize)(this.tkbNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbAng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbSize)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbLen)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSubT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLen)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRedraw;
        private System.Windows.Forms.TrackBar tkbNum;
        private System.Windows.Forms.Label labNum;
        private System.Windows.Forms.TrackBar tkbAng;
        private System.Windows.Forms.Label labAng;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cbxColor;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.TrackBar tkbSize;
        private System.Windows.Forms.Label labSize;
        private System.Windows.Forms.TrackBar tkbLen;
        private System.Windows.Forms.Label labLen;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numLen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numPos;
        private System.Windows.Forms.NumericUpDown numAng;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numSubT;
        private System.Windows.Forms.RadioButton rdbMode2;
        private System.Windows.Forms.RadioButton rdbMode1;
        private System.Windows.Forms.NumericUpDown numR;
        private System.Windows.Forms.NumericUpDown numB;
        private System.Windows.Forms.NumericUpDown numG;
        private System.Windows.Forms.CheckBox ckbR;
        private System.Windows.Forms.CheckBox ckbB;
        private System.Windows.Forms.CheckBox ckbG;
        private System.Windows.Forms.Button btnRondom;
    }
}

