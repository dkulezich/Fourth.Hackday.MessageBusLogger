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
            this.SuspendLayout();
            // 
            // subscrBtn
            // 
            this.subscrBtn.Location = new System.Drawing.Point(140, 68);
            this.subscrBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.subscrBtn.Name = "subscrBtn";
            this.subscrBtn.Size = new System.Drawing.Size(100, 28);
            this.subscrBtn.TabIndex = 0;
            this.subscrBtn.Text = "Subscribe";
            this.subscrBtn.UseVisualStyleBackColor = true;
            this.subscrBtn.Click += new System.EventHandler(this.subscrBtn_Click);
            // 
            // MessageBusLogger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 322);
            this.Controls.Add(this.subscrBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MessageBusLogger";
            this.Text = "Message Bus Logger";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button subscrBtn;
    }
}

