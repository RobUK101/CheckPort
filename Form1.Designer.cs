namespace CheckPort
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
            this.b_checkPort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Destination = new System.Windows.Forms.TextBox();
            this.tb_Port = new System.Windows.Forms.TextBox();
            this.pb_Progress = new System.Windows.Forms.ProgressBar();
            this.rb_singlePort = new System.Windows.Forms.RadioButton();
            this.rb_multiplePorts = new System.Windows.Forms.RadioButton();
            this.cb_Tests = new System.Windows.Forms.ComboBox();
            this.dgv_Output = new System.Windows.Forms.DataGridView();
            this.dgv_col_Test = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_col_portName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_col_Port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_col_Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_col_IconResult = new System.Windows.Forms.DataGridViewImageColumn();
            this.cb_packetType = new System.Windows.Forms.ComboBox();
            this.l_Type = new System.Windows.Forms.Label();
            this.cb_clearList = new System.Windows.Forms.CheckBox();
            this.ss_Progress = new System.Windows.Forms.StatusStrip();
            this.tss_Text = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss_Progress = new System.Windows.Forms.ToolStripProgressBar();
            this.b_Clipboard = new System.Windows.Forms.Button();
            this.tb_rpcDynamic = new System.Windows.Forms.TextBox();
            this.l_rpcDynamic = new System.Windows.Forms.Label();
            this.l_portTimeout = new System.Windows.Forms.Label();
            this.tb_portTimeout = new System.Windows.Forms.TrackBar();
            this.l_porttimeValue = new System.Windows.Forms.Label();
            this.cb_scanuniquePorts = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Output)).BeginInit();
            this.ss_Progress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_portTimeout)).BeginInit();
            this.SuspendLayout();
            // 
            // b_checkPort
            // 
            this.b_checkPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_checkPort.Location = new System.Drawing.Point(505, 5);
            this.b_checkPort.Name = "b_checkPort";
            this.b_checkPort.Size = new System.Drawing.Size(75, 23);
            this.b_checkPort.TabIndex = 10;
            this.b_checkPort.Text = "Run Test";
            this.b_checkPort.UseVisualStyleBackColor = true;
            this.b_checkPort.Click += new System.EventHandler(this.b_checkPort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Destination";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port";
            // 
            // tb_Destination
            // 
            this.tb_Destination.Location = new System.Drawing.Point(12, 58);
            this.tb_Destination.Name = "tb_Destination";
            this.tb_Destination.Size = new System.Drawing.Size(149, 20);
            this.tb_Destination.TabIndex = 2;
            this.tb_Destination.TextChanged += new System.EventHandler(this.tb_Destination_TextChanged);
            // 
            // tb_Port
            // 
            this.tb_Port.Location = new System.Drawing.Point(167, 58);
            this.tb_Port.Name = "tb_Port";
            this.tb_Port.Size = new System.Drawing.Size(66, 20);
            this.tb_Port.TabIndex = 3;
            this.tb_Port.TextChanged += new System.EventHandler(this.tb_Port_TextChanged);
            // 
            // pb_Progress
            // 
            this.pb_Progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Progress.Location = new System.Drawing.Point(56, 392);
            this.pb_Progress.MarqueeAnimationSpeed = 0;
            this.pb_Progress.Name = "pb_Progress";
            this.pb_Progress.Size = new System.Drawing.Size(565, 23);
            this.pb_Progress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pb_Progress.TabIndex = 8;
            // 
            // rb_singlePort
            // 
            this.rb_singlePort.AutoSize = true;
            this.rb_singlePort.Checked = true;
            this.rb_singlePort.Location = new System.Drawing.Point(12, 12);
            this.rb_singlePort.Name = "rb_singlePort";
            this.rb_singlePort.Size = new System.Drawing.Size(110, 17);
            this.rb_singlePort.TabIndex = 1;
            this.rb_singlePort.TabStop = true;
            this.rb_singlePort.Text = "Check Single Port";
            this.rb_singlePort.UseVisualStyleBackColor = true;
            this.rb_singlePort.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rb_multiplePorts
            // 
            this.rb_multiplePorts.AutoSize = true;
            this.rb_multiplePorts.Location = new System.Drawing.Point(299, 12);
            this.rb_multiplePorts.Name = "rb_multiplePorts";
            this.rb_multiplePorts.Size = new System.Drawing.Size(122, 17);
            this.rb_multiplePorts.TabIndex = 4;
            this.rb_multiplePorts.TabStop = true;
            this.rb_multiplePorts.Text = "Check Multiple Ports";
            this.rb_multiplePorts.UseVisualStyleBackColor = true;
            this.rb_multiplePorts.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // cb_Tests
            // 
            this.cb_Tests.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_Tests.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Tests.Enabled = false;
            this.cb_Tests.FormattingEnabled = true;
            this.cb_Tests.Location = new System.Drawing.Point(299, 58);
            this.cb_Tests.Name = "cb_Tests";
            this.cb_Tests.Size = new System.Drawing.Size(281, 21);
            this.cb_Tests.TabIndex = 6;
            // 
            // dgv_Output
            // 
            this.dgv_Output.AllowUserToAddRows = false;
            this.dgv_Output.AllowUserToDeleteRows = false;
            this.dgv_Output.AllowUserToResizeRows = false;
            this.dgv_Output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Output.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgv_Output.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Output.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_col_Test,
            this.dgv_col_portName,
            this.dgv_col_Port,
            this.dgv_col_Result,
            this.dgv_col_IconResult});
            this.dgv_Output.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Output.Location = new System.Drawing.Point(0, 131);
            this.dgv_Output.MultiSelect = false;
            this.dgv_Output.Name = "dgv_Output";
            this.dgv_Output.ReadOnly = true;
            this.dgv_Output.RowHeadersVisible = false;
            this.dgv_Output.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Output.Size = new System.Drawing.Size(592, 316);
            this.dgv_Output.TabIndex = 12;
            // 
            // dgv_col_Test
            // 
            this.dgv_col_Test.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_col_Test.HeaderText = "Test";
            this.dgv_col_Test.Name = "dgv_col_Test";
            this.dgv_col_Test.ReadOnly = true;
            // 
            // dgv_col_portName
            // 
            this.dgv_col_portName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_col_portName.HeaderText = "Port Name";
            this.dgv_col_portName.Name = "dgv_col_portName";
            this.dgv_col_portName.ReadOnly = true;
            // 
            // dgv_col_Port
            // 
            this.dgv_col_Port.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_col_Port.HeaderText = "Port";
            this.dgv_col_Port.Name = "dgv_col_Port";
            this.dgv_col_Port.ReadOnly = true;
            this.dgv_col_Port.Width = 51;
            // 
            // dgv_col_Result
            // 
            this.dgv_col_Result.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_col_Result.HeaderText = "Result";
            this.dgv_col_Result.Name = "dgv_col_Result";
            this.dgv_col_Result.ReadOnly = true;
            this.dgv_col_Result.Width = 62;
            // 
            // dgv_col_IconResult
            // 
            this.dgv_col_IconResult.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_col_IconResult.HeaderText = "";
            this.dgv_col_IconResult.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgv_col_IconResult.Name = "dgv_col_IconResult";
            this.dgv_col_IconResult.ReadOnly = true;
            this.dgv_col_IconResult.Width = 5;
            // 
            // cb_packetType
            // 
            this.cb_packetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_packetType.FormattingEnabled = true;
            this.cb_packetType.Location = new System.Drawing.Point(239, 58);
            this.cb_packetType.Name = "cb_packetType";
            this.cb_packetType.Size = new System.Drawing.Size(54, 21);
            this.cb_packetType.TabIndex = 13;
            this.cb_packetType.TabStop = false;
            // 
            // l_Type
            // 
            this.l_Type.AutoSize = true;
            this.l_Type.Location = new System.Drawing.Point(236, 42);
            this.l_Type.Name = "l_Type";
            this.l_Type.Size = new System.Drawing.Size(31, 13);
            this.l_Type.TabIndex = 16;
            this.l_Type.Text = "Type";
            // 
            // cb_clearList
            // 
            this.cb_clearList.AutoSize = true;
            this.cb_clearList.Checked = true;
            this.cb_clearList.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_clearList.Location = new System.Drawing.Point(12, 92);
            this.cb_clearList.Name = "cb_clearList";
            this.cb_clearList.Size = new System.Drawing.Size(69, 17);
            this.cb_clearList.TabIndex = 8;
            this.cb_clearList.Text = "Clear List";
            this.cb_clearList.UseVisualStyleBackColor = true;
            // 
            // ss_Progress
            // 
            this.ss_Progress.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tss_Text,
            this.tss_Progress});
            this.ss_Progress.Location = new System.Drawing.Point(0, 450);
            this.ss_Progress.Name = "ss_Progress";
            this.ss_Progress.Size = new System.Drawing.Size(592, 22);
            this.ss_Progress.TabIndex = 17;
            this.ss_Progress.Resize += new System.EventHandler(this.ss_Progress_Resize);
            // 
            // tss_Text
            // 
            this.tss_Text.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tss_Text.Name = "tss_Text";
            this.tss_Text.Size = new System.Drawing.Size(0, 17);
            this.tss_Text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tss_Progress
            // 
            this.tss_Progress.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tss_Progress.AutoSize = false;
            this.tss_Progress.Name = "tss_Progress";
            this.tss_Progress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tss_Progress.Size = new System.Drawing.Size(100, 16);
            this.tss_Progress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // b_Clipboard
            // 
            this.b_Clipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Clipboard.Location = new System.Drawing.Point(505, 30);
            this.b_Clipboard.Name = "b_Clipboard";
            this.b_Clipboard.Size = new System.Drawing.Size(75, 23);
            this.b_Clipboard.TabIndex = 9;
            this.b_Clipboard.Text = "Clipboard";
            this.b_Clipboard.UseVisualStyleBackColor = true;
            this.b_Clipboard.Click += new System.EventHandler(this.b_Clipboard_Click);
            // 
            // tb_rpcDynamic
            // 
            this.tb_rpcDynamic.Location = new System.Drawing.Point(415, 32);
            this.tb_rpcDynamic.Name = "tb_rpcDynamic";
            this.tb_rpcDynamic.Size = new System.Drawing.Size(78, 20);
            this.tb_rpcDynamic.TabIndex = 5;
            this.tb_rpcDynamic.Text = "49152";
            this.tb_rpcDynamic.TextChanged += new System.EventHandler(this.tb_rpcDynamic_TextChanged);
            // 
            // l_rpcDynamic
            // 
            this.l_rpcDynamic.AutoSize = true;
            this.l_rpcDynamic.Location = new System.Drawing.Point(296, 35);
            this.l_rpcDynamic.Name = "l_rpcDynamic";
            this.l_rpcDynamic.Size = new System.Drawing.Size(118, 13);
            this.l_rpcDynamic.TabIndex = 1;
            this.l_rpcDynamic.Text = "RPC Dynamic Low Port";
            // 
            // l_portTimeout
            // 
            this.l_portTimeout.AutoSize = true;
            this.l_portTimeout.Location = new System.Drawing.Point(262, 92);
            this.l_portTimeout.Name = "l_portTimeout";
            this.l_portTimeout.Size = new System.Drawing.Size(98, 13);
            this.l_portTimeout.TabIndex = 17;
            this.l_portTimeout.Text = "Port C/S/R timeout";
            // 
            // tb_portTimeout
            // 
            this.tb_portTimeout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_portTimeout.LargeChange = 1;
            this.tb_portTimeout.Location = new System.Drawing.Point(366, 85);
            this.tb_portTimeout.Minimum = 1;
            this.tb_portTimeout.Name = "tb_portTimeout";
            this.tb_portTimeout.Size = new System.Drawing.Size(227, 45);
            this.tb_portTimeout.TabIndex = 7;
            this.tb_portTimeout.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tb_portTimeout.Value = 2;
            this.tb_portTimeout.ValueChanged += new System.EventHandler(this.tb_portTimeout_ValueChanged);
            // 
            // l_porttimeValue
            // 
            this.l_porttimeValue.AutoSize = true;
            this.l_porttimeValue.Location = new System.Drawing.Point(262, 109);
            this.l_porttimeValue.Name = "l_porttimeValue";
            this.l_porttimeValue.Size = new System.Drawing.Size(0, 13);
            this.l_porttimeValue.TabIndex = 23;
            // 
            // cb_scanuniquePorts
            // 
            this.cb_scanuniquePorts.AutoSize = true;
            this.cb_scanuniquePorts.Checked = true;
            this.cb_scanuniquePorts.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_scanuniquePorts.Location = new System.Drawing.Point(87, 92);
            this.cb_scanuniquePorts.Name = "cb_scanuniquePorts";
            this.cb_scanuniquePorts.Size = new System.Drawing.Size(112, 17);
            this.cb_scanuniquePorts.TabIndex = 24;
            this.cb_scanuniquePorts.Text = "Scan unique ports";
            this.cb_scanuniquePorts.UseVisualStyleBackColor = true;
            this.cb_scanuniquePorts.CheckedChanged += new System.EventHandler(this.cb_scanuniquePorts_CheckedChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.b_checkPort;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 472);
            this.Controls.Add(this.cb_scanuniquePorts);
            this.Controls.Add(this.l_porttimeValue);
            this.Controls.Add(this.tb_portTimeout);
            this.Controls.Add(this.l_portTimeout);
            this.Controls.Add(this.l_rpcDynamic);
            this.Controls.Add(this.tb_rpcDynamic);
            this.Controls.Add(this.b_Clipboard);
            this.Controls.Add(this.ss_Progress);
            this.Controls.Add(this.cb_clearList);
            this.Controls.Add(this.l_Type);
            this.Controls.Add(this.cb_packetType);
            this.Controls.Add(this.dgv_Output);
            this.Controls.Add(this.cb_Tests);
            this.Controls.Add(this.rb_multiplePorts);
            this.Controls.Add(this.rb_singlePort);
            this.Controls.Add(this.pb_Progress);
            this.Controls.Add(this.tb_Port);
            this.Controls.Add(this.tb_Destination);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_checkPort);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(602, 454);
            this.Name = "Form1";
            this.Text = "CheckPort by Robert Marshall (2016)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Output)).EndInit();
            this.ss_Progress.ResumeLayout(false);
            this.ss_Progress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_portTimeout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_checkPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Destination;
        private System.Windows.Forms.TextBox tb_Port;
        private System.Windows.Forms.ProgressBar pb_Progress;
        private System.Windows.Forms.RadioButton rb_singlePort;
        private System.Windows.Forms.RadioButton rb_multiplePorts;
        private System.Windows.Forms.ComboBox cb_Tests;
        private System.Windows.Forms.DataGridView dgv_Output;
        private System.Windows.Forms.ComboBox cb_packetType;
        private System.Windows.Forms.Label l_Type;
        private System.Windows.Forms.CheckBox cb_clearList;
        private System.Windows.Forms.StatusStrip ss_Progress;
        private System.Windows.Forms.ToolStripStatusLabel tss_Text;
        private System.Windows.Forms.ToolStripProgressBar tss_Progress;
        private System.Windows.Forms.Button b_Clipboard;
        private System.Windows.Forms.TextBox tb_rpcDynamic;
        private System.Windows.Forms.Label l_rpcDynamic;
        private System.Windows.Forms.Label l_portTimeout;
        private System.Windows.Forms.TrackBar tb_portTimeout;
        private System.Windows.Forms.Label l_porttimeValue;
        private System.Windows.Forms.CheckBox cb_scanuniquePorts;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_col_Test;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_col_portName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_col_Port;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_col_Result;
        private System.Windows.Forms.DataGridViewImageColumn dgv_col_IconResult;
    }
}

