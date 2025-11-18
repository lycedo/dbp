namespace DBPMessanger.Forms
{
    partial class AlertForm
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
            labelName = new Label();
            labelMessage = new Label();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("맑은 고딕", 12F);
            labelName.Location = new Point(33, 18);
            labelName.Name = "labelName";
            labelName.Size = new Size(42, 21);
            labelName.TabIndex = 0;
            labelName.Text = "이름";
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Location = new Point(42, 48);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(43, 15);
            labelMessage.TabIndex = 1;
            labelMessage.Text = "메세지";
            // 
            // AlertForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 93);
            Controls.Add(labelMessage);
            Controls.Add(labelName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AlertForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "AlertForm";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label labelMessage;
    }
}