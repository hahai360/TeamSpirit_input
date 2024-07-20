namespace TeamSprit_input
{
    partial class SettingForm
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
            this.userLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userText = new System.Windows.Forms.TextBox();
            this.passText = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.authGroup = new System.Windows.Forms.GroupBox();
            this.workGroup = new System.Windows.Forms.GroupBox();
            this.restEndTime2Text = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.restStartTime2Text = new System.Windows.Forms.TextBox();
            this.restEndTime1Text = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.workPlaceComb = new System.Windows.Forms.ComboBox();
            this.restStartTime1Text = new System.Windows.Forms.TextBox();
            this.endTimeText = new System.Windows.Forms.TextBox();
            this.startTimeText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.browserComb = new System.Windows.Forms.ComboBox();
            this.browserLabel = new System.Windows.Forms.Label();
            this.authGroup.SuspendLayout();
            this.workGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(9, 23);
            this.userLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(35, 12);
            this.userLabel.TabIndex = 0;
            this.userLabel.Text = "ユーザ";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(9, 53);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(52, 12);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "パスワード";
            // 
            // userText
            // 
            this.userText.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.userText.Location = new System.Drawing.Point(62, 18);
            this.userText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(133, 19);
            this.userText.TabIndex = 2;
            this.userText.Text = "AX00000000";
            // 
            // passText
            // 
            this.passText.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.passText.Location = new System.Drawing.Point(62, 47);
            this.passText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passText.Name = "passText";
            this.passText.PasswordChar = '●';
            this.passText.Size = new System.Drawing.Size(133, 19);
            this.passText.TabIndex = 3;
            this.passText.Text = "aaaaaaaaaa";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(148, 279);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(70, 30);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "保存";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(9, 279);
            this.backButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(70, 30);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "戻る";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // authGroup
            // 
            this.authGroup.Controls.Add(this.passText);
            this.authGroup.Controls.Add(this.userLabel);
            this.authGroup.Controls.Add(this.passwordLabel);
            this.authGroup.Controls.Add(this.userText);
            this.authGroup.Location = new System.Drawing.Point(10, 34);
            this.authGroup.Name = "authGroup";
            this.authGroup.Size = new System.Drawing.Size(208, 83);
            this.authGroup.TabIndex = 6;
            this.authGroup.TabStop = false;
            this.authGroup.Text = "認証情報";
            // 
            // workGroup
            // 
            this.workGroup.Controls.Add(this.restEndTime2Text);
            this.workGroup.Controls.Add(this.label9);
            this.workGroup.Controls.Add(this.restStartTime2Text);
            this.workGroup.Controls.Add(this.restEndTime1Text);
            this.workGroup.Controls.Add(this.label8);
            this.workGroup.Controls.Add(this.workPlaceComb);
            this.workGroup.Controls.Add(this.restStartTime1Text);
            this.workGroup.Controls.Add(this.endTimeText);
            this.workGroup.Controls.Add(this.startTimeText);
            this.workGroup.Controls.Add(this.label7);
            this.workGroup.Controls.Add(this.label6);
            this.workGroup.Controls.Add(this.label5);
            this.workGroup.Controls.Add(this.label4);
            this.workGroup.Controls.Add(this.label3);
            this.workGroup.Location = new System.Drawing.Point(10, 122);
            this.workGroup.Name = "workGroup";
            this.workGroup.Size = new System.Drawing.Size(208, 152);
            this.workGroup.TabIndex = 7;
            this.workGroup.TabStop = false;
            this.workGroup.Text = "勤怠情報";
            // 
            // restEndTime2Text
            // 
            this.restEndTime2Text.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.restEndTime2Text.Location = new System.Drawing.Point(145, 96);
            this.restEndTime2Text.MaxLength = 5;
            this.restEndTime2Text.Name = "restEndTime2Text";
            this.restEndTime2Text.Size = new System.Drawing.Size(50, 19);
            this.restEndTime2Text.TabIndex = 9;
            this.restEndTime2Text.Text = "00:00";
            this.restEndTime2Text.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(122, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 13;
            this.label9.Text = "～";
            // 
            // restStartTime2Text
            // 
            this.restStartTime2Text.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.restStartTime2Text.Location = new System.Drawing.Point(62, 96);
            this.restStartTime2Text.MaxLength = 5;
            this.restStartTime2Text.Name = "restStartTime2Text";
            this.restStartTime2Text.Size = new System.Drawing.Size(50, 19);
            this.restStartTime2Text.TabIndex = 8;
            this.restStartTime2Text.Text = "00:00";
            this.restStartTime2Text.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // restEndTime1Text
            // 
            this.restEndTime1Text.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.restEndTime1Text.Location = new System.Drawing.Point(145, 71);
            this.restEndTime1Text.MaxLength = 5;
            this.restEndTime1Text.Name = "restEndTime1Text";
            this.restEndTime1Text.Size = new System.Drawing.Size(50, 19);
            this.restEndTime1Text.TabIndex = 7;
            this.restEndTime1Text.Text = "00:00";
            this.restEndTime1Text.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(122, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "～";
            // 
            // workPlaceComb
            // 
            this.workPlaceComb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workPlaceComb.FormattingEnabled = true;
            this.workPlaceComb.Location = new System.Drawing.Point(62, 121);
            this.workPlaceComb.Name = "workPlaceComb";
            this.workPlaceComb.Size = new System.Drawing.Size(133, 20);
            this.workPlaceComb.TabIndex = 10;
            // 
            // restStartTime1Text
            // 
            this.restStartTime1Text.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.restStartTime1Text.Location = new System.Drawing.Point(62, 71);
            this.restStartTime1Text.MaxLength = 5;
            this.restStartTime1Text.Name = "restStartTime1Text";
            this.restStartTime1Text.Size = new System.Drawing.Size(50, 19);
            this.restStartTime1Text.TabIndex = 6;
            this.restStartTime1Text.Text = "00:00";
            this.restStartTime1Text.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // endTimeText
            // 
            this.endTimeText.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.endTimeText.Location = new System.Drawing.Point(62, 46);
            this.endTimeText.MaxLength = 5;
            this.endTimeText.Name = "endTimeText";
            this.endTimeText.Size = new System.Drawing.Size(50, 19);
            this.endTimeText.TabIndex = 5;
            this.endTimeText.Text = "00:00";
            this.endTimeText.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // startTimeText
            // 
            this.startTimeText.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.startTimeText.Location = new System.Drawing.Point(62, 21);
            this.startTimeText.MaxLength = 5;
            this.startTimeText.Name = "startTimeText";
            this.startTimeText.Size = new System.Drawing.Size(50, 19);
            this.startTimeText.TabIndex = 4;
            this.startTimeText.Text = "00:00";
            this.startTimeText.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "勤務場所";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "休憩２";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "休憩１";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "退社";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "出社";
            // 
            // browserComb
            // 
            this.browserComb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.browserComb.FormattingEnabled = true;
            this.browserComb.Location = new System.Drawing.Point(74, 10);
            this.browserComb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.browserComb.Name = "browserComb";
            this.browserComb.Size = new System.Drawing.Size(132, 20);
            this.browserComb.TabIndex = 1;
            // 
            // browserLabel
            // 
            this.browserLabel.AutoSize = true;
            this.browserLabel.Location = new System.Drawing.Point(18, 12);
            this.browserLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.browserLabel.Name = "browserLabel";
            this.browserLabel.Size = new System.Drawing.Size(41, 12);
            this.browserLabel.TabIndex = 9;
            this.browserLabel.Text = "ブラウザ";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 317);
            this.Controls.Add(this.browserLabel);
            this.Controls.Add(this.browserComb);
            this.Controls.Add(this.workGroup);
            this.Controls.Add(this.authGroup);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.saveButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingForm";
            this.Text = "設定お願いしますm(_ _)m";
            this.authGroup.ResumeLayout(false);
            this.authGroup.PerformLayout();
            this.workGroup.ResumeLayout(false);
            this.workGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox userText;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.GroupBox authGroup;
        private System.Windows.Forms.GroupBox workGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox restStartTime1Text;
        private System.Windows.Forms.TextBox endTimeText;
        private System.Windows.Forms.TextBox startTimeText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox workPlaceComb;
        private System.Windows.Forms.TextBox restEndTime1Text;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox restEndTime2Text;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox restStartTime2Text;
        private System.Windows.Forms.ComboBox browserComb;
        private System.Windows.Forms.Label browserLabel;
    }
}