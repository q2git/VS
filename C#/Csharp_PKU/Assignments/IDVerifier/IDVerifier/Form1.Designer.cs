namespace IDVerifier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rtfInputbox = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labLoc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labYear = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labResult = new System.Windows.Forms.Label();
            this.labMonth = new System.Windows.Forms.Label();
            this.labDay = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtfInputbox
            // 
            resources.ApplyResources(this.rtfInputbox, "rtfInputbox");
            this.rtfInputbox.Name = "rtfInputbox";
            this.rtfInputbox.TextChanged += new System.EventHandler(this.rtfInputbox_TextChanged);
            this.rtfInputbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtfInputbox_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labResult);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.labDay);
            this.groupBox1.Controls.Add(this.labMonth);
            this.groupBox1.Controls.Add(this.labYear);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labLoc);
            this.groupBox1.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // labLoc
            // 
            resources.ApplyResources(this.labLoc, "labLoc");
            this.labLoc.Name = "labLoc";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // labYear
            // 
            resources.ApplyResources(this.labYear, "labYear");
            this.labYear.Name = "labYear";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // labResult
            // 
            resources.ApplyResources(this.labResult, "labResult");
            this.labResult.Name = "labResult";
            // 
            // labMonth
            // 
            resources.ApplyResources(this.labMonth, "labMonth");
            this.labMonth.Name = "labMonth";
            // 
            // labDay
            // 
            resources.ApplyResources(this.labDay, "labDay");
            this.labDay.Name = "labDay";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rtfInputbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtfInputbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labLoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labDay;
        private System.Windows.Forms.Label labMonth;
    }
}

