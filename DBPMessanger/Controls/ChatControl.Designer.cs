namespace DBPMessanger.Controls
{
    partial class ChatControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            labelName = new Label();
            labelMessage = new Label();
            labelTime = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(labelName, 0, 0);
            tableLayoutPanel1.Controls.Add(labelMessage, 0, 1);
            tableLayoutPanel1.Controls.Add(labelTime, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RightToLeft = RightToLeft.No;
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(181, 35);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // labelName
            // 
            labelName.Anchor = AnchorStyles.Left;
            labelName.AutoSize = true;
            labelName.Location = new Point(3, 2);
            labelName.Name = "labelName";
            labelName.Size = new Size(43, 15);
            labelName.TabIndex = 0;
            labelName.Text = "박세진";
            labelName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Location = new Point(3, 20);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(131, 15);
            labelMessage.TabIndex = 1;
            labelMessage.Text = "안녕하세요 반갑습니다";
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Location = new Point(140, 20);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(38, 15);
            labelTime.TabIndex = 2;
            labelTime.Text = "12:00";
            // 
            // ChatControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Transparent;
            Controls.Add(tableLayoutPanel1);
            Name = "ChatControl";
            Size = new Size(181, 35);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label labelName;
        private Label labelMessage;
        private Label labelTime;
    }
}
