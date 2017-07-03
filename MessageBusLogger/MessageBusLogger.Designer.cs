namespace MessageBusLogger
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
            this.cmbSourceSystem = new System.Windows.Forms.ComboBox();
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
            this.subscrBtn.Location = new System.Drawing.Point(931, 15);
            this.subscrBtn.Margin = new System.Windows.Forms.Padding(4);
            this.subscrBtn.Name = "subscrBtn";
            this.subscrBtn.Size = new System.Drawing.Size(163, 25);
            this.subscrBtn.TabIndex = 0;
            this.subscrBtn.Text = "Connect";
            this.subscrBtn.UseVisualStyleBackColor = true;
            this.subscrBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Location = new System.Drawing.Point(145, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(776, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Connection string";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(16, 129);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gridMessages);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtMessages);
            this.splitContainer1.Size = new System.Drawing.Size(1080, 449);
            this.splitContainer1.SplitterDistance = 504;
            this.splitContainer1.SplitterWidth = 5;
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
            this.gridMessages.Margin = new System.Windows.Forms.Padding(4);
            this.gridMessages.MultiSelect = false;
            this.gridMessages.Name = "gridMessages";
            this.gridMessages.ReadOnly = true;
            this.gridMessages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMessages.Size = new System.Drawing.Size(504, 449);
            this.gridMessages.TabIndex = 4;
            this.gridMessages.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMessages_RowEnter);
            // 
            // txtMessages
            // 
            this.txtMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessages.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessages.Location = new System.Drawing.Point(0, 0);
            this.txtMessages.Margin = new System.Windows.Forms.Padding(4);
            this.txtMessages.MaxLength = 2147483647;
            this.txtMessages.Multiline = true;
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessages.Size = new System.Drawing.Size(571, 449);
            this.txtMessages.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmbSourceSystem);
            this.groupBox1.Controls.Add(this.sourceSystem_lbl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnGetMessages);
            this.groupBox1.Controls.Add(this.cmbMessageType);
            this.groupBox1.Location = new System.Drawing.Point(17, 48);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1077, 74);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            // 
            // cmbSourceSystem
            // 
            this.cmbSourceSystem.FormattingEnabled = true;
            this.cmbSourceSystem.Location = new System.Drawing.Point(518, 23);
            this.cmbSourceSystem.Name = "cmbSourceSystem";
            this.cmbSourceSystem.Size = new System.Drawing.Size(121, 24);
            this.cmbSourceSystem.TabIndex = 7;
            // 
            // sourceSystem_lbl
            // 
            this.sourceSystem_lbl.AutoSize = true;
            this.sourceSystem_lbl.Location = new System.Drawing.Point(456, 27);
            this.sourceSystem_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sourceSystem_lbl.Name = "sourceSystem_lbl";
            this.sourceSystem_lbl.Size = new System.Drawing.Size(58, 17);
            this.sourceSystem_lbl.TabIndex = 6;
            this.sourceSystem_lbl.Text = "System:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Message type:";
            // 
            // btnGetMessages
            // 
            this.btnGetMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetMessages.Location = new System.Drawing.Point(925, 38);
            this.btnGetMessages.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetMessages.Name = "btnGetMessages";
            this.btnGetMessages.Size = new System.Drawing.Size(144, 28);
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
            this.cmbMessageType.Location = new System.Drawing.Point(128, 23);
            this.cmbMessageType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMessageType.Name = "cmbMessageType";
            this.cmbMessageType.Size = new System.Drawing.Size(300, 24);
            this.cmbMessageType.TabIndex = 0;
            // 
            // BtnResendMessage
            // 
            this.BtnResendMessage.Location = new System.Drawing.Point(943, 586);
            this.BtnResendMessage.Margin = new System.Windows.Forms.Padding(4);
            this.BtnResendMessage.Name = "BtnResendMessage";
            this.BtnResendMessage.Size = new System.Drawing.Size(153, 28);
            this.BtnResendMessage.TabIndex = 6;
            this.BtnResendMessage.Text = "Resend message";
            this.BtnResendMessage.UseVisualStyleBackColor = true;
            this.BtnResendMessage.Click += new System.EventHandler(this.BtnResendMessage_Click);
            // 
            // MessageBusLogger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 629);
            this.Controls.Add(this.BtnResendMessage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.subscrBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1127, 666);
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
        private System.Windows.Forms.Label sourceSystem_lbl;
        private System.Windows.Forms.ComboBox cmbSourceSystem;
    }
}

