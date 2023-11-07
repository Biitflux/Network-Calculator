namespace NetzwerkRechner
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_ip1 = new System.Windows.Forms.TextBox();
            this.lbl_yourip = new System.Windows.Forms.Label();
            this.chk_mask = new System.Windows.Forms.CheckBox();
            this.txt_mask = new System.Windows.Forms.TextBox();
            this.lbl_mask = new System.Windows.Forms.Label();
            this.lbl_what = new System.Windows.Forms.Label();
            this.chk_netzid = new System.Windows.Forms.CheckBox();
            this.chk_hostmin = new System.Windows.Forms.CheckBox();
            this.chk_bc = new System.Windows.Forms.CheckBox();
            this.chk_noip = new System.Windows.Forms.CheckBox();
            this.chk_hostmax = new System.Windows.Forms.CheckBox();
            this.btn_calc = new System.Windows.Forms.Button();
            this.lbl_noip = new System.Windows.Forms.Label();
            this.lbl_hostmin = new System.Windows.Forms.Label();
            this.lbl_netzid = new System.Windows.Forms.Label();
            this.lbl_hostmax = new System.Windows.Forms.Label();
            this.lbl_bc = new System.Windows.Forms.Label();
            this.txt_noip = new System.Windows.Forms.TextBox();
            this.txt_netzid = new System.Windows.Forms.TextBox();
            this.txt_bc = new System.Windows.Forms.TextBox();
            this.txt_hostmin = new System.Windows.Forms.TextBox();
            this.txt_hostmax = new System.Windows.Forms.TextBox();
            this.txt_ip4 = new System.Windows.Forms.TextBox();
            this.txt_ip2 = new System.Windows.Forms.TextBox();
            this.txt_ip3 = new System.Windows.Forms.TextBox();
            this.lbl_point = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cobo_mask = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripMenuItem2,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showHelpToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // showHelpToolStripMenuItem
            // 
            this.showHelpToolStripMenuItem.Name = "showHelpToolStripMenuItem";
            this.showHelpToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.showHelpToolStripMenuItem.Text = "Show Help";
            this.showHelpToolStripMenuItem.Click += new System.EventHandler(this.showHelpToolStripMenuItem_Click);
            // 
            // txt_ip1
            // 
            this.txt_ip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(172)))), ((int)(((byte)(120)))));
            this.txt_ip1.Location = new System.Drawing.Point(100, 90);
            this.txt_ip1.MaxLength = 3;
            this.txt_ip1.Name = "txt_ip1";
            this.txt_ip1.Size = new System.Drawing.Size(36, 20);
            this.txt_ip1.TabIndex = 1;
            this.txt_ip1.TextChanged += new System.EventHandler(this.txt_ip_TextChanged);
            // 
            // lbl_yourip
            // 
            this.lbl_yourip.AutoSize = true;
            this.lbl_yourip.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_yourip.Location = new System.Drawing.Point(144, 51);
            this.lbl_yourip.Name = "lbl_yourip";
            this.lbl_yourip.Size = new System.Drawing.Size(197, 27);
            this.lbl_yourip.TabIndex = 2;
            this.lbl_yourip.Text = "Enter your IP-Adress";
            // 
            // chk_mask
            // 
            this.chk_mask.AutoSize = true;
            this.chk_mask.Checked = true;
            this.chk_mask.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_mask.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10F);
            this.chk_mask.Location = new System.Drawing.Point(100, 172);
            this.chk_mask.Name = "chk_mask";
            this.chk_mask.Size = new System.Drawing.Size(102, 23);
            this.chk_mask.TabIndex = 99;
            this.chk_mask.Text = "Subnetmask";
            this.chk_mask.UseVisualStyleBackColor = true;
            this.chk_mask.CheckedChanged += new System.EventHandler(this.chk_mask_CheckedChanged);
            // 
            // txt_mask
            // 
            this.txt_mask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(172)))), ((int)(((byte)(120)))));
            this.txt_mask.Location = new System.Drawing.Point(600, 80);
            this.txt_mask.Name = "txt_mask";
            this.txt_mask.ReadOnly = true;
            this.txt_mask.Size = new System.Drawing.Size(164, 20);
            this.txt_mask.TabIndex = 4;
            // 
            // lbl_mask
            // 
            this.lbl_mask.AutoSize = true;
            this.lbl_mask.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F);
            this.lbl_mask.ForeColor = System.Drawing.Color.Black;
            this.lbl_mask.Location = new System.Drawing.Point(482, 80);
            this.lbl_mask.Name = "lbl_mask";
            this.lbl_mask.Size = new System.Drawing.Size(96, 22);
            this.lbl_mask.TabIndex = 5;
            this.lbl_mask.Text = "Subnetmask";
            // 
            // lbl_what
            // 
            this.lbl_what.AutoSize = true;
            this.lbl_what.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_what.Location = new System.Drawing.Point(95, 129);
            this.lbl_what.Name = "lbl_what";
            this.lbl_what.Size = new System.Drawing.Size(292, 27);
            this.lbl_what.TabIndex = 6;
            this.lbl_what.Text = "What do you want to calculate?";
            this.lbl_what.Click += new System.EventHandler(this.lbl_what_Click);
            // 
            // chk_netzid
            // 
            this.chk_netzid.AutoSize = true;
            this.chk_netzid.Checked = true;
            this.chk_netzid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_netzid.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10F);
            this.chk_netzid.Location = new System.Drawing.Point(100, 263);
            this.chk_netzid.Name = "chk_netzid";
            this.chk_netzid.Size = new System.Drawing.Size(67, 23);
            this.chk_netzid.TabIndex = 7;
            this.chk_netzid.Text = "NetzID";
            this.chk_netzid.UseVisualStyleBackColor = true;
            this.chk_netzid.CheckedChanged += new System.EventHandler(this.chk_netzid_CheckedChanged);
            // 
            // chk_hostmin
            // 
            this.chk_hostmin.AutoSize = true;
            this.chk_hostmin.Checked = true;
            this.chk_hostmin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_hostmin.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10F);
            this.chk_hostmin.Location = new System.Drawing.Point(100, 216);
            this.chk_hostmin.Name = "chk_hostmin";
            this.chk_hostmin.Size = new System.Drawing.Size(77, 23);
            this.chk_hostmin.TabIndex = 8;
            this.chk_hostmin.Text = "HostMin";
            this.chk_hostmin.UseVisualStyleBackColor = true;
            this.chk_hostmin.CheckedChanged += new System.EventHandler(this.chk_substeps_CheckedChanged);
            // 
            // chk_bc
            // 
            this.chk_bc.AutoSize = true;
            this.chk_bc.Checked = true;
            this.chk_bc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_bc.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10F);
            this.chk_bc.Location = new System.Drawing.Point(234, 263);
            this.chk_bc.Name = "chk_bc";
            this.chk_bc.Size = new System.Drawing.Size(88, 23);
            this.chk_bc.TabIndex = 9;
            this.chk_bc.Text = "Broadcast";
            this.chk_bc.UseVisualStyleBackColor = true;
            this.chk_bc.CheckedChanged += new System.EventHandler(this.chk_bc_CheckedChanged);
            // 
            // chk_noip
            // 
            this.chk_noip.AutoSize = true;
            this.chk_noip.Checked = true;
            this.chk_noip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_noip.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10F);
            this.chk_noip.Location = new System.Drawing.Point(242, 172);
            this.chk_noip.Name = "chk_noip";
            this.chk_noip.Size = new System.Drawing.Size(121, 23);
            this.chk_noip.TabIndex = 10;
            this.chk_noip.Text = "Number of IP\'s";
            this.chk_noip.UseVisualStyleBackColor = true;
            this.chk_noip.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // chk_hostmax
            // 
            this.chk_hostmax.AutoSize = true;
            this.chk_hostmax.Checked = true;
            this.chk_hostmax.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_hostmax.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10F);
            this.chk_hostmax.Location = new System.Drawing.Point(242, 216);
            this.chk_hostmax.Name = "chk_hostmax";
            this.chk_hostmax.Size = new System.Drawing.Size(80, 23);
            this.chk_hostmax.TabIndex = 11;
            this.chk_hostmax.Text = "HostMax";
            this.chk_hostmax.UseVisualStyleBackColor = true;
            this.chk_hostmax.CheckedChanged += new System.EventHandler(this.chk_asub_CheckedChanged);
            // 
            // btn_calc
            // 
            this.btn_calc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(130)))), ((int)(((byte)(100)))));
            this.btn_calc.FlatAppearance.BorderSize = 0;
            this.btn_calc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calc.ForeColor = System.Drawing.Color.Transparent;
            this.btn_calc.Location = new System.Drawing.Point(160, 310);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(109, 32);
            this.btn_calc.TabIndex = 12;
            this.btn_calc.Text = "Calculate";
            this.btn_calc.UseVisualStyleBackColor = false;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // lbl_noip
            // 
            this.lbl_noip.AutoSize = true;
            this.lbl_noip.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F);
            this.lbl_noip.ForeColor = System.Drawing.Color.Black;
            this.lbl_noip.Location = new System.Drawing.Point(464, 120);
            this.lbl_noip.Name = "lbl_noip";
            this.lbl_noip.Size = new System.Drawing.Size(114, 22);
            this.lbl_noip.TabIndex = 13;
            this.lbl_noip.Text = "Number of IP\'s";
            // 
            // lbl_hostmin
            // 
            this.lbl_hostmin.AutoSize = true;
            this.lbl_hostmin.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F);
            this.lbl_hostmin.ForeColor = System.Drawing.Color.Black;
            this.lbl_hostmin.Location = new System.Drawing.Point(510, 240);
            this.lbl_hostmin.Name = "lbl_hostmin";
            this.lbl_hostmin.Size = new System.Drawing.Size(68, 22);
            this.lbl_hostmin.TabIndex = 14;
            this.lbl_hostmin.Text = "HostMin";
            // 
            // lbl_netzid
            // 
            this.lbl_netzid.AutoSize = true;
            this.lbl_netzid.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F);
            this.lbl_netzid.ForeColor = System.Drawing.Color.Black;
            this.lbl_netzid.Location = new System.Drawing.Point(512, 160);
            this.lbl_netzid.Name = "lbl_netzid";
            this.lbl_netzid.Size = new System.Drawing.Size(66, 22);
            this.lbl_netzid.TabIndex = 15;
            this.lbl_netzid.Text = "NetzID\'s";
            // 
            // lbl_hostmax
            // 
            this.lbl_hostmax.AutoSize = true;
            this.lbl_hostmax.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F);
            this.lbl_hostmax.ForeColor = System.Drawing.Color.Black;
            this.lbl_hostmax.Location = new System.Drawing.Point(507, 280);
            this.lbl_hostmax.Name = "lbl_hostmax";
            this.lbl_hostmax.Size = new System.Drawing.Size(71, 22);
            this.lbl_hostmax.TabIndex = 16;
            this.lbl_hostmax.Text = "HostMax";
            // 
            // lbl_bc
            // 
            this.lbl_bc.AutoSize = true;
            this.lbl_bc.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F);
            this.lbl_bc.ForeColor = System.Drawing.Color.Black;
            this.lbl_bc.Location = new System.Drawing.Point(488, 200);
            this.lbl_bc.Name = "lbl_bc";
            this.lbl_bc.Size = new System.Drawing.Size(90, 22);
            this.lbl_bc.TabIndex = 17;
            this.lbl_bc.Text = "Broadcast\'s";
            // 
            // txt_noip
            // 
            this.txt_noip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(172)))), ((int)(((byte)(120)))));
            this.txt_noip.Location = new System.Drawing.Point(600, 120);
            this.txt_noip.Name = "txt_noip";
            this.txt_noip.ReadOnly = true;
            this.txt_noip.Size = new System.Drawing.Size(164, 20);
            this.txt_noip.TabIndex = 18;
            // 
            // txt_netzid
            // 
            this.txt_netzid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(172)))), ((int)(((byte)(120)))));
            this.txt_netzid.Location = new System.Drawing.Point(600, 160);
            this.txt_netzid.Name = "txt_netzid";
            this.txt_netzid.ReadOnly = true;
            this.txt_netzid.Size = new System.Drawing.Size(164, 20);
            this.txt_netzid.TabIndex = 19;
            // 
            // txt_bc
            // 
            this.txt_bc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(172)))), ((int)(((byte)(120)))));
            this.txt_bc.Location = new System.Drawing.Point(600, 200);
            this.txt_bc.Name = "txt_bc";
            this.txt_bc.ReadOnly = true;
            this.txt_bc.Size = new System.Drawing.Size(164, 20);
            this.txt_bc.TabIndex = 20;
            // 
            // txt_hostmin
            // 
            this.txt_hostmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(172)))), ((int)(((byte)(120)))));
            this.txt_hostmin.Location = new System.Drawing.Point(600, 240);
            this.txt_hostmin.Name = "txt_hostmin";
            this.txt_hostmin.ReadOnly = true;
            this.txt_hostmin.Size = new System.Drawing.Size(164, 20);
            this.txt_hostmin.TabIndex = 21;
            // 
            // txt_hostmax
            // 
            this.txt_hostmax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(172)))), ((int)(((byte)(120)))));
            this.txt_hostmax.Location = new System.Drawing.Point(600, 280);
            this.txt_hostmax.Multiline = true;
            this.txt_hostmax.Name = "txt_hostmax";
            this.txt_hostmax.ReadOnly = true;
            this.txt_hostmax.Size = new System.Drawing.Size(164, 20);
            this.txt_hostmax.TabIndex = 22;
            // 
            // txt_ip4
            // 
            this.txt_ip4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(172)))), ((int)(((byte)(120)))));
            this.txt_ip4.Location = new System.Drawing.Point(280, 90);
            this.txt_ip4.MaxLength = 3;
            this.txt_ip4.Name = "txt_ip4";
            this.txt_ip4.Size = new System.Drawing.Size(36, 20);
            this.txt_ip4.TabIndex = 4;
            this.txt_ip4.TextChanged += new System.EventHandler(this.txt_ip4_TextChanged);
            // 
            // txt_ip2
            // 
            this.txt_ip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(172)))), ((int)(((byte)(120)))));
            this.txt_ip2.Location = new System.Drawing.Point(160, 90);
            this.txt_ip2.MaxLength = 3;
            this.txt_ip2.Name = "txt_ip2";
            this.txt_ip2.Size = new System.Drawing.Size(36, 20);
            this.txt_ip2.TabIndex = 2;
            this.txt_ip2.TextChanged += new System.EventHandler(this.txt_ip2_TextChanged);
            // 
            // txt_ip3
            // 
            this.txt_ip3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(172)))), ((int)(((byte)(120)))));
            this.txt_ip3.Location = new System.Drawing.Point(220, 90);
            this.txt_ip3.MaxLength = 3;
            this.txt_ip3.Name = "txt_ip3";
            this.txt_ip3.Size = new System.Drawing.Size(36, 20);
            this.txt_ip3.TabIndex = 3;
            this.txt_ip3.TextChanged += new System.EventHandler(this.txt_ip3_TextChanged);
            // 
            // lbl_point
            // 
            this.lbl_point.AutoSize = true;
            this.lbl_point.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 15F);
            this.lbl_point.Location = new System.Drawing.Point(140, 90);
            this.lbl_point.Name = "lbl_point";
            this.lbl_point.Size = new System.Drawing.Size(18, 27);
            this.lbl_point.TabIndex = 28;
            this.lbl_point.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 15F);
            this.label1.Location = new System.Drawing.Point(200, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 27);
            this.label1.TabIndex = 29;
            this.label1.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 15F);
            this.label2.Location = new System.Drawing.Point(260, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 27);
            this.label2.TabIndex = 30;
            this.label2.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 15F);
            this.label3.Location = new System.Drawing.Point(320, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 27);
            this.label3.TabIndex = 31;
            this.label3.Text = "/";
            // 
            // cobo_mask
            // 
            this.cobo_mask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(172)))), ((int)(((byte)(120)))));
            this.cobo_mask.FormattingEnabled = true;
            this.cobo_mask.Items.AddRange(new object[] {
            "/1",
            "/2",
            "/3",
            "/4",
            "/5",
            "/6",
            "/7",
            "/8",
            "/9",
            "/10",
            "/11",
            "/12",
            "/13",
            "/14",
            "/15",
            "/16",
            "/17",
            "/18",
            "/19",
            "/20",
            "/21",
            "/22",
            "/23",
            "/24",
            "/25",
            "/26",
            "/27",
            "/28",
            "/29",
            "/30",
            "/31",
            "/32"});
            this.cobo_mask.Location = new System.Drawing.Point(340, 90);
            this.cobo_mask.Name = "cobo_mask";
            this.cobo_mask.Size = new System.Drawing.Size(64, 21);
            this.cobo_mask.TabIndex = 5;
            this.cobo_mask.SelectedIndexChanged += new System.EventHandler(this.cobo_mask_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(231)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cobo_mask);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_point);
            this.Controls.Add(this.txt_ip3);
            this.Controls.Add(this.txt_ip2);
            this.Controls.Add(this.txt_ip4);
            this.Controls.Add(this.txt_hostmax);
            this.Controls.Add(this.txt_hostmin);
            this.Controls.Add(this.txt_bc);
            this.Controls.Add(this.txt_netzid);
            this.Controls.Add(this.txt_noip);
            this.Controls.Add(this.lbl_bc);
            this.Controls.Add(this.lbl_hostmax);
            this.Controls.Add(this.lbl_netzid);
            this.Controls.Add(this.lbl_hostmin);
            this.Controls.Add(this.lbl_noip);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.chk_hostmax);
            this.Controls.Add(this.chk_noip);
            this.Controls.Add(this.chk_bc);
            this.Controls.Add(this.chk_hostmin);
            this.Controls.Add(this.chk_netzid);
            this.Controls.Add(this.lbl_what);
            this.Controls.Add(this.lbl_mask);
            this.Controls.Add(this.txt_mask);
            this.Controls.Add(this.chk_mask);
            this.Controls.Add(this.lbl_yourip);
            this.Controls.Add(this.txt_ip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Network Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showHelpToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_ip1;
        private System.Windows.Forms.Label lbl_yourip;
        private System.Windows.Forms.CheckBox chk_mask;
        private System.Windows.Forms.TextBox txt_mask;
        private System.Windows.Forms.Label lbl_mask;
        private System.Windows.Forms.Label lbl_what;
        private System.Windows.Forms.CheckBox chk_netzid;
        private System.Windows.Forms.CheckBox chk_hostmin;
        private System.Windows.Forms.CheckBox chk_bc;
        private System.Windows.Forms.CheckBox chk_noip;
        private System.Windows.Forms.CheckBox chk_hostmax;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Label lbl_noip;
        private System.Windows.Forms.Label lbl_hostmin;
        private System.Windows.Forms.Label lbl_netzid;
        private System.Windows.Forms.Label lbl_hostmax;
        private System.Windows.Forms.Label lbl_bc;
        private System.Windows.Forms.TextBox txt_noip;
        private System.Windows.Forms.TextBox txt_netzid;
        private System.Windows.Forms.TextBox txt_bc;
        private System.Windows.Forms.TextBox txt_hostmin;
        private System.Windows.Forms.TextBox txt_hostmax;
        private System.Windows.Forms.TextBox txt_ip4;
        private System.Windows.Forms.TextBox txt_ip2;
        private System.Windows.Forms.TextBox txt_ip3;
        private System.Windows.Forms.Label lbl_point;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cobo_mask;
    }
}

