﻿namespace MessageBusLogger
{
    partial class MessageBusLogger
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
            this.subscrBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gridMessages = new System.Windows.Forms.DataGridView();
            this.txtMessages = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sourceSystem_text = new System.Windows.Forms.TextBox();
            this.sourceSystem_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGetMessages = new System.Windows.Forms.Button();
            this.cmbMessageType = new System.Windows.Forms.ComboBox();
            this.BtnResendMessage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMessages)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // subscrBtn
            // 
            this.subscrBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.subscrBtn.Location = new System.Drawing.Point(698, 12);
            this.subscrBtn.Name = "subscrBtn";
            this.subscrBtn.Size = new System.Drawing.Size(122, 20);
            this.subscrBtn.TabIndex = 0;
            this.subscrBtn.Text = "Connect";
            this.subscrBtn.UseVisualStyleBackColor = true;
            this.subscrBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Location = new System.Drawing.Point(109, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(583, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Connection string";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 105);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gridMessages);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtMessages);
            this.splitContainer1.Size = new System.Drawing.Size(810, 365);
            this.splitContainer1.SplitterDistance = 378;
            this.splitContainer1.TabIndex = 3;
            // 
            // gridMessages
            // 
            this.gridMessages.AllowUserToAddRows = false;
            this.gridMessages.AllowUserToDeleteRows = false;
            this.gridMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridMessages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridMessages.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.gridMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMessages.Location = new System.Drawing.Point(0, 0);
            this.gridMessages.MultiSelect = false;
            this.gridMessages.Name = "gridMessages";
            this.gridMessages.ReadOnly = true;
            this.gridMessages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMessages.Size = new System.Drawing.Size(378, 365);
            this.gridMessages.TabIndex = 4;
            this.gridMessages.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMessages_RowEnter);
            // 
            // txtMessages
            // 
            this.txtMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessages.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessages.Location = new System.Drawing.Point(0, 0);
            this.txtMessages.MaxLength = 2147483647;
            this.txtMessages.Multiline = true;
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessages.Size = new System.Drawing.Size(428, 365);
            this.txtMessages.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.sourceSystem_text);
            this.groupBox1.Controls.Add(this.sourceSystem_lbl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnGetMessages);
            this.groupBox1.Controls.Add(this.cmbMessageType);
            this.groupBox1.Location = new System.Drawing.Point(13, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 60);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            // 
            // sourceSystem_text
            // 
            this.sourceSystem_text.Location = new System.Drawing.Point(390, 19);
            this.sourceSystem_text.Name = "sourceSystem_text";
            this.sourceSystem_text.Size = new System.Drawing.Size(100, 20);
            this.sourceSystem_text.TabIndex = 7;
            // 
            // sourceSystem_lbl
            // 
            this.sourceSystem_lbl.AutoSize = true;
            this.sourceSystem_lbl.Location = new System.Drawing.Point(342, 22);
            this.sourceSystem_lbl.Name = "sourceSystem_lbl";
            this.sourceSystem_lbl.Size = new System.Drawing.Size(41, 13);
            this.sourceSystem_lbl.TabIndex = 6;
            this.sourceSystem_lbl.Text = "System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Message type:";
            // 
            // btnGetMessages
            // 
            this.btnGetMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetMessages.Location = new System.Drawing.Point(694, 31);
            this.btnGetMessages.Name = "btnGetMessages";
            this.btnGetMessages.Size = new System.Drawing.Size(108, 23);
            this.btnGetMessages.TabIndex = 5;
            this.btnGetMessages.Text = "Get messages";
            this.btnGetMessages.UseVisualStyleBackColor = true;
            this.btnGetMessages.Click += new System.EventHandler(this.btnGetMessages_Click);
            // 
            // cmbMessageType
            // 
            this.cmbMessageType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMessageType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMessageType.FormattingEnabled = true;
            this.cmbMessageType.Location = new System.Drawing.Point(96, 19);
            this.cmbMessageType.Name = "cmbMessageType";
            this.cmbMessageType.Size = new System.Drawing.Size(226, 21);
            this.cmbMessageType.TabIndex = 0;
            // 
            // BtnResendMessage
            // 
            this.BtnResendMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnResendMessage.Location = new System.Drawing.Point(707, 476);
            this.BtnResendMessage.Name = "BtnResendMessage";
            this.BtnResendMessage.Size = new System.Drawing.Size(115, 23);
            this.BtnResendMessage.TabIndex = 6;
            this.BtnResendMessage.Text = "Resend message";
            this.BtnResendMessage.UseVisualStyleBackColor = true;
            this.BtnResendMessage.Click += new System.EventHandler(this.BtnResendMessage_Click);
            // 
            // MessageBusLogger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.BtnResendMessage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.subscrBtn);
            this.MinimumSize = new System.Drawing.Size(850, 550);
            this.Name = "MessageBusLogger";
            this.Text = "Message Bus Logger";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMessages)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button subscrBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView gridMessages;
        private System.Windows.Forms.TextBox txtMessages;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbMessageType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGetMessages;
        private System.Windows.Forms.Button BtnResendMessage;
        private System.Windows.Forms.TextBox sourceSystem_text;
        private System.Windows.Forms.Label sourceSystem_lbl;
    }
}

