namespace Game2048
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.labScore = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRestart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labMaxScore = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBoard
            // 
            this.pnlBoard.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBoard.Location = new System.Drawing.Point(0, 83);
            this.pnlBoard.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(352, 322);
            this.pnlBoard.TabIndex = 0;
            // 
            // labScore
            // 
            this.labScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labScore.ForeColor = System.Drawing.Color.Red;
            this.labScore.Location = new System.Drawing.Point(256, 36);
            this.labScore.Name = "labScore";
            this.labScore.Size = new System.Drawing.Size(84, 27);
            this.labScore.TabIndex = 1;
            this.labScore.Text = "0     ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRestart);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.labMaxScore);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.labScore);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 77);
            this.panel1.TabIndex = 2;
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(132, 3);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(38, 60);
            this.btnRestart.TabIndex = 5;
            this.btnRestart.TabStop = false;
            this.btnRestart.Text = "重来";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "最高得分";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "当前得分";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(66, 36);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(57, 27);
            this.button4.TabIndex = 3;
            this.button4.TabStop = false;
            this.button4.Text = "军衔";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.modeChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 27);
            this.button3.TabIndex = 3;
            this.button3.TabStop = false;
            this.button3.Text = "官阶";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.modeChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(66, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 27);
            this.button2.TabIndex = 3;
            this.button2.TabStop = false;
            this.button2.Text = "朝代";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.modeChanged);
            // 
            // labMaxScore
            // 
            this.labMaxScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labMaxScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labMaxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMaxScore.ForeColor = System.Drawing.Color.Navy;
            this.labMaxScore.Location = new System.Drawing.Point(256, 5);
            this.labMaxScore.Name = "labMaxScore";
            this.labMaxScore.Size = new System.Drawing.Size(84, 27);
            this.labMaxScore.TabIndex = 1;
            this.labMaxScore.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 27);
            this.button1.TabIndex = 3;
            this.button1.TabStop = false;
            this.button1.Text = "数字";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.modeChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 405);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBoard);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.Label labScore;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labMaxScore;
        private System.Windows.Forms.Button btnRestart;
    }
}

