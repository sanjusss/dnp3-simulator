
namespace Automatak.Simulator.DNP3.Components
{
    partial class OutstationDialog
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
            this.groupBoxButtons = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.linkConfigControl = new Automatak.Simulator.DNP3.Components.LinkConfigControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.eventBufferConfigControl1 = new Automatak.Simulator.DNP3.Components.EventBufferConfigControl();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownMaxControls = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownSelectTimeout = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownMaxTxFrag = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownUnsolicitedRetry = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownUnsolConfirmTimeout = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownSolConfirmTimeout = new System.Windows.Forms.NumericUpDown();
            this.checkBoxEnableUnsol = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.staticResponseTypeControl1 = new Automatak.Simulator.DNP3.Components.StaticResponseTypeControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.eventResponseTypeControl1 = new Automatak.Simulator.DNP3.Components.EventResponseTypeControl();
            this.groupBoxDatabase = new System.Windows.Forms.GroupBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxTemplate = new System.Windows.Forms.ComboBox();
            this.groupBoxButtons.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxControls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSelectTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxTxFrag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUnsolicitedRetry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUnsolConfirmTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSolConfirmTimeout)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBoxDatabase.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxButtons
            // 
            this.groupBoxButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxButtons.Controls.Add(this.label3);
            this.groupBoxButtons.Controls.Add(this.buttonAdd);
            this.groupBoxButtons.Controls.Add(this.textBoxID);
            this.groupBoxButtons.Location = new System.Drawing.Point(12, 472);
            this.groupBoxButtons.Name = "groupBoxButtons";
            this.groupBoxButtons.Size = new System.Drawing.Size(912, 66);
            this.groupBoxButtons.TabIndex = 0;
            this.groupBoxButtons.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Alias";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(307, 18);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(238, 39);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxID.Location = new System.Drawing.Point(24, 29);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(88, 21);
            this.textBoxID.TabIndex = 4;
            this.textBoxID.Text = "outstation";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(935, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 5;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(912, 388);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.linkConfigControl);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(904, 362);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Link";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // linkConfigControl
            // 
            this.linkConfigControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkConfigControl.Location = new System.Drawing.Point(6, 6);
            this.linkConfigControl.Name = "linkConfigControl";
            this.linkConfigControl.Size = new System.Drawing.Size(892, 350);
            this.linkConfigControl.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.eventBufferConfigControl1);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.numericUpDownMaxControls);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.numericUpDownSelectTimeout);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.numericUpDownMaxTxFrag);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.numericUpDownUnsolicitedRetry);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.numericUpDownUnsolConfirmTimeout);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.numericUpDownSolConfirmTimeout);
            this.tabPage2.Controls.Add(this.checkBoxEnableUnsol);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(904, 362);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Outstation";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // eventBufferConfigControl1
            // 
            this.eventBufferConfigControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventBufferConfigControl1.Location = new System.Drawing.Point(301, 25);
            this.eventBufferConfigControl1.Name = "eventBufferConfigControl1";
            this.eventBufferConfigControl1.Size = new System.Drawing.Size(597, 331);
            this.eventBufferConfigControl1.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(98, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "Max Controls Per Request";
            // 
            // numericUpDownMaxControls
            // 
            this.numericUpDownMaxControls.Location = new System.Drawing.Point(20, 170);
            this.numericUpDownMaxControls.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericUpDownMaxControls.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMaxControls.Name = "numericUpDownMaxControls";
            this.numericUpDownMaxControls.Size = new System.Drawing.Size(70, 21);
            this.numericUpDownMaxControls.TabIndex = 12;
            this.numericUpDownMaxControls.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(98, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "Select TImeout  (ms)";
            // 
            // numericUpDownSelectTimeout
            // 
            this.numericUpDownSelectTimeout.Location = new System.Drawing.Point(20, 122);
            this.numericUpDownSelectTimeout.Maximum = new decimal(new int[] {
            120000,
            0,
            0,
            0});
            this.numericUpDownSelectTimeout.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownSelectTimeout.Name = "numericUpDownSelectTimeout";
            this.numericUpDownSelectTimeout.Size = new System.Drawing.Size(70, 21);
            this.numericUpDownSelectTimeout.TabIndex = 9;
            this.numericUpDownSelectTimeout.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "Max Tx Fragment Size";
            // 
            // numericUpDownMaxTxFrag
            // 
            this.numericUpDownMaxTxFrag.Location = new System.Drawing.Point(20, 146);
            this.numericUpDownMaxTxFrag.Maximum = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            this.numericUpDownMaxTxFrag.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownMaxTxFrag.Name = "numericUpDownMaxTxFrag";
            this.numericUpDownMaxTxFrag.Size = new System.Drawing.Size(70, 21);
            this.numericUpDownMaxTxFrag.TabIndex = 7;
            this.numericUpDownMaxTxFrag.Value = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Unsolicited Retry Period (ms)";
            // 
            // numericUpDownUnsolicitedRetry
            // 
            this.numericUpDownUnsolicitedRetry.Location = new System.Drawing.Point(20, 96);
            this.numericUpDownUnsolicitedRetry.Maximum = new decimal(new int[] {
            120000,
            0,
            0,
            0});
            this.numericUpDownUnsolicitedRetry.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownUnsolicitedRetry.Name = "numericUpDownUnsolicitedRetry";
            this.numericUpDownUnsolicitedRetry.Size = new System.Drawing.Size(70, 21);
            this.numericUpDownUnsolicitedRetry.TabIndex = 5;
            this.numericUpDownUnsolicitedRetry.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Unsolicited Confirm Timeout (ms)";
            // 
            // numericUpDownUnsolConfirmTimeout
            // 
            this.numericUpDownUnsolConfirmTimeout.Location = new System.Drawing.Point(20, 72);
            this.numericUpDownUnsolConfirmTimeout.Maximum = new decimal(new int[] {
            120000,
            0,
            0,
            0});
            this.numericUpDownUnsolConfirmTimeout.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownUnsolConfirmTimeout.Name = "numericUpDownUnsolConfirmTimeout";
            this.numericUpDownUnsolConfirmTimeout.Size = new System.Drawing.Size(70, 21);
            this.numericUpDownUnsolConfirmTimeout.TabIndex = 3;
            this.numericUpDownUnsolConfirmTimeout.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Solicited Confirm Timeout (ms)";
            // 
            // numericUpDownSolConfirmTimeout
            // 
            this.numericUpDownSolConfirmTimeout.Location = new System.Drawing.Point(20, 48);
            this.numericUpDownSolConfirmTimeout.Maximum = new decimal(new int[] {
            120000,
            0,
            0,
            0});
            this.numericUpDownSolConfirmTimeout.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownSolConfirmTimeout.Name = "numericUpDownSolConfirmTimeout";
            this.numericUpDownSolConfirmTimeout.Size = new System.Drawing.Size(70, 21);
            this.numericUpDownSolConfirmTimeout.TabIndex = 1;
            this.numericUpDownSolConfirmTimeout.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // checkBoxEnableUnsol
            // 
            this.checkBoxEnableUnsol.AutoSize = true;
            this.checkBoxEnableUnsol.Checked = true;
            this.checkBoxEnableUnsol.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEnableUnsol.Location = new System.Drawing.Point(20, 25);
            this.checkBoxEnableUnsol.Name = "checkBoxEnableUnsol";
            this.checkBoxEnableUnsol.Size = new System.Drawing.Size(162, 16);
            this.checkBoxEnableUnsol.TabIndex = 0;
            this.checkBoxEnableUnsol.Text = "Enable Unsolicited Mode";
            this.checkBoxEnableUnsol.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.staticResponseTypeControl1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(904, 362);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Static Defaults";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // staticResponseTypeControl1
            // 
            this.staticResponseTypeControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.staticResponseTypeControl1.Location = new System.Drawing.Point(6, 6);
            this.staticResponseTypeControl1.Name = "staticResponseTypeControl1";
            this.staticResponseTypeControl1.Size = new System.Drawing.Size(892, 350);
            this.staticResponseTypeControl1.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.eventResponseTypeControl1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(904, 362);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Event Defaults";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // eventResponseTypeControl1
            // 
            this.eventResponseTypeControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventResponseTypeControl1.Location = new System.Drawing.Point(6, 6);
            this.eventResponseTypeControl1.Name = "eventResponseTypeControl1";
            this.eventResponseTypeControl1.Size = new System.Drawing.Size(892, 350);
            this.eventResponseTypeControl1.TabIndex = 0;
            // 
            // groupBoxDatabase
            // 
            this.groupBoxDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDatabase.Controls.Add(this.buttonEdit);
            this.groupBoxDatabase.Controls.Add(this.buttonNew);
            this.groupBoxDatabase.Controls.Add(this.label9);
            this.groupBoxDatabase.Controls.Add(this.comboBoxTemplate);
            this.groupBoxDatabase.Location = new System.Drawing.Point(12, 405);
            this.groupBoxDatabase.Name = "groupBoxDatabase";
            this.groupBoxDatabase.Size = new System.Drawing.Size(912, 61);
            this.groupBoxDatabase.TabIndex = 8;
            this.groupBoxDatabase.TabStop = false;
            this.groupBoxDatabase.Text = "Database";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEdit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonEdit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(307, 16);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(116, 39);
            this.buttonEdit.TabIndex = 9;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonNew.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNew.Location = new System.Drawing.Point(429, 16);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(116, 39);
            this.buttonNew.TabIndex = 8;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(154, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 7;
            this.label9.Text = "Template";
            // 
            // comboBoxTemplate
            // 
            this.comboBoxTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTemplate.FormattingEnabled = true;
            this.comboBoxTemplate.Location = new System.Drawing.Point(10, 27);
            this.comboBoxTemplate.Name = "comboBoxTemplate";
            this.comboBoxTemplate.Size = new System.Drawing.Size(137, 20);
            this.comboBoxTemplate.TabIndex = 6;
            this.comboBoxTemplate.SelectedIndexChanged += new System.EventHandler(this.comboBoxTemplate_SelectedIndexChanged);
            // 
            // OutstationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 561);
            this.Controls.Add(this.groupBoxDatabase);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBoxButtons);
            this.MinimizeBox = false;
            this.Name = "OutstationDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Outstation";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.OutstationDialog_Load);
            this.groupBoxButtons.ResumeLayout(false);
            this.groupBoxButtons.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxControls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSelectTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxTxFrag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUnsolicitedRetry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUnsolConfirmTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSolConfirmTimeout)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBoxDatabase.ResumeLayout(false);
            this.groupBoxDatabase.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxButtons;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private Components.LinkConfigControl linkConfigControl;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBoxDatabase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TabPage tabPage3;
        private StaticResponseTypeControl staticResponseTypeControl1;
        private System.Windows.Forms.TabPage tabPage4;
        private EventResponseTypeControl eventResponseTypeControl1;
        private System.Windows.Forms.CheckBox checkBoxEnableUnsol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownUnsolConfirmTimeout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownSolConfirmTimeout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownUnsolicitedRetry;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxTxFrag;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownSelectTimeout;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxControls;
        private System.Windows.Forms.ComboBox comboBoxTemplate;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Label label9;
        private EventBufferConfigControl eventBufferConfigControl1;
    }
}