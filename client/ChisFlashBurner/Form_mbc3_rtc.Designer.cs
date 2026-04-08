namespace ChisFlashBurner
{
    partial class Form_mbc3_rtc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_mbc3_rtc));
            this.label3 = new System.Windows.Forms.Label();
            this.nud_day = new System.Windows.Forms.NumericUpDown();
            this.nud_hour = new System.Windows.Forms.NumericUpDown();
            this.nud_minute = new System.Windows.Forms.NumericUpDown();
            this.nud_second = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_day)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_minute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_second)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // nud_day
            // 
            resources.ApplyResources(this.nud_day, "nud_day");
            this.nud_day.Maximum = new decimal(new int[] {
            511,
            0,
            0,
            0});
            this.nud_day.Name = "nud_day";
            this.nud_day.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud_hour
            // 
            resources.ApplyResources(this.nud_hour, "nud_hour");
            this.nud_hour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nud_hour.Name = "nud_hour";
            this.nud_hour.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud_minute
            // 
            resources.ApplyResources(this.nud_minute, "nud_minute");
            this.nud_minute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nud_minute.Name = "nud_minute";
            this.nud_minute.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud_second
            // 
            resources.ApplyResources(this.nud_second, "nud_second");
            this.nud_second.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nud_second.Name = "nud_second";
            this.nud_second.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_mbc3_rtc
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nud_second);
            this.Controls.Add(this.nud_minute);
            this.Controls.Add(this.nud_hour);
            this.Controls.Add(this.nud_day);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_mbc3_rtc";
            this.Load += new System.EventHandler(this.Form_mbc3_rtc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_day)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_minute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_second)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_day;
        private System.Windows.Forms.NumericUpDown nud_hour;
        private System.Windows.Forms.NumericUpDown nud_minute;
        private System.Windows.Forms.NumericUpDown nud_second;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}