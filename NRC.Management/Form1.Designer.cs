namespace NRC.Management
{
    partial class frmMain
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
            this.btnContact = new System.Windows.Forms.Button();
            this.dgvDeviceInfo = new System.Windows.Forms.DataGridView();
            this.Parameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbIP = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.btnGetDeviceInfo = new System.Windows.Forms.Button();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.tcFeatures = new System.Windows.Forms.TabControl();
            this.tpMain = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGetAdcInputStatus = new System.Windows.Forms.Button();
            this.lbAdcInputsStatus = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnGetSwInputStatus = new System.Windows.Forms.Button();
            this.lbSwInputsStatus = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnRelayGetValues = new System.Windows.Forms.Button();
            this.lbRelayStatus = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGetHvInputStatus = new System.Windows.Forms.Button();
            this.lbHvInputsStatus = new System.Windows.Forms.ListBox();
            this.btnOn = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.Button();
            this.nudOffRelayCode = new System.Windows.Forms.NumericUpDown();
            this.nudOnRelayCode = new System.Windows.Forms.NumericUpDown();
            this.nudContactRelayCode = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeviceInfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.tcFeatures.SuspendLayout();
            this.tpMain.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffRelayCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOnRelayCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudContactRelayCode)).BeginInit();
            this.SuspendLayout();
            // 
            // btnContact
            // 
            this.btnContact.Location = new System.Drawing.Point(77, 11);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(69, 22);
            this.btnContact.TabIndex = 0;
            this.btnContact.Text = "Contact";
            this.btnContact.UseVisualStyleBackColor = true;
            this.btnContact.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvDeviceInfo
            // 
            this.dgvDeviceInfo.AllowUserToAddRows = false;
            this.dgvDeviceInfo.AllowUserToDeleteRows = false;
            this.dgvDeviceInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeviceInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Parameter,
            this.Value});
            this.dgvDeviceInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeviceInfo.Location = new System.Drawing.Point(3, 16);
            this.dgvDeviceInfo.Name = "dgvDeviceInfo";
            this.dgvDeviceInfo.ReadOnly = true;
            this.dgvDeviceInfo.RowHeadersVisible = false;
            this.dgvDeviceInfo.RowTemplate.Height = 18;
            this.dgvDeviceInfo.RowTemplate.ReadOnly = true;
            this.dgvDeviceInfo.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDeviceInfo.Size = new System.Drawing.Size(260, 361);
            this.dgvDeviceInfo.TabIndex = 2;
            // 
            // Parameter
            // 
            this.Parameter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Parameter.HeaderText = "Parameter";
            this.Parameter.Name = "Parameter";
            this.Parameter.ReadOnly = true;
            this.Parameter.Width = 80;
            // 
            // Value
            // 
            this.Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.dgvDeviceInfo);
            this.groupBox1.Location = new System.Drawing.Point(12, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 380);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Device Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Device IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Port:";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(211, 19);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(43, 20);
            this.tbPort.TabIndex = 6;
            this.tbPort.Text = "23";
            this.tbPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbIP);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbPassword);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbUsername);
            this.groupBox2.Controls.Add(this.btnGetDeviceInfo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbPort);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 109);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connection";
            // 
            // cbIP
            // 
            this.cbIP.AutoCompleteCustomSource.AddRange(new string[] {
            "192.168.1.200",
            "192.168.1.201",
            "192.168.1.193",
            "192.168.1.195"});
            this.cbIP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.cbIP.FormattingEnabled = true;
            this.cbIP.Items.AddRange(new object[] {
            "192.168.1.200",
            "192.168.1.201",
            "192.168.1.193",
            "192.168.1.195"});
            this.cbIP.Location = new System.Drawing.Point(72, 18);
            this.cbIP.Name = "cbIP";
            this.cbIP.Size = new System.Drawing.Size(135, 21);
            this.cbIP.TabIndex = 11;
            this.cbIP.Text = "192.168.1.200";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Password:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(194, 45);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(60, 20);
            this.tbPassword.TabIndex = 12;
            this.tbPassword.Text = "admin";
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Username:";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(72, 45);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(54, 20);
            this.tbUsername.TabIndex = 10;
            this.tbUsername.Text = "admin";
            this.tbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGetDeviceInfo
            // 
            this.btnGetDeviceInfo.Location = new System.Drawing.Point(12, 71);
            this.btnGetDeviceInfo.Name = "btnGetDeviceInfo";
            this.btnGetDeviceInfo.Size = new System.Drawing.Size(242, 27);
            this.btnGetDeviceInfo.TabIndex = 9;
            this.btnGetDeviceInfo.Text = "Set Connection and Get Device Info";
            this.btnGetDeviceInfo.UseVisualStyleBackColor = true;
            this.btnGetDeviceInfo.Click += new System.EventHandler(this.btnGetDeviceInfo_Click);
            // 
            // pnlControls
            // 
            this.pnlControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlControls.Controls.Add(this.tcFeatures);
            this.pnlControls.Location = new System.Drawing.Point(284, 12);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(584, 495);
            this.pnlControls.TabIndex = 9;
            this.pnlControls.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlControls_Paint);
            // 
            // tcFeatures
            // 
            this.tcFeatures.Controls.Add(this.tpMain);
            this.tcFeatures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcFeatures.Location = new System.Drawing.Point(0, 0);
            this.tcFeatures.Name = "tcFeatures";
            this.tcFeatures.SelectedIndex = 0;
            this.tcFeatures.Size = new System.Drawing.Size(584, 495);
            this.tcFeatures.TabIndex = 0;
            // 
            // tpMain
            // 
            this.tpMain.Controls.Add(this.groupBox4);
            this.tpMain.Controls.Add(this.groupBox5);
            this.tpMain.Controls.Add(this.groupBox6);
            this.tpMain.Controls.Add(this.groupBox3);
            this.tpMain.Controls.Add(this.btnContact);
            this.tpMain.Controls.Add(this.btnOn);
            this.tpMain.Controls.Add(this.btnOff);
            this.tpMain.Controls.Add(this.nudOffRelayCode);
            this.tpMain.Controls.Add(this.nudOnRelayCode);
            this.tpMain.Controls.Add(this.nudContactRelayCode);
            this.tpMain.Location = new System.Drawing.Point(4, 22);
            this.tpMain.Name = "tpMain";
            this.tpMain.Padding = new System.Windows.Forms.Padding(3);
            this.tpMain.Size = new System.Drawing.Size(576, 469);
            this.tpMain.TabIndex = 0;
            this.tpMain.Text = "Main";
            this.tpMain.UseVisualStyleBackColor = true;
            this.tpMain.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnGetAdcInputStatus);
            this.groupBox4.Controls.Add(this.lbAdcInputsStatus);
            this.groupBox4.Location = new System.Drawing.Point(175, 242);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(160, 140);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            // 
            // btnGetAdcInputStatus
            // 
            this.btnGetAdcInputStatus.Location = new System.Drawing.Point(7, 11);
            this.btnGetAdcInputStatus.Name = "btnGetAdcInputStatus";
            this.btnGetAdcInputStatus.Size = new System.Drawing.Size(145, 22);
            this.btnGetAdcInputStatus.TabIndex = 12;
            this.btnGetAdcInputStatus.Text = "Get ADC Input Status";
            this.btnGetAdcInputStatus.UseVisualStyleBackColor = true;
            this.btnGetAdcInputStatus.Click += new System.EventHandler(this.btnGetAdcInputStatus_Click);
            // 
            // lbAdcInputsStatus
            // 
            this.lbAdcInputsStatus.FormattingEnabled = true;
            this.lbAdcInputsStatus.Location = new System.Drawing.Point(8, 37);
            this.lbAdcInputsStatus.Name = "lbAdcInputsStatus";
            this.lbAdcInputsStatus.Size = new System.Drawing.Size(144, 95);
            this.lbAdcInputsStatus.TabIndex = 13;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnGetSwInputStatus);
            this.groupBox5.Controls.Add(this.lbSwInputsStatus);
            this.groupBox5.Location = new System.Drawing.Point(175, 102);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(160, 140);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            // 
            // btnGetSwInputStatus
            // 
            this.btnGetSwInputStatus.Location = new System.Drawing.Point(7, 11);
            this.btnGetSwInputStatus.Name = "btnGetSwInputStatus";
            this.btnGetSwInputStatus.Size = new System.Drawing.Size(145, 22);
            this.btnGetSwInputStatus.TabIndex = 8;
            this.btnGetSwInputStatus.Text = "Get SW Input Status";
            this.btnGetSwInputStatus.UseVisualStyleBackColor = true;
            this.btnGetSwInputStatus.Click += new System.EventHandler(this.btnGetSwInputStatus_Click);
            // 
            // lbSwInputsStatus
            // 
            this.lbSwInputsStatus.FormattingEnabled = true;
            this.lbSwInputsStatus.Location = new System.Drawing.Point(8, 37);
            this.lbSwInputsStatus.Name = "lbSwInputsStatus";
            this.lbSwInputsStatus.Size = new System.Drawing.Size(144, 95);
            this.lbSwInputsStatus.TabIndex = 9;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnRelayGetValues);
            this.groupBox6.Controls.Add(this.lbRelayStatus);
            this.groupBox6.Location = new System.Drawing.Point(9, 102);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(160, 140);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            // 
            // btnRelayGetValues
            // 
            this.btnRelayGetValues.Location = new System.Drawing.Point(7, 11);
            this.btnRelayGetValues.Name = "btnRelayGetValues";
            this.btnRelayGetValues.Size = new System.Drawing.Size(145, 22);
            this.btnRelayGetValues.TabIndex = 6;
            this.btnRelayGetValues.Text = "Get Relays Status";
            this.btnRelayGetValues.UseVisualStyleBackColor = true;
            this.btnRelayGetValues.Click += new System.EventHandler(this.btnRelayGetValues_Click);
            // 
            // lbRelayStatus
            // 
            this.lbRelayStatus.FormattingEnabled = true;
            this.lbRelayStatus.Location = new System.Drawing.Point(8, 37);
            this.lbRelayStatus.Name = "lbRelayStatus";
            this.lbRelayStatus.Size = new System.Drawing.Size(144, 95);
            this.lbRelayStatus.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGetHvInputStatus);
            this.groupBox3.Controls.Add(this.lbHvInputsStatus);
            this.groupBox3.Location = new System.Drawing.Point(9, 242);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(160, 140);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // btnGetHvInputStatus
            // 
            this.btnGetHvInputStatus.Location = new System.Drawing.Point(8, 11);
            this.btnGetHvInputStatus.Name = "btnGetHvInputStatus";
            this.btnGetHvInputStatus.Size = new System.Drawing.Size(145, 22);
            this.btnGetHvInputStatus.TabIndex = 10;
            this.btnGetHvInputStatus.Text = "Get Hv Input Status";
            this.btnGetHvInputStatus.UseVisualStyleBackColor = true;
            this.btnGetHvInputStatus.Click += new System.EventHandler(this.btnGetHvInputStatus_Click);
            // 
            // lbHvInputsStatus
            // 
            this.lbHvInputsStatus.FormattingEnabled = true;
            this.lbHvInputsStatus.Location = new System.Drawing.Point(9, 37);
            this.lbHvInputsStatus.Name = "lbHvInputsStatus";
            this.lbHvInputsStatus.Size = new System.Drawing.Size(144, 95);
            this.lbHvInputsStatus.TabIndex = 11;
            // 
            // btnOn
            // 
            this.btnOn.Location = new System.Drawing.Point(77, 37);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(69, 22);
            this.btnOn.TabIndex = 4;
            this.btnOn.Text = "On";
            this.btnOn.UseVisualStyleBackColor = true;
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // btnOff
            // 
            this.btnOff.Location = new System.Drawing.Point(77, 63);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(69, 22);
            this.btnOff.TabIndex = 5;
            this.btnOff.Text = "Off";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // nudOffRelayCode
            // 
            this.nudOffRelayCode.Location = new System.Drawing.Point(9, 64);
            this.nudOffRelayCode.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudOffRelayCode.Name = "nudOffRelayCode";
            this.nudOffRelayCode.Size = new System.Drawing.Size(62, 20);
            this.nudOffRelayCode.TabIndex = 3;
            this.nudOffRelayCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudOffRelayCode.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudOnRelayCode
            // 
            this.nudOnRelayCode.Location = new System.Drawing.Point(9, 38);
            this.nudOnRelayCode.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudOnRelayCode.Name = "nudOnRelayCode";
            this.nudOnRelayCode.Size = new System.Drawing.Size(62, 20);
            this.nudOnRelayCode.TabIndex = 2;
            this.nudOnRelayCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudOnRelayCode.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudContactRelayCode
            // 
            this.nudContactRelayCode.Location = new System.Drawing.Point(9, 12);
            this.nudContactRelayCode.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudContactRelayCode.Name = "nudContactRelayCode";
            this.nudContactRelayCode.Size = new System.Drawing.Size(62, 20);
            this.nudContactRelayCode.TabIndex = 1;
            this.nudContactRelayCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudContactRelayCode.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 519);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NRC Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeviceInfo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlControls.ResumeLayout(false);
            this.tcFeatures.ResumeLayout(false);
            this.tpMain.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudOffRelayCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOnRelayCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudContactRelayCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.DataGridView dgvDeviceInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGetDeviceInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Button btnOn;
        private System.Windows.Forms.NumericUpDown nudOffRelayCode;
        private System.Windows.Forms.NumericUpDown nudOnRelayCode;
        private System.Windows.Forms.NumericUpDown nudContactRelayCode;
        private System.Windows.Forms.ComboBox cbIP;
        private System.Windows.Forms.Button btnRelayGetValues;
        private System.Windows.Forms.ListBox lbRelayStatus;
        private System.Windows.Forms.ListBox lbAdcInputsStatus;
        private System.Windows.Forms.Button btnGetAdcInputStatus;
        private System.Windows.Forms.ListBox lbHvInputsStatus;
        private System.Windows.Forms.Button btnGetHvInputStatus;
        private System.Windows.Forms.ListBox lbSwInputsStatus;
        private System.Windows.Forms.Button btnGetSwInputStatus;
        private System.Windows.Forms.TabControl tcFeatures;
        private System.Windows.Forms.TabPage tpMain;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

