namespace Trader
{
    partial class QuotePanel
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
            this.labPercent = new System.Windows.Forms.Label();
            this.labPrice = new System.Windows.Forms.Label();
            this.cbxMarket = new System.Windows.Forms.ComboBox();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnDay = new System.Windows.Forms.Button();
            this.btnWeek = new System.Windows.Forms.Button();
            this.btnMonth = new System.Windows.Forms.Button();
            this.cbxStock = new System.Windows.Forms.ComboBox();
            this.picChart = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picChart)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labPercent
            // 
            this.labPercent.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labPercent.ForeColor = System.Drawing.Color.White;
            this.labPercent.Location = new System.Drawing.Point(4, 130);
            this.labPercent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPercent.MinimumSize = new System.Drawing.Size(67, 0);
            this.labPercent.Name = "labPercent";
            this.labPercent.Size = new System.Drawing.Size(100, 28);
            this.labPercent.TabIndex = 7;
            this.labPercent.Text = "pct";
            this.labPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labPrice
            // 
            this.labPrice.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labPrice.ForeColor = System.Drawing.Color.White;
            this.labPrice.Location = new System.Drawing.Point(4, 102);
            this.labPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPrice.MinimumSize = new System.Drawing.Size(67, 0);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(100, 28);
            this.labPrice.TabIndex = 7;
            this.labPrice.Text = "pri";
            this.labPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxMarket
            // 
            this.cbxMarket.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxMarket.DropDownHeight = 100;
            this.cbxMarket.DropDownWidth = 120;
            this.cbxMarket.FormattingEnabled = true;
            this.cbxMarket.IntegralHeight = false;
            this.cbxMarket.Location = new System.Drawing.Point(3, 29);
            this.cbxMarket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxMarket.Name = "cbxMarket";
            this.cbxMarket.Size = new System.Drawing.Size(102, 24);
            this.cbxMarket.TabIndex = 4;
            this.cbxMarket.SelectedValueChanged += new System.EventHandler(this.cbxMarket_SelectedValueChanged);
            // 
            // btnMin
            // 
            this.btnMin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Location = new System.Drawing.Point(4, 181);
            this.btnMin.Margin = new System.Windows.Forms.Padding(4);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(100, 30);
            this.btnMin.TabIndex = 0;
            this.btnMin.Tag = "";
            this.btnMin.Text = "min";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnPeriod_Click);
            // 
            // btnDay
            // 
            this.btnDay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDay.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnDay.FlatAppearance.BorderSize = 0;
            this.btnDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDay.Location = new System.Drawing.Point(4, 219);
            this.btnDay.Margin = new System.Windows.Forms.Padding(4);
            this.btnDay.Name = "btnDay";
            this.btnDay.Size = new System.Drawing.Size(100, 30);
            this.btnDay.TabIndex = 0;
            this.btnDay.Tag = "";
            this.btnDay.Text = "daily";
            this.btnDay.UseVisualStyleBackColor = true;
            this.btnDay.Click += new System.EventHandler(this.btnPeriod_Click);
            // 
            // btnWeek
            // 
            this.btnWeek.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnWeek.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnWeek.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnWeek.FlatAppearance.BorderSize = 0;
            this.btnWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeek.Location = new System.Drawing.Point(4, 257);
            this.btnWeek.Margin = new System.Windows.Forms.Padding(4);
            this.btnWeek.Name = "btnWeek";
            this.btnWeek.Size = new System.Drawing.Size(100, 30);
            this.btnWeek.TabIndex = 0;
            this.btnWeek.Tag = "";
            this.btnWeek.Text = "weekly";
            this.btnWeek.UseVisualStyleBackColor = true;
            this.btnWeek.Click += new System.EventHandler(this.btnPeriod_Click);
            // 
            // btnMonth
            // 
            this.btnMonth.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMonth.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnMonth.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnMonth.FlatAppearance.BorderSize = 0;
            this.btnMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonth.Location = new System.Drawing.Point(4, 295);
            this.btnMonth.Margin = new System.Windows.Forms.Padding(4);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(100, 30);
            this.btnMonth.TabIndex = 0;
            this.btnMonth.Tag = "";
            this.btnMonth.Text = "monthly";
            this.btnMonth.UseVisualStyleBackColor = true;
            this.btnMonth.Click += new System.EventHandler(this.btnPeriod_Click);
            // 
            // cbxStock
            // 
            this.cbxStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxStock.DropDownHeight = 100;
            this.cbxStock.DropDownWidth = 120;
            this.cbxStock.FormattingEnabled = true;
            this.cbxStock.IntegralHeight = false;
            this.cbxStock.Location = new System.Drawing.Point(3, 57);
            this.cbxStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxStock.Name = "cbxStock";
            this.cbxStock.Size = new System.Drawing.Size(102, 24);
            this.cbxStock.TabIndex = 5;
            // 
            // picChart
            // 
            this.picChart.BackColor = System.Drawing.Color.White;
            this.picChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picChart.Location = new System.Drawing.Point(111, 0);
            this.picChart.Margin = new System.Windows.Forms.Padding(4);
            this.picChart.Name = "picChart";
            this.picChart.Size = new System.Drawing.Size(567, 417);
            this.picChart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picChart.TabIndex = 1;
            this.picChart.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.labTime);
            this.flowLayoutPanel1.Controls.Add(this.cbxMarket);
            this.flowLayoutPanel1.Controls.Add(this.cbxStock);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.labPrice);
            this.flowLayoutPanel1.Controls.Add(this.labPercent);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.btnMin);
            this.flowLayoutPanel1.Controls.Add(this.btnDay);
            this.flowLayoutPanel1.Controls.Add(this.btnWeek);
            this.flowLayoutPanel1.Controls.Add(this.btnMonth);
            this.flowLayoutPanel1.Controls.Add(this.btnRun);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(111, 417);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // labTime
            // 
            this.labTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.labTime.ForeColor = System.Drawing.Color.Blue;
            this.labTime.Location = new System.Drawing.Point(3, 0);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(102, 27);
            this.labTime.TabIndex = 9;
            this.labTime.Text = "  ";
            this.labTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.MinimumSize = new System.Drawing.Size(67, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "pct";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.MinimumSize = new System.Drawing.Size(67, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "pct";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRun
            // 
            this.btnRun.AutoSize = true;
            this.btnRun.BackColor = System.Drawing.Color.LightGray;
            this.btnRun.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRun.Location = new System.Drawing.Point(3, 332);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(102, 33);
            this.btnRun.TabIndex = 10;
            this.btnRun.Text = "Stop";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // QuotePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.picChart);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuotePanel";
            this.Size = new System.Drawing.Size(678, 417);
            this.Load += new System.EventHandler(this.QuotePanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picChart)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMonth;
        private System.Windows.Forms.PictureBox picChart;
        private System.Windows.Forms.ComboBox cbxMarket;
        private System.Windows.Forms.ComboBox cbxStock;
        private System.Windows.Forms.Label labPercent;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnDay;
        private System.Windows.Forms.Button btnWeek;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
