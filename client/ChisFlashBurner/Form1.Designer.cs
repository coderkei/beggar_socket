namespace ChisFlashBurner
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_browseRom = new System.Windows.Forms.Button();
            this.textBox_romPath = new System.Windows.Forms.TextBox();
            this.comboBox_com = new System.Windows.Forms.ComboBox();
            this.btn_readID = new System.Windows.Forms.Button();
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.progressBar_total = new System.Windows.Forms.ProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label_progress = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label_speed = new System.Windows.Forms.ToolStripStatusLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_savePath = new System.Windows.Forms.TextBox();
            this.btn_browseSave = new System.Windows.Forms.Button();
            this.btn_eraseChip = new System.Windows.Forms.Button();
            this.btn_writeRom = new System.Windows.Forms.Button();
            this.btn_readRom = new System.Windows.Forms.Button();
            this.btn_verifyRom = new System.Windows.Forms.Button();
            this.btn_writeSave = new System.Windows.Forms.Button();
            this.btn_readSave = new System.Windows.Forms.Button();
            this.btn_verifySave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_saveSize = new System.Windows.Forms.ComboBox();
            this.comboBox_romSize = new System.Windows.Forms.ComboBox();
            this.tmr_showSpeed = new System.Windows.Forms.Timer(this.components);
            this.btn_renewPort = new System.Windows.Forms.Button();
            this.comboBox_ramType = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox_gbaMultiCartSelect = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBox_mbc5V = new System.Windows.Forms.CheckBox();
            this.comboBox_mbcType = new System.Windows.Forms.ComboBox();
            this.comboBox_mbc5RamType = new System.Windows.Forms.ComboBox();
            this.btn_eraseChip_mbc5 = new System.Windows.Forms.Button();
            this.comboBox_mbc5MultiCartSelect = new System.Windows.Forms.ComboBox();
            this.btn_verifyRom_mbc5 = new System.Windows.Forms.Button();
            this.btn_verifySave_mbc5 = new System.Windows.Forms.Button();
            this.comboBox_saveSize_mbc5 = new System.Windows.Forms.ComboBox();
            this.comboBox_romSize_mbc5 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_readRom_mbc5 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_readSave_mbc5 = new System.Windows.Forms.Button();
            this.btn_writeRom_mbc5 = new System.Windows.Forms.Button();
            this.btn_writeSave_mbc5 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_rumbleTest_gba = new System.Windows.Forms.Button();
            this.btn_setRTC_mbc = new System.Windows.Forms.Button();
            this.btn_setRTC_gba = new System.Windows.Forms.Button();
            this.btn_unlockPPB_mbc5 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_unlockPPB_gba = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_browseRom
            // 
            resources.ApplyResources(this.btn_browseRom, "btn_browseRom");
            this.btn_browseRom.Name = "btn_browseRom";
            this.btn_browseRom.UseVisualStyleBackColor = true;
            this.btn_browseRom.Click += new System.EventHandler(this.btn_browseRom_Click);
            // 
            // textBox_romPath
            // 
            resources.ApplyResources(this.textBox_romPath, "textBox_romPath");
            this.textBox_romPath.Name = "textBox_romPath";
            // 
            // comboBox_com
            // 
            resources.ApplyResources(this.comboBox_com, "comboBox_com");
            this.comboBox_com.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox_com.DropDownWidth = 130;
            this.comboBox_com.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboBox_com.FormattingEnabled = true;
            this.comboBox_com.Name = "comboBox_com";
            // 
            // btn_readID
            // 
            resources.ApplyResources(this.btn_readID, "btn_readID");
            this.btn_readID.Name = "btn_readID";
            this.btn_readID.UseVisualStyleBackColor = true;
            this.btn_readID.Click += new System.EventHandler(this.btn_readID_Click);
            // 
            // textBox_log
            // 
            resources.ApplyResources(this.textBox_log, "textBox_log");
            this.textBox_log.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.ReadOnly = true;
            // 
            // progressBar_total
            // 
            resources.ApplyResources(this.progressBar_total, "progressBar_total");
            this.progressBar_total.Name = "progressBar_total";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.label_progress,
            this.toolStripStatusLabel2,
            this.label_speed});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // label_progress
            // 
            this.label_progress.Name = "label_progress";
            resources.ApplyResources(this.label_progress, "label_progress");
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            resources.ApplyResources(this.toolStripStatusLabel2, "toolStripStatusLabel2");
            this.toolStripStatusLabel2.Spring = true;
            // 
            // label_speed
            // 
            this.label_speed.Name = "label_speed";
            resources.ApplyResources(this.label_speed, "label_speed");
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
            // textBox_savePath
            // 
            resources.ApplyResources(this.textBox_savePath, "textBox_savePath");
            this.textBox_savePath.Name = "textBox_savePath";
            // 
            // btn_browseSave
            // 
            resources.ApplyResources(this.btn_browseSave, "btn_browseSave");
            this.btn_browseSave.Name = "btn_browseSave";
            this.btn_browseSave.UseVisualStyleBackColor = true;
            this.btn_browseSave.Click += new System.EventHandler(this.btn_browseSave_Click);
            // 
            // btn_eraseChip
            // 
            resources.ApplyResources(this.btn_eraseChip, "btn_eraseChip");
            this.btn_eraseChip.Name = "btn_eraseChip";
            this.btn_eraseChip.UseVisualStyleBackColor = true;
            this.btn_eraseChip.Click += new System.EventHandler(this.btn_eraseChip_Click);
            // 
            // btn_writeRom
            // 
            resources.ApplyResources(this.btn_writeRom, "btn_writeRom");
            this.btn_writeRom.Name = "btn_writeRom";
            this.btn_writeRom.UseVisualStyleBackColor = true;
            this.btn_writeRom.Click += new System.EventHandler(this.btn_writeRom_Click);
            // 
            // btn_readRom
            // 
            resources.ApplyResources(this.btn_readRom, "btn_readRom");
            this.btn_readRom.Name = "btn_readRom";
            this.btn_readRom.UseVisualStyleBackColor = true;
            this.btn_readRom.Click += new System.EventHandler(this.btn_readRom_Click);
            // 
            // btn_verifyRom
            // 
            resources.ApplyResources(this.btn_verifyRom, "btn_verifyRom");
            this.btn_verifyRom.Name = "btn_verifyRom";
            this.btn_verifyRom.UseVisualStyleBackColor = true;
            this.btn_verifyRom.Click += new System.EventHandler(this.btn_verifyRom_Click);
            // 
            // btn_writeSave
            // 
            resources.ApplyResources(this.btn_writeSave, "btn_writeSave");
            this.btn_writeSave.Name = "btn_writeSave";
            this.btn_writeSave.UseVisualStyleBackColor = true;
            this.btn_writeSave.Click += new System.EventHandler(this.btn_writeSave_Click);
            // 
            // btn_readSave
            // 
            resources.ApplyResources(this.btn_readSave, "btn_readSave");
            this.btn_readSave.Name = "btn_readSave";
            this.btn_readSave.UseVisualStyleBackColor = true;
            this.btn_readSave.Click += new System.EventHandler(this.btn_readSave_Click);
            // 
            // btn_verifySave
            // 
            resources.ApplyResources(this.btn_verifySave, "btn_verifySave");
            this.btn_verifySave.Name = "btn_verifySave";
            this.btn_verifySave.UseVisualStyleBackColor = true;
            this.btn_verifySave.Click += new System.EventHandler(this.btn_verifySave_Click);
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
            // comboBox_saveSize
            // 
            resources.ApplyResources(this.comboBox_saveSize, "comboBox_saveSize");
            this.comboBox_saveSize.DropDownWidth = 55;
            this.comboBox_saveSize.FormattingEnabled = true;
            this.comboBox_saveSize.Items.AddRange(new object[] {
            resources.GetString("comboBox_saveSize.Items"),
            resources.GetString("comboBox_saveSize.Items1")});
            this.comboBox_saveSize.Name = "comboBox_saveSize";
            // 
            // comboBox_romSize
            // 
            resources.ApplyResources(this.comboBox_romSize, "comboBox_romSize");
            this.comboBox_romSize.FormattingEnabled = true;
            this.comboBox_romSize.Name = "comboBox_romSize";
            // 
            // tmr_showSpeed
            // 
            this.tmr_showSpeed.Enabled = true;
            this.tmr_showSpeed.Interval = 1500;
            this.tmr_showSpeed.Tick += new System.EventHandler(this.tmr_showSpeed_Tick);
            // 
            // btn_renewPort
            // 
            resources.ApplyResources(this.btn_renewPort, "btn_renewPort");
            this.btn_renewPort.Name = "btn_renewPort";
            this.btn_renewPort.UseVisualStyleBackColor = true;
            this.btn_renewPort.Click += new System.EventHandler(this.btn_renewPort_Click);
            // 
            // comboBox_ramType
            // 
            resources.ApplyResources(this.comboBox_ramType, "comboBox_ramType");
            this.comboBox_ramType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ramType.DropDownWidth = 53;
            this.comboBox_ramType.FormattingEnabled = true;
            this.comboBox_ramType.Items.AddRange(new object[] {
            resources.GetString("comboBox_ramType.Items"),
            resources.GetString("comboBox_ramType.Items1"),
            resources.GetString("comboBox_ramType.Items2"),
            resources.GetString("comboBox_ramType.Items3")});
            this.comboBox_ramType.Name = "comboBox_ramType";
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBox_gbaMultiCartSelect);
            this.tabPage1.Controls.Add(this.btn_eraseChip);
            this.tabPage1.Controls.Add(this.comboBox_ramType);
            this.tabPage1.Controls.Add(this.btn_verifyRom);
            this.tabPage1.Controls.Add(this.btn_verifySave);
            this.tabPage1.Controls.Add(this.comboBox_saveSize);
            this.tabPage1.Controls.Add(this.comboBox_romSize);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btn_readRom);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btn_readSave);
            this.tabPage1.Controls.Add(this.btn_writeRom);
            this.tabPage1.Controls.Add(this.btn_writeSave);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBox_gbaMultiCartSelect
            // 
            resources.ApplyResources(this.comboBox_gbaMultiCartSelect, "comboBox_gbaMultiCartSelect");
            this.comboBox_gbaMultiCartSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_gbaMultiCartSelect.DropDownWidth = 100;
            this.comboBox_gbaMultiCartSelect.FormattingEnabled = true;
            this.comboBox_gbaMultiCartSelect.Items.AddRange(new object[] {
            resources.GetString("comboBox_gbaMultiCartSelect.Items"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items1"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items2"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items3"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items4"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items5"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items6"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items7"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items8"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items9"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items10"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items11"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items12"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items13"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items14"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items15"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items16"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items17"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items18"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items19"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items20"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items21"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items22"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items23"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items24"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items25"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items26"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items27"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items28"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items29"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items30"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items31"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items32"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items33"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items34"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items35"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items36"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items37"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items38"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items39"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items40"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items41"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items42"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items43"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items44"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items45"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items46"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items47"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items48"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items49"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items50"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items51"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items52"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items53"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items54"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items55"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items56"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items57"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items58"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items59"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items60"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items61"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items62"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items63"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items64"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items65"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items66"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items67"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items68"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items69"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items70"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items71"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items72"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items73"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items74"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items75"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items76"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items77"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items78"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items79"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items80"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items81"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items82"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items83"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items84"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items85"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items86"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items87"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items88"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items89"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items90"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items91"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items92"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items93"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items94"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items95"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items96"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items97"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items98"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items99"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items100"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items101"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items102"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items103"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items104"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items105"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items106"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items107"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items108"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items109"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items110"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items111"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items112"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items113"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items114"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items115"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items116"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items117"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items118"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items119"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items120"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items121"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items122"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items123"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items124"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items125"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items126"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items127"),
            resources.GetString("comboBox_gbaMultiCartSelect.Items128")});
            this.comboBox_gbaMultiCartSelect.Name = "comboBox_gbaMultiCartSelect";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBox_mbc5V);
            this.tabPage2.Controls.Add(this.comboBox_mbcType);
            this.tabPage2.Controls.Add(this.comboBox_mbc5RamType);
            this.tabPage2.Controls.Add(this.btn_eraseChip_mbc5);
            this.tabPage2.Controls.Add(this.comboBox_mbc5MultiCartSelect);
            this.tabPage2.Controls.Add(this.btn_verifyRom_mbc5);
            this.tabPage2.Controls.Add(this.btn_verifySave_mbc5);
            this.tabPage2.Controls.Add(this.comboBox_saveSize_mbc5);
            this.tabPage2.Controls.Add(this.comboBox_romSize_mbc5);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btn_readRom_mbc5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btn_readSave_mbc5);
            this.tabPage2.Controls.Add(this.btn_writeRom_mbc5);
            this.tabPage2.Controls.Add(this.btn_writeSave_mbc5);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBox_mbc5V
            // 
            resources.ApplyResources(this.checkBox_mbc5V, "checkBox_mbc5V");
            this.checkBox_mbc5V.Name = "checkBox_mbc5V";
            this.checkBox_mbc5V.UseVisualStyleBackColor = true;
            // 
            // comboBox_mbcType
            // 
            resources.ApplyResources(this.comboBox_mbcType, "comboBox_mbcType");
            this.comboBox_mbcType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_mbcType.DropDownWidth = 60;
            this.comboBox_mbcType.FormattingEnabled = true;
            this.comboBox_mbcType.Items.AddRange(new object[] {
            resources.GetString("comboBox_mbcType.Items"),
            resources.GetString("comboBox_mbcType.Items1")});
            this.comboBox_mbcType.Name = "comboBox_mbcType";
            // 
            // comboBox_mbc5RamType
            // 
            resources.ApplyResources(this.comboBox_mbc5RamType, "comboBox_mbc5RamType");
            this.comboBox_mbc5RamType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_mbc5RamType.DropDownWidth = 100;
            this.comboBox_mbc5RamType.FormattingEnabled = true;
            this.comboBox_mbc5RamType.Items.AddRange(new object[] {
            resources.GetString("comboBox_mbc5RamType.Items"),
            resources.GetString("comboBox_mbc5RamType.Items1")});
            this.comboBox_mbc5RamType.Name = "comboBox_mbc5RamType";
            // 
            // btn_eraseChip_mbc5
            // 
            resources.ApplyResources(this.btn_eraseChip_mbc5, "btn_eraseChip_mbc5");
            this.btn_eraseChip_mbc5.Name = "btn_eraseChip_mbc5";
            this.btn_eraseChip_mbc5.UseVisualStyleBackColor = true;
            this.btn_eraseChip_mbc5.Click += new System.EventHandler(this.btn_eraseChip_mbc5_Click);
            // 
            // comboBox_mbc5MultiCartSelect
            // 
            resources.ApplyResources(this.comboBox_mbc5MultiCartSelect, "comboBox_mbc5MultiCartSelect");
            this.comboBox_mbc5MultiCartSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_mbc5MultiCartSelect.DropDownWidth = 100;
            this.comboBox_mbc5MultiCartSelect.FormattingEnabled = true;
            this.comboBox_mbc5MultiCartSelect.Items.AddRange(new object[] {
            resources.GetString("comboBox_mbc5MultiCartSelect.Items"),
            resources.GetString("comboBox_mbc5MultiCartSelect.Items1"),
            resources.GetString("comboBox_mbc5MultiCartSelect.Items2"),
            resources.GetString("comboBox_mbc5MultiCartSelect.Items3"),
            resources.GetString("comboBox_mbc5MultiCartSelect.Items4"),
            resources.GetString("comboBox_mbc5MultiCartSelect.Items5"),
            resources.GetString("comboBox_mbc5MultiCartSelect.Items6"),
            resources.GetString("comboBox_mbc5MultiCartSelect.Items7"),
            resources.GetString("comboBox_mbc5MultiCartSelect.Items8"),
            resources.GetString("comboBox_mbc5MultiCartSelect.Items9"),
            resources.GetString("comboBox_mbc5MultiCartSelect.Items10"),
            resources.GetString("comboBox_mbc5MultiCartSelect.Items11"),
            resources.GetString("comboBox_mbc5MultiCartSelect.Items12"),
            resources.GetString("comboBox_mbc5MultiCartSelect.Items13"),
            resources.GetString("comboBox_mbc5MultiCartSelect.Items14"),
            resources.GetString("comboBox_mbc5MultiCartSelect.Items15"),
            resources.GetString("comboBox_mbc5MultiCartSelect.Items16"),
            resources.GetString("comboBox_mbc5MultiCartSelect.Items17")});
            this.comboBox_mbc5MultiCartSelect.Name = "comboBox_mbc5MultiCartSelect";
            this.comboBox_mbc5MultiCartSelect.SelectedIndexChanged += new System.EventHandler(this.comboBox_mbc5MultiCartSelect_SelectedIndexChanged);
            // 
            // btn_verifyRom_mbc5
            // 
            resources.ApplyResources(this.btn_verifyRom_mbc5, "btn_verifyRom_mbc5");
            this.btn_verifyRom_mbc5.Name = "btn_verifyRom_mbc5";
            this.btn_verifyRom_mbc5.UseVisualStyleBackColor = true;
            this.btn_verifyRom_mbc5.Click += new System.EventHandler(this.btn_verifyRom_mbc5_Click);
            // 
            // btn_verifySave_mbc5
            // 
            resources.ApplyResources(this.btn_verifySave_mbc5, "btn_verifySave_mbc5");
            this.btn_verifySave_mbc5.Name = "btn_verifySave_mbc5";
            this.btn_verifySave_mbc5.UseVisualStyleBackColor = true;
            this.btn_verifySave_mbc5.Click += new System.EventHandler(this.btn_verifySave_mbc5_Click);
            // 
            // comboBox_saveSize_mbc5
            // 
            resources.ApplyResources(this.comboBox_saveSize_mbc5, "comboBox_saveSize_mbc5");
            this.comboBox_saveSize_mbc5.DropDownWidth = 55;
            this.comboBox_saveSize_mbc5.FormattingEnabled = true;
            this.comboBox_saveSize_mbc5.Items.AddRange(new object[] {
            resources.GetString("comboBox_saveSize_mbc5.Items"),
            resources.GetString("comboBox_saveSize_mbc5.Items1"),
            resources.GetString("comboBox_saveSize_mbc5.Items2"),
            resources.GetString("comboBox_saveSize_mbc5.Items3"),
            resources.GetString("comboBox_saveSize_mbc5.Items4")});
            this.comboBox_saveSize_mbc5.Name = "comboBox_saveSize_mbc5";
            // 
            // comboBox_romSize_mbc5
            // 
            resources.ApplyResources(this.comboBox_romSize_mbc5, "comboBox_romSize_mbc5");
            this.comboBox_romSize_mbc5.FormattingEnabled = true;
            this.comboBox_romSize_mbc5.Items.AddRange(new object[] {
            resources.GetString("comboBox_romSize_mbc5.Items"),
            resources.GetString("comboBox_romSize_mbc5.Items1"),
            resources.GetString("comboBox_romSize_mbc5.Items2"),
            resources.GetString("comboBox_romSize_mbc5.Items3")});
            this.comboBox_romSize_mbc5.Name = "comboBox_romSize_mbc5";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btn_readRom_mbc5
            // 
            resources.ApplyResources(this.btn_readRom_mbc5, "btn_readRom_mbc5");
            this.btn_readRom_mbc5.Name = "btn_readRom_mbc5";
            this.btn_readRom_mbc5.UseVisualStyleBackColor = true;
            this.btn_readRom_mbc5.Click += new System.EventHandler(this.btn_readRom_mbc5_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // btn_readSave_mbc5
            // 
            resources.ApplyResources(this.btn_readSave_mbc5, "btn_readSave_mbc5");
            this.btn_readSave_mbc5.Name = "btn_readSave_mbc5";
            this.btn_readSave_mbc5.UseVisualStyleBackColor = true;
            this.btn_readSave_mbc5.Click += new System.EventHandler(this.btn_readSave_mbc5_Click);
            // 
            // btn_writeRom_mbc5
            // 
            resources.ApplyResources(this.btn_writeRom_mbc5, "btn_writeRom_mbc5");
            this.btn_writeRom_mbc5.Name = "btn_writeRom_mbc5";
            this.btn_writeRom_mbc5.UseVisualStyleBackColor = true;
            this.btn_writeRom_mbc5.Click += new System.EventHandler(this.btn_writeRom_mbc5_Click);
            // 
            // btn_writeSave_mbc5
            // 
            resources.ApplyResources(this.btn_writeSave_mbc5, "btn_writeSave_mbc5");
            this.btn_writeSave_mbc5.Name = "btn_writeSave_mbc5";
            this.btn_writeSave_mbc5.UseVisualStyleBackColor = true;
            this.btn_writeSave_mbc5.Click += new System.EventHandler(this.btn_writeSave_mbc5_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_cancel);
            this.tabPage3.Controls.Add(this.btn_rumbleTest_gba);
            this.tabPage3.Controls.Add(this.btn_setRTC_mbc);
            this.tabPage3.Controls.Add(this.btn_setRTC_gba);
            this.tabPage3.Controls.Add(this.btn_unlockPPB_mbc5);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.btn_unlockPPB_gba);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            resources.ApplyResources(this.btn_cancel, "btn_cancel");
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_rumbleTest_gba
            // 
            resources.ApplyResources(this.btn_rumbleTest_gba, "btn_rumbleTest_gba");
            this.btn_rumbleTest_gba.Name = "btn_rumbleTest_gba";
            this.btn_rumbleTest_gba.UseVisualStyleBackColor = true;
            this.btn_rumbleTest_gba.Click += new System.EventHandler(this.btn_rumbleTest_gba_Click);
            // 
            // btn_setRTC_mbc
            // 
            resources.ApplyResources(this.btn_setRTC_mbc, "btn_setRTC_mbc");
            this.btn_setRTC_mbc.Name = "btn_setRTC_mbc";
            this.btn_setRTC_mbc.UseVisualStyleBackColor = true;
            this.btn_setRTC_mbc.Click += new System.EventHandler(this.btn_setRTC_mbc_Click);
            // 
            // btn_setRTC_gba
            // 
            resources.ApplyResources(this.btn_setRTC_gba, "btn_setRTC_gba");
            this.btn_setRTC_gba.Name = "btn_setRTC_gba";
            this.btn_setRTC_gba.UseVisualStyleBackColor = true;
            this.btn_setRTC_gba.Click += new System.EventHandler(this.btn_setRTC_gba_Click);
            // 
            // btn_unlockPPB_mbc5
            // 
            resources.ApplyResources(this.btn_unlockPPB_mbc5, "btn_unlockPPB_mbc5");
            this.btn_unlockPPB_mbc5.Name = "btn_unlockPPB_mbc5";
            this.btn_unlockPPB_mbc5.UseVisualStyleBackColor = true;
            this.btn_unlockPPB_mbc5.Click += new System.EventHandler(this.btn_unlockPPB_mbc5_Click);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // btn_unlockPPB_gba
            // 
            resources.ApplyResources(this.btn_unlockPPB_gba, "btn_unlockPPB_gba");
            this.btn_unlockPPB_gba.Name = "btn_unlockPPB_gba";
            this.btn_unlockPPB_gba.UseVisualStyleBackColor = true;
            this.btn_unlockPPB_gba.Click += new System.EventHandler(this.btn_unlockPPB_gba_Click);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_renewPort);
            this.Controls.Add(this.btn_browseSave);
            this.Controls.Add(this.textBox_savePath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.progressBar_total);
            this.Controls.Add(this.textBox_log);
            this.Controls.Add(this.btn_readID);
            this.Controls.Add(this.comboBox_com);
            this.Controls.Add(this.textBox_romPath);
            this.Controls.Add(this.btn_browseRom);
            this.Name = "Form1";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_browseRom;
        private System.Windows.Forms.TextBox textBox_romPath;
        private System.Windows.Forms.ComboBox comboBox_com;
        private System.Windows.Forms.Button btn_readID;
        private System.Windows.Forms.TextBox textBox_log;
        private System.Windows.Forms.ProgressBar progressBar_total;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_savePath;
        private System.Windows.Forms.Button btn_browseSave;
        private System.Windows.Forms.Button btn_eraseChip;
        private System.Windows.Forms.Button btn_writeRom;
        private System.Windows.Forms.Button btn_readRom;
        private System.Windows.Forms.Button btn_verifyRom;
        private System.Windows.Forms.Button btn_writeSave;
        private System.Windows.Forms.Button btn_readSave;
        private System.Windows.Forms.Button btn_verifySave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_saveSize;
        private System.Windows.Forms.ComboBox comboBox_romSize;
        private System.Windows.Forms.ToolStripStatusLabel label_speed;
        private System.Windows.Forms.Timer tmr_showSpeed;
        private System.Windows.Forms.ToolStripStatusLabel label_progress;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Button btn_renewPort;
        private System.Windows.Forms.ComboBox comboBox_ramType;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_eraseChip_mbc5;
        private System.Windows.Forms.ComboBox comboBox_mbc5MultiCartSelect;
        private System.Windows.Forms.Button btn_verifyRom_mbc5;
        private System.Windows.Forms.Button btn_verifySave_mbc5;
        private System.Windows.Forms.ComboBox comboBox_saveSize_mbc5;
        private System.Windows.Forms.ComboBox comboBox_romSize_mbc5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_readRom_mbc5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_readSave_mbc5;
        private System.Windows.Forms.Button btn_writeRom_mbc5;
        private System.Windows.Forms.Button btn_writeSave_mbc5;
        private System.Windows.Forms.ComboBox comboBox_gbaMultiCartSelect;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_unlockPPB_gba;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_rumbleTest_gba;
        private System.Windows.Forms.Button btn_setRTC_mbc;
        private System.Windows.Forms.Button btn_setRTC_gba;
        private System.Windows.Forms.Button btn_unlockPPB_mbc5;
        private System.Windows.Forms.ComboBox comboBox_mbc5RamType;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.ComboBox comboBox_mbcType;
        private System.Windows.Forms.CheckBox checkBox_mbc5V;
        private System.Windows.Forms.Label label9;
    }
}

