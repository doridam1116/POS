namespace POS_System
{
    partial class Form1
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.uuidTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.settingSaveBtn = new System.Windows.Forms.Button();
            this.showMsg = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uuidTextBox
            // 
            this.uuidTextBox.Location = new System.Drawing.Point(120, 115);
            this.uuidTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.uuidTextBox.Name = "uuidTextBox";
            this.uuidTextBox.Size = new System.Drawing.Size(258, 21);
            this.uuidTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(36, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "UUID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(36, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Message : ";
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.startBtn.Location = new System.Drawing.Point(525, 165);
            this.startBtn.Margin = new System.Windows.Forms.Padding(2);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(147, 73);
            this.startBtn.TabIndex = 11;
            this.startBtn.Text = "시작";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // settingSaveBtn
            // 
            this.settingSaveBtn.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.settingSaveBtn.Location = new System.Drawing.Point(525, 61);
            this.settingSaveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.settingSaveBtn.Name = "settingSaveBtn";
            this.settingSaveBtn.Size = new System.Drawing.Size(147, 73);
            this.settingSaveBtn.TabIndex = 12;
            this.settingSaveBtn.Text = "검증";
            this.settingSaveBtn.UseVisualStyleBackColor = true;
            this.settingSaveBtn.Click += new System.EventHandler(this.settingSaveBtn_ClickAsync);
            // 
            // showMsg
            // 
            this.showMsg.AutoSize = true;
            this.showMsg.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.showMsg.Location = new System.Drawing.Point(120, 201);
            this.showMsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.showMsg.Name = "showMsg";
            this.showMsg.Size = new System.Drawing.Size(0, 19);
            this.showMsg.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(36, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "직원 코드";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(120, 157);
            this.numberTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(168, 21);
            this.numberTextBox.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(298, 157);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "(직원 번호)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 475);
            this.Controls.Add(this.showMsg);
            this.Controls.Add(this.settingSaveBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uuidTextBox);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox uuidTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button settingSaveBtn;
        private System.Windows.Forms.Label showMsg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label label7;
    }
}

