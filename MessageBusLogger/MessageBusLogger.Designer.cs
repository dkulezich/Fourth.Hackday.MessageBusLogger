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
            this.txt_ConnectionStringListener = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gridMessages = new System.Windows.Forms.DataGridView();
            this.btn_Find = new System.Windows.Forms.Button();
            this.txt_Find = new System.Windows.Forms.TextBox();
            this.txtMessages = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbSourceSystem = new System.Windows.Forms.ComboBox();
            this.lblSourceSystem = new System.Windows.Forms.Label();
            this.lblMessageType = new System.Windows.Forms.Label();
            this.btnGetMessages = new System.Windows.Forms.Button();
            this.cmbMessageType = new System.Windows.Forms.ComboBox();
            this.BtnResendMessage = new System.Windows.Forms.Button();
            this.txt_ResendString = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.pickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.pickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.cmbMaxCount = new System.Windows.Forms.ComboBox();
            this.lblMaxCount = new System.Windows.Forms.Label();
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
            this.subscrBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.subscrBtn.Location = new System.Drawing.Point(953, 14);
            this.subscrBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.subscrBtn.Name = "subscrBtn";
            this.subscrBtn.Size = new System.Drawing.Size(153, 31);
            this.subscrBtn.TabIndex = 0;
            this.subscrBtn.Text = "Connect";
            this.subscrBtn.UseVisualStyleBackColor = true;
            this.subscrBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // txt_ConnectionStringListener
            // 
            this.txt_ConnectionStringListener.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ConnectionStringListener.Location = new System.Drawing.Point(151, 18);
            this.txt_ConnectionStringListener.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ConnectionStringListener.Name = "txt_ConnectionStringListener";
            this.txt_ConnectionStringListener.Size = new System.Drawing.Size(784, 22);
            this.txt_ConnectionStringListener.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Connection string:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(16, 151);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gridMessages);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btn_Find);
            this.splitContainer1.Panel2.Controls.Add(this.txt_Find);
            this.splitContainer1.Panel2.Controls.Add(this.txtMessages);
            this.splitContainer1.Size = new System.Drawing.Size(1100, 451);
            this.splitContainer1.SplitterDistance = 526;
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
            this.gridMessages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridMessages.MultiSelect = false;
            this.gridMessages.Name = "gridMessages";
            this.gridMessages.ReadOnly = true;
            this.gridMessages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMessages.Size = new System.Drawing.Size(522, 451);
            this.gridMessages.TabIndex = 4;
            this.gridMessages.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMessages_RowEnter);
            // 
            // btn_Find
            // 
            this.btn_Find.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Find.Location = new System.Drawing.Point(303, 3);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(108, 25);
            this.btn_Find.TabIndex = 2;
            this.btn_Find.Text = "Find";
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // txt_Find
            // 
            this.txt_Find.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Find.Location = new System.Drawing.Point(0, 6);
            this.txt_Find.Name = "txt_Find";
            this.txt_Find.Size = new System.Drawing.Size(285, 20);
            this.txt_Find.TabIndex = 1;
            this.txt_Find.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Find_KeyUp);
            // 
            // txtMessages
            // 
            this.txtMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessages.Location = new System.Drawing.Point(0, 42);
            this.txtMessages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.ReadOnly = true;
            this.txtMessages.Size = new System.Drawing.Size(569, 408);
            this.txtMessages.TabIndex = 0;
            this.txtMessages.Text = "";
            this.txtMessages.WordWrap = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmbMaxCount);
            this.groupBox1.Controls.Add(this.lblMaxCount);
            this.groupBox1.Controls.Add(this.pickerEndDate);
            this.groupBox1.Controls.Add(this.pickerStartDate);
            this.groupBox1.Controls.Add(this.lblEndDate);
            this.groupBox1.Controls.Add(this.lblStartDate);
            this.groupBox1.Controls.Add(this.cmbSourceSystem);
            this.groupBox1.Controls.Add(this.lblSourceSystem);
            this.groupBox1.Controls.Add(this.lblMessageType);
            this.groupBox1.Controls.Add(this.btnGetMessages);
            this.groupBox1.Controls.Add(this.cmbMessageType);
            this.groupBox1.Location = new System.Drawing.Point(17, 48);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1097, 95);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            // 
            // cmbSourceSystem
            // 
            this.cmbSourceSystem.FormattingEnabled = true;
            this.cmbSourceSystem.Location = new System.Drawing.Point(115, 61);
            this.cmbSourceSystem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSourceSystem.Name = "cmbSourceSystem";
            this.cmbSourceSystem.Size = new System.Drawing.Size(121, 24);
            this.cmbSourceSystem.TabIndex = 7;
            // 
            // lblSourceSystem
            // 
            this.lblSourceSystem.AutoSize = true;
            this.lblSourceSystem.Location = new System.Drawing.Point(50, 64);
            this.lblSourceSystem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSourceSystem.Name = "lblSourceSystem";
            this.lblSourceSystem.Size = new System.Drawing.Size(58, 17);
            this.lblSourceSystem.TabIndex = 6;
            this.lblSourceSystem.Text = "System:";
            // 
            // lblMessageType
            // 
            this.lblMessageType.AutoSize = true;
            this.lblMessageType.Location = new System.Drawing.Point(8, 28);
            this.lblMessageType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessageType.Name = "lblMessageType";
            this.lblMessageType.Size = new System.Drawing.Size(100, 17);
            this.lblMessageType.TabIndex = 1;
            this.lblMessageType.Text = "Message type:";
            // 
            // btnGetMessages
            // 
            this.btnGetMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetMessages.Location = new System.Drawing.Point(945, 59);
            this.btnGetMessages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGetMessages.Name = "btnGetMessages";
            this.btnGetMessages.Size = new System.Drawing.Size(144, 31);
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
            this.cmbMessageType.Location = new System.Drawing.Point(116, 25);
            this.cmbMessageType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbMessageType.Name = "cmbMessageType";
            this.cmbMessageType.Size = new System.Drawing.Size(300, 24);
            this.cmbMessageType.TabIndex = 0;
            // 
            // BtnResendMessage
            // 
            this.BtnResendMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnResendMessage.Enabled = false;
            this.BtnResendMessage.Location = new System.Drawing.Point(15, 610);
            this.BtnResendMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnResendMessage.Name = "BtnResendMessage";
            this.BtnResendMessage.Size = new System.Drawing.Size(153, 31);
            this.BtnResendMessage.TabIndex = 6;
            this.BtnResendMessage.Text = "Resend message";
            this.BtnResendMessage.UseVisualStyleBackColor = true;
            this.BtnResendMessage.Click += new System.EventHandler(this.BtnResendMessage_Click);
            // 
            // txt_ResendString
            // 
            this.txt_ResendString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ResendString.Enabled = false;
            this.txt_ResendString.Location = new System.Drawing.Point(199, 614);
            this.txt_ResendString.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ResendString.Name = "txt_ResendString";
            this.txt_ResendString.Size = new System.Drawing.Size(913, 22);
            this.txt_ResendString.TabIndex = 7;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(461, 28);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(44, 17);
            this.lblStartDate.TabIndex = 8;
            this.lblStartDate.Text = "From:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(476, 61);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(29, 17);
            this.lblEndDate.TabIndex = 9;
            this.lblEndDate.Text = "To:";
            // 
            // pickerStartDate
            // 
            this.pickerStartDate.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerStartDate.Location = new System.Drawing.Point(511, 25);
            this.pickerStartDate.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.pickerStartDate.Name = "pickerStartDate";
            this.pickerStartDate.Size = new System.Drawing.Size(136, 22);
            this.pickerStartDate.TabIndex = 10;
            this.pickerStartDate.UseWaitCursor = true;
            this.pickerStartDate.Value = new System.DateTime(2017, 7, 17, 19, 7, 52, 0);
            // 
            // pickerEndDate
            // 
            this.pickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerEndDate.Location = new System.Drawing.Point(511, 60);
            this.pickerEndDate.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.pickerEndDate.Name = "pickerEndDate";
            this.pickerEndDate.Size = new System.Drawing.Size(136, 22);
            this.pickerEndDate.TabIndex = 11;
            this.pickerEndDate.UseWaitCursor = true;
            this.pickerEndDate.Value = new System.DateTime(2017, 7, 17, 19, 7, 52, 0);
            // 
            // cmbMaxCount
            // 
            this.cmbMaxCount.FormattingEnabled = true;
            this.cmbMaxCount.Items.AddRange(new object[] {
            "10",
            "20",
            "50",
            "100",
            "500",
            "1000"});
            this.cmbMaxCount.Location = new System.Drawing.Point(779, 25);
            this.cmbMaxCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMaxCount.Name = "cmbMaxCount";
            this.cmbMaxCount.Size = new System.Drawing.Size(121, 24);
            this.cmbMaxCount.TabIndex = 13;
            // 
            // lblMaxCount
            // 
            this.lblMaxCount.AutoSize = true;
            this.lblMaxCount.Location = new System.Drawing.Point(714, 28);
            this.lblMaxCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaxCount.Name = "lblMaxCount";
            this.lblMaxCount.Size = new System.Drawing.Size(49, 17);
            this.lblMaxCount.TabIndex = 12;
            this.lblMaxCount.Text = "Count:";
            // 
            // MessageBusLogger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 653);
            this.Controls.Add(this.txt_ResendString);
            this.Controls.Add(this.BtnResendMessage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ConnectionStringListener);
            this.Controls.Add(this.subscrBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1150, 700);
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
        private System.Windows.Forms.TextBox txt_ConnectionStringListener;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView gridMessages;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbMessageType;
        private System.Windows.Forms.Label lblMessageType;
        private System.Windows.Forms.Button btnGetMessages;
        private System.Windows.Forms.Button BtnResendMessage;
        private System.Windows.Forms.Label lblSourceSystem;
        private System.Windows.Forms.ComboBox cmbSourceSystem;
        private System.Windows.Forms.TextBox txt_ResendString;
        private System.Windows.Forms.RichTextBox txtMessages;
        private System.Windows.Forms.TextBox txt_Find;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.DateTimePicker pickerEndDate;
        private System.Windows.Forms.DateTimePicker pickerStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.ComboBox cmbMaxCount;
        private System.Windows.Forms.Label lblMaxCount;
    }
}

