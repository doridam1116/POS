namespace _2nd_POS.POSUI
{
    partial class WorkControl
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.attendanceOutLabel = new System.Windows.Forms.Label();
            this.attendanceInLabel = new System.Windows.Forms.Label();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.employeeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.timeLabel);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(637, 35);
            this.panel2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼모음T", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "출근/퇴근";
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(648, 10);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 29);
            this.button5.TabIndex = 11;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("휴먼모음T", 20F);
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(305, 55);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 30);
            this.timeLabel.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.MessageLabel);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.attendanceOutLabel);
            this.panel3.Controls.Add(this.attendanceInLabel);
            this.panel3.Controls.Add(this.employeeNameLabel);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.employeeTextBox);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(216, 146);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(638, 435);
            this.panel3.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("굴림", 10F);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(302, 367);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 49);
            this.button2.TabIndex = 22;
            this.button2.Text = "출근 / 퇴근";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MessageLabel
            // 
            this.MessageLabel.BackColor = System.Drawing.Color.White;
            this.MessageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessageLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MessageLabel.Location = new System.Drawing.Point(61, 252);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(521, 88);
            this.MessageLabel.TabIndex = 21;
            this.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("굴림", 10F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(462, 367);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 49);
            this.button3.TabIndex = 1;
            this.button3.Text = "닫기";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // attendanceOutLabel
            // 
            this.attendanceOutLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.attendanceOutLabel.Location = new System.Drawing.Point(219, 202);
            this.attendanceOutLabel.Name = "attendanceOutLabel";
            this.attendanceOutLabel.Size = new System.Drawing.Size(363, 38);
            this.attendanceOutLabel.TabIndex = 20;
            this.attendanceOutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // attendanceInLabel
            // 
            this.attendanceInLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.attendanceInLabel.Location = new System.Drawing.Point(219, 165);
            this.attendanceInLabel.Name = "attendanceInLabel";
            this.attendanceInLabel.Size = new System.Drawing.Size(363, 38);
            this.attendanceInLabel.TabIndex = 19;
            this.attendanceInLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employeeNameLabel.Location = new System.Drawing.Point(219, 128);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(363, 38);
            this.employeeNameLabel.TabIndex = 18;
            this.employeeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(492, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 40);
            this.button1.TabIndex = 17;
            this.button1.Text = "조회";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_ClickAsync);
            // 
            // employeeTextBox
            // 
            this.employeeTextBox.Location = new System.Drawing.Point(219, 79);
            this.employeeTextBox.Multiline = true;
            this.employeeTextBox.Name = "employeeTextBox";
            this.employeeTextBox.Size = new System.Drawing.Size(273, 38);
            this.employeeTextBox.TabIndex = 16;
            this.employeeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("새굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(63, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 38);
            this.label5.TabIndex = 15;
            this.label5.Text = "퇴근시간";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("새굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(63, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 38);
            this.label4.TabIndex = 14;
            this.label4.Text = "출근시간";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("새굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(63, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 38);
            this.label3.TabIndex = 13;
            this.label3.Text = "담당자";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("새굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(63, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 38);
            this.label2.TabIndex = 12;
            this.label2.Text = "ID 카드번호";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WorkControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WorkControl";
            this.Size = new System.Drawing.Size(1024, 768);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label attendanceOutLabel;
        private System.Windows.Forms.Label attendanceInLabel;
        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox employeeTextBox;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
