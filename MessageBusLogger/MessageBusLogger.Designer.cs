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
            this.btnSubscr = new System.Windows.Forms.Button();
            this.txtConnectionStringListener = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mainContainer = new System.Windows.Forms.SplitContainer();
            this.gridMessages = new System.Windows.Forms.DataGridView();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.txtMessages = new System.Windows.Forms.RichTextBox();
            this.groupFilters = new System.Windows.Forms.GroupBox();
            this.chbShowAll = new System.Windows.Forms.CheckBox();
            this.cmbMaxCount = new System.Windows.Forms.ComboBox();
            this.lblMaxCount = new System.Windows.Forms.Label();
            this.pickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.pickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.cmbSourceSystem = new System.Windows.Forms.ComboBox();
            this.lblSourceSystem = new System.Windows.Forms.Label();
            this.lblMessageType = new System.Windows.Forms.Label();
            this.btnGetMessages = new System.Windows.Forms.Button();
            this.cmbMessageType = new System.Windows.Forms.ComboBox();
            this.btnResendMessage = new System.Windows.Forms.Button();
            this.txtResendString = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            this.mainContainer.Panel1.SuspendLayout();
            this.mainContainer.Panel2.SuspendLayout();
            this.mainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMessages)).BeginInit();
            this.groupFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubscr
            // 
            this.btnSubscr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubscr.Location = new System.Drawing.Point(963, 14);
            this.btnSubscr.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubscr.Name = "btnSubscr";
            this.btnSubscr.Size = new System.Drawing.Size(155, 31);
            this.btnSubscr.TabIndex = 0;
            this.btnSubscr.Text = "Connect";
            this.btnSubscr.UseVisualStyleBackColor = true;
            this.btnSubscr.Click += new System.EventHandler(this.btnSubscr_Click);
            // 
            // txtConnectionStringListener
            // 
            this.txtConnectionStringListener.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConnectionStringListener.Location = new System.Drawing.Point(151, 18);
            this.txtConnectionStringListener.Margin = new System.Windows.Forms.Padding(4);
            this.txtConnectionStringListener.Name = "txtConnectionStringListener";
            this.txtConnectionStringListener.Size = new System.Drawing.Size(784, 22);
            this.txtConnectionStringListener.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Connection string:";
            // 
            // mainContainer
            // 
            this.mainContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainContainer.Location = new System.Drawing.Point(16, 151);
            this.mainContainer.Margin = new System.Windows.Forms.Padding(4);
            this.mainContainer.Name = "mainContainer";
            // 
            // mainContainer.Panel1
            // 
            this.mainContainer.Panel1.Controls.Add(this.gridMessages);
            // 
            // mainContainer.Panel2
            // 
            this.mainContainer.Panel2.Controls.Add(this.btnFind);
            this.mainContainer.Panel2.Controls.Add(this.txtFind);
            this.mainContainer.Panel2.Controls.Add(this.txtMessages);
            this.mainContainer.Size = new System.Drawing.Size(1100, 450);
            this.mainContainer.SplitterDistance = 525;
            this.mainContainer.SplitterWidth = 5;
            this.mainContainer.TabIndex = 3;
            // 
            // gridMessages
            // 
            this.gridMessages.AllowUserToAddRows = false;
            this.gridMessages.AllowUserToDeleteRows = false;
            this.gridMessages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridMessages.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.gridMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMessages.Location = new System.Drawing.Point(0, 0);
            this.gridMessages.Margin = new System.Windows.Forms.Padding(4);
            this.gridMessages.MultiSelect = false;
            this.gridMessages.Name = "gridMessages";
            this.gridMessages.ReadOnly = true;
            this.gridMessages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMessages.Size = new System.Drawing.Size(525, 450);
            this.gridMessages.TabIndex = 4;
            this.gridMessages.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMessages_RowEnter);
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.Location = new System.Drawing.Point(415, 0);
            this.btnFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(151, 28);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtFind
            // 
            this.txtFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFind.Location = new System.Drawing.Point(3, 2);
            this.txtFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(387, 22);
            this.txtFind.TabIndex = 1;
            this.txtFind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFind_KeyUp);
            // 
            // txtMessages
            // 
            this.txtMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessages.Location = new System.Drawing.Point(0, 42);
            this.txtMessages.Margin = new System.Windows.Forms.Padding(4);
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.Size = new System.Drawing.Size(567, 408);
            this.txtMessages.TabIndex = 0;
            this.txtMessages.Text = "";
            this.txtMessages.WordWrap = false;
            // 
            // groupFilters
            // 
            this.groupFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupFilters.Controls.Add(this.chbShowAll);
            this.groupFilters.Controls.Add(this.cmbMaxCount);
            this.groupFilters.Controls.Add(this.lblMaxCount);
            this.groupFilters.Controls.Add(this.pickerEndDate);
            this.groupFilters.Controls.Add(this.pickerStartDate);
            this.groupFilters.Controls.Add(this.lblEndDate);
            this.groupFilters.Controls.Add(this.lblStartDate);
            this.groupFilters.Controls.Add(this.cmbSourceSystem);
            this.groupFilters.Controls.Add(this.lblSourceSystem);
            this.groupFilters.Controls.Add(this.lblMessageType);
            this.groupFilters.Controls.Add(this.btnGetMessages);
            this.groupFilters.Controls.Add(this.cmbMessageType);
            this.groupFilters.Location = new System.Drawing.Point(17, 48);
            this.groupFilters.Margin = new System.Windows.Forms.Padding(4);
            this.groupFilters.Name = "groupFilters";
            this.groupFilters.Padding = new System.Windows.Forms.Padding(4);
            this.groupFilters.Size = new System.Drawing.Size(1097, 95);
            this.groupFilters.TabIndex = 4;
            this.groupFilters.TabStop = false;
            this.groupFilters.Text = "Filters";
            // 
            // chbShowAll
            // 
            this.chbShowAll.AutoSize = true;
            this.chbShowAll.Location = new System.Drawing.Point(712, 61);
            this.chbShowAll.Name = "chbShowAll";
            this.chbShowAll.Size = new System.Drawing.Size(193, 21);
            this.chbShowAll.TabIndex = 15;
            this.chbShowAll.Text = "Show msg from all busses";
            this.chbShowAll.UseVisualStyleBackColor = true;
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
            this.cmbMaxCount.Location = new System.Drawing.Point(773, 25);
            this.cmbMaxCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMaxCount.Name = "cmbMaxCount";
            this.cmbMaxCount.Size = new System.Drawing.Size(121, 24);
            this.cmbMaxCount.TabIndex = 13;
            // 
            // lblMaxCount
            // 
            this.lblMaxCount.AutoSize = true;
            this.lblMaxCount.Location = new System.Drawing.Point(709, 28);
            this.lblMaxCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaxCount.Name = "lblMaxCount";
            this.lblMaxCount.Size = new System.Drawing.Size(49, 17);
            this.lblMaxCount.TabIndex = 12;
            this.lblMaxCount.Text = "Count:";
            // 
            // pickerEndDate
            // 
            this.pickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerEndDate.Location = new System.Drawing.Point(511, 60);
            this.pickerEndDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pickerEndDate.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.pickerEndDate.Name = "pickerEndDate";
            this.pickerEndDate.Size = new System.Drawing.Size(136, 22);
            this.pickerEndDate.TabIndex = 11;
            this.pickerEndDate.Value = new System.DateTime(2017, 7, 17, 19, 7, 52, 0);
            // 
            // pickerStartDate
            // 
            this.pickerStartDate.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerStartDate.Location = new System.Drawing.Point(511, 25);
            this.pickerStartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pickerStartDate.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.pickerStartDate.Name = "pickerStartDate";
            this.pickerStartDate.Size = new System.Drawing.Size(136, 22);
            this.pickerStartDate.TabIndex = 10;
            this.pickerStartDate.Value = new System.DateTime(2017, 7, 17, 19, 7, 52, 0);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(476, 62);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(29, 17);
            this.lblEndDate.TabIndex = 9;
            this.lblEndDate.Text = "To:";
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
            // cmbSourceSystem
            // 
            this.cmbSourceSystem.FormattingEnabled = true;
            this.cmbSourceSystem.Location = new System.Drawing.Point(115, 62);
            this.cmbSourceSystem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSourceSystem.Name = "cmbSourceSystem";
            this.cmbSourceSystem.Size = new System.Drawing.Size(301, 24);
            this.cmbSourceSystem.TabIndex = 7;
            // 
            // lblSourceSystem
            // 
            this.lblSourceSystem.AutoSize = true;
            this.lblSourceSystem.Location = new System.Drawing.Point(51, 64);
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
            this.btnGetMessages.Location = new System.Drawing.Point(946, 21);
            this.btnGetMessages.Margin = new System.Windows.Forms.Padding(4);
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
            this.cmbMessageType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMessageType.Name = "cmbMessageType";
            this.cmbMessageType.Size = new System.Drawing.Size(300, 24);
            this.cmbMessageType.TabIndex = 0;
            // 
            // btnResendMessage
            // 
            this.btnResendMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResendMessage.Location = new System.Drawing.Point(961, 614);
            this.btnResendMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResendMessage.Name = "btnResendMessage";
            this.btnResendMessage.Size = new System.Drawing.Size(153, 31);
            this.btnResendMessage.TabIndex = 6;
            this.btnResendMessage.Text = "Resend message";
            this.btnResendMessage.UseVisualStyleBackColor = true;
            this.btnResendMessage.Click += new System.EventHandler(this.BtnResendMessage_Click);
            // 
            // txtResendString
            // 
            this.txtResendString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResendString.Location = new System.Drawing.Point(144, 618);
            this.txtResendString.Margin = new System.Windows.Forms.Padding(4);
            this.txtResendString.Name = "txtResendString";
            this.txtResendString.Size = new System.Drawing.Size(791, 22);
            this.txtResendString.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 621);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Connection string:";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisconnect.Location = new System.Drawing.Point(962, 14);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(155, 31);
            this.btnDisconnect.TabIndex = 9;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // MessageBusLogger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 662);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResendString);
            this.Controls.Add(this.btnResendMessage);
            this.Controls.Add(this.groupFilters);
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConnectionStringListener);
            this.Controls.Add(this.btnSubscr);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1149, 698);
            this.Name = "MessageBusLogger";
            this.Text = "Message Bus Logger";
            this.mainContainer.Panel1.ResumeLayout(false);
            this.mainContainer.Panel2.ResumeLayout(false);
            this.mainContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMessages)).EndInit();
            this.groupFilters.ResumeLayout(false);
            this.groupFilters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubscr;
        private System.Windows.Forms.TextBox txtConnectionStringListener;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer mainContainer;
        private System.Windows.Forms.DataGridView gridMessages;
        private System.Windows.Forms.GroupBox groupFilters;
        private System.Windows.Forms.ComboBox cmbMessageType;
        private System.Windows.Forms.Label lblMessageType;
        private System.Windows.Forms.Button btnGetMessages;
        private System.Windows.Forms.Button btnResendMessage;
        private System.Windows.Forms.Label lblSourceSystem;
        private System.Windows.Forms.ComboBox cmbSourceSystem;
        private System.Windows.Forms.TextBox txtResendString;
        private System.Windows.Forms.RichTextBox txtMessages;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DateTimePicker pickerEndDate;
        private System.Windows.Forms.DateTimePicker pickerStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.ComboBox cmbMaxCount;
        private System.Windows.Forms.Label lblMaxCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chbShowAll;
        private System.Windows.Forms.Button btnDisconnect;
    }
}

