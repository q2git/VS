namespace StampMaker
{
    partial class Form1
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
            this.picStamp = new System.Windows.Forms.PictureBox();
            this.btnMake = new System.Windows.Forms.Button();
            this.txtStamp = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numShiftY = new System.Windows.Forms.NumericUpDown();
            this.numAngB = new System.Windows.Forms.NumericUpDown();
            this.numAngT = new System.Windows.Forms.NumericUpDown();
            this.numShiftX = new System.Windows.Forms.NumericUpDown();
            this.numFontSize = new System.Windows.Forms.NumericUpDown();
            this.cbFonts = new System.Windows.Forms.ComboBox();
            this.txtPenSize = new System.Windows.Forms.TextBox();
            this.txtMid = new System.Windows.Forms.TextBox();
            this.txtBottom = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picStamp)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numShiftY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAngB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAngT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numShiftX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // picStamp
            // 
            this.picStamp.BackColor = System.Drawing.Color.White;
            this.picStamp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picStamp.Location = new System.Drawing.Point(12, 12);
            this.picStamp.Margin = new System.Windows.Forms.Padding(3, 3, 15, 15);
            this.picStamp.Name = "picStamp";
            this.picStamp.Size = new System.Drawing.Size(400, 400);
            this.picStamp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picStamp.TabIndex = 0;
            this.picStamp.TabStop = false;
            this.picStamp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picStamp_MouseClick);
            this.picStamp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picStamp_MouseMove);
            // 
            // btnMake
            // 
            this.btnMake.Location = new System.Drawing.Point(111, 454);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(80, 36);
            this.btnMake.TabIndex = 1;
            this.btnMake.Text = "制作";
            this.btnMake.UseVisualStyleBackColor = true;
            this.btnMake.Click += new System.EventHandler(this.btnMake_Click);
            // 
            // txtStamp
            // 
            this.txtStamp.Location = new System.Drawing.Point(70, 363);
            this.txtStamp.Name = "txtStamp";
            this.txtStamp.Size = new System.Drawing.Size(121, 22);
            this.txtStamp.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.numShiftY);
            this.groupBox1.Controls.Add(this.numAngB);
            this.groupBox1.Controls.Add(this.numAngT);
            this.groupBox1.Controls.Add(this.numShiftX);
            this.groupBox1.Controls.Add(this.numFontSize);
            this.groupBox1.Controls.Add(this.cbFonts);
            this.groupBox1.Controls.Add(this.txtPenSize);
            this.groupBox1.Controls.Add(this.btnMake);
            this.groupBox1.Controls.Add(this.txtMid);
            this.groupBox1.Controls.Add(this.txtBottom);
            this.groupBox1.Controls.Add(this.txtStamp);
            this.groupBox1.Controls.Add(this.txtHeight);
            this.groupBox1.Controls.Add(this.txtWidth);
            this.groupBox1.Controls.Add(this.trackBar3);
            this.groupBox1.Controls.Add(this.trackBar2);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(568, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 514);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参数设置";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "样品";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numShiftY
            // 
            this.numShiftY.Location = new System.Drawing.Point(140, 307);
            this.numShiftY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numShiftY.Name = "numShiftY";
            this.numShiftY.Size = new System.Drawing.Size(51, 22);
            this.numShiftY.TabIndex = 5;
            this.numShiftY.ValueChanged += new System.EventHandler(this.numValueChanged);
            // 
            // numAngB
            // 
            this.numAngB.Location = new System.Drawing.Point(140, 335);
            this.numAngB.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numAngB.Name = "numAngB";
            this.numAngB.Size = new System.Drawing.Size(51, 22);
            this.numAngB.TabIndex = 5;
            this.numAngB.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numAngB.ValueChanged += new System.EventHandler(this.numValueChanged);
            // 
            // numAngT
            // 
            this.numAngT.Location = new System.Drawing.Point(71, 335);
            this.numAngT.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numAngT.Name = "numAngT";
            this.numAngT.Size = new System.Drawing.Size(51, 22);
            this.numAngT.TabIndex = 5;
            this.numAngT.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numAngT.ValueChanged += new System.EventHandler(this.numValueChanged);
            // 
            // numShiftX
            // 
            this.numShiftX.Location = new System.Drawing.Point(71, 307);
            this.numShiftX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numShiftX.Name = "numShiftX";
            this.numShiftX.Size = new System.Drawing.Size(51, 22);
            this.numShiftX.TabIndex = 5;
            this.numShiftX.ValueChanged += new System.EventHandler(this.numValueChanged);
            // 
            // numFontSize
            // 
            this.numFontSize.Location = new System.Drawing.Point(71, 274);
            this.numFontSize.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numFontSize.Name = "numFontSize";
            this.numFontSize.Size = new System.Drawing.Size(120, 22);
            this.numFontSize.TabIndex = 5;
            this.numFontSize.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numFontSize.ValueChanged += new System.EventHandler(this.numValueChanged);
            // 
            // cbFonts
            // 
            this.cbFonts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFonts.DropDownWidth = 200;
            this.cbFonts.FormattingEnabled = true;
            this.cbFonts.Location = new System.Drawing.Point(70, 240);
            this.cbFonts.Name = "cbFonts";
            this.cbFonts.Size = new System.Drawing.Size(121, 24);
            this.cbFonts.TabIndex = 4;
            this.cbFonts.SelectedIndexChanged += new System.EventHandler(this.numValueChanged);
            // 
            // txtPenSize
            // 
            this.txtPenSize.Location = new System.Drawing.Point(140, 183);
            this.txtPenSize.Name = "txtPenSize";
            this.txtPenSize.Size = new System.Drawing.Size(51, 22);
            this.txtPenSize.TabIndex = 3;
            this.txtPenSize.TextChanged += new System.EventHandler(this.numValueChanged);
            // 
            // txtMid
            // 
            this.txtMid.Location = new System.Drawing.Point(70, 391);
            this.txtMid.MaxLength = 4;
            this.txtMid.Name = "txtMid";
            this.txtMid.Size = new System.Drawing.Size(121, 22);
            this.txtMid.TabIndex = 2;
            // 
            // txtBottom
            // 
            this.txtBottom.Location = new System.Drawing.Point(70, 419);
            this.txtBottom.Name = "txtBottom";
            this.txtBottom.Size = new System.Drawing.Size(121, 22);
            this.txtBottom.TabIndex = 2;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(140, 123);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(51, 22);
            this.txtHeight.TabIndex = 3;
            this.txtHeight.TextChanged += new System.EventHandler(this.numValueChanged);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(140, 62);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(51, 22);
            this.txtWidth.TabIndex = 3;
            this.txtWidth.TextChanged += new System.EventHandler(this.numValueChanged);
            // 
            // trackBar3
            // 
            this.trackBar3.AutoSize = false;
            this.trackBar3.Location = new System.Drawing.Point(6, 207);
            this.trackBar3.Maximum = 50;
            this.trackBar3.Minimum = 1;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(202, 27);
            this.trackBar3.TabIndex = 2;
            this.trackBar3.TickFrequency = 2;
            this.trackBar3.Value = 1;
            this.trackBar3.ValueChanged += new System.EventHandler(this.numValueChanged);
            // 
            // trackBar2
            // 
            this.trackBar2.AutoSize = false;
            this.trackBar2.Location = new System.Drawing.Point(6, 147);
            this.trackBar2.Maximum = 300;
            this.trackBar2.Minimum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(202, 27);
            this.trackBar2.TabIndex = 2;
            this.trackBar2.TickFrequency = 10;
            this.trackBar2.Value = 100;
            this.trackBar2.ValueChanged += new System.EventHandler(this.numValueChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(6, 90);
            this.trackBar1.Maximum = 300;
            this.trackBar1.Minimum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(202, 27);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.Value = 100;
            this.trackBar1.ValueChanged += new System.EventHandler(this.numValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "宽度:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "文字:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "角度:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "偏移:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "字号:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "字体:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "粗细:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(116, 28);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(57, 21);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "矩形";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.rdbtChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "高度:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(18, 28);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "圆形";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.rdbtChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(782, 514);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picStamp);
            this.Name = "Form1";
            this.Text = "Stamp Maker";
            ((System.ComponentModel.ISupportInitialize)(this.picStamp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numShiftY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAngB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAngT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numShiftX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picStamp;
        private System.Windows.Forms.Button btnMake;
        private System.Windows.Forms.TextBox txtStamp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TextBox txtPenSize;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFonts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numFontSize;
        private System.Windows.Forms.NumericUpDown numShiftX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numShiftY;
        private System.Windows.Forms.NumericUpDown numAngT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numAngB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBottom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMid;
    }
}

