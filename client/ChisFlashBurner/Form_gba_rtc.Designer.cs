namespace ChisFlashBurner
{
    partial class Form_gba_rtc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_gba_rtc));
            this.button1 = new System.Windows.Forms.Button();
            this.nud_year = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nud_month = new System.Windows.Forms.NumericUpDown();
            this.nud_date = new System.Windows.Forms.NumericUpDown();
            this.nud_day = new System.Windows.Forms.NumericUpDown();
            this.nud_hour = new System.Windows.Forms.NumericUpDown();
            this.nud_minute = new System.Windows.Forms.NumericUpDown();
            this.nud_second = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_month)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_day)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_minute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_second)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nud_year
            // 
            resources.ApplyResources(this.nud_year, "nud_year");
            this.nud_year.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nud_year.Name = "nud_year";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // nud_month
            // 
            resources.ApplyResources(this.nud_month, "nud_month");
            this.nud_month.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nud_month.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_month.Name = "nud_month";
            this.nud_month.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud_date
            // 
            resources.ApplyResources(this.nud_date, "nud_date");
            this.nud_date.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nud_date.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_date.Name = "nud_date";
            this.nud_date.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud_day
            // 
            resources.ApplyResources(this.nud_day, "nud_day");
            this.nud_day.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nud_day.Name = "nud_day";
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
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // Form_gba_rtc
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nud_second);
            this.Controls.Add(this.nud_minute);
            this.Controls.Add(this.nud_hour);
            this.Controls.Add(this.nud_day);
            this.Controls.Add(this.nud_date);
            this.Controls.Add(this.nud_month);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud_year);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_gba_rtc";
            this.Load += new System.EventHandler(this.Form_gba_rtc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_month)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_day)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_minute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_second)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nud_year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_month;
        private System.Windows.Forms.NumericUpDown nud_date;
        private System.Windows.Forms.NumericUpDown nud_day;
        private System.Windows.Forms.NumericUpDown nud_hour;
        private System.Windows.Forms.NumericUpDown nud_minute;
        private System.Windows.Forms.NumericUpDown nud_second;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}