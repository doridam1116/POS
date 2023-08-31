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
            this.label1 = new System.Windows.Forms.Label();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.uuidTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.settingSaveBtn = new System.Windows.Forms.Button();
            this.showMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(52, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "유형 선택";
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(172, 105);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(238, 28);
            this.typeTextBox.TabIndex = 1;
            // 
            // uuidTextBox
            // 
            this.uuidTextBox.Location = new System.Drawing.Point(172, 173);
            this.uuidTextBox.Name = "uuidTextBox";
            this.uuidTextBox.Size = new System.Drawing.Size(238, 28);
            this.uuidTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(52, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "UUID";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(172, 236);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(238, 28);
            this.numberTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(52, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "직원 코드";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(52, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Message : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(425, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "(0, 1)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(425, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 28);
            this.label7.TabIndex = 10;
            this.label7.Text = "(직원 번호)";
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.startBtn.Location = new System.Drawing.Point(750, 248);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(210, 109);
            this.startBtn.TabIndex = 11;
            this.startBtn.Text = "시작";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // settingSaveBtn
            // 
            this.settingSaveBtn.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.settingSaveBtn.Location = new System.Drawing.Point(750, 92);
            this.settingSaveBtn.Name = "settingSaveBtn";
            this.settingSaveBtn.Size = new System.Drawing.Size(210, 109);
            this.settingSaveBtn.TabIndex = 12;
            this.settingSaveBtn.Text = "저장";
            this.settingSaveBtn.UseVisualStyleBackColor = true;
            this.settingSaveBtn.Click += new System.EventHandler(this.settingSaveBtn_Click);
            // 
            // showMsg
            // 
            this.showMsg.AutoSize = true;
            this.showMsg.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.showMsg.Location = new System.Drawing.Point(172, 302);
            this.showMsg.Name = "showMsg";
            this.showMsg.Size = new System.Drawing.Size(0, 28);
            this.showMsg.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 712);
            this.Controls.Add(this.showMsg);
            this.Controls.Add(this.settingSaveBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uuidTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox uuidTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button settingSaveBtn;
        private System.Windows.Forms.Label showMsg;
    }
}

