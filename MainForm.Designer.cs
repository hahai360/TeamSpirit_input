namespace TeamSprit_input
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainManu = new System.Windows.Forms.MenuStrip();
            this.SettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleRegistButton = new System.Windows.Forms.Button();
            this.dateComb = new System.Windows.Forms.ComboBox();
            this.isClearCheck = new System.Windows.Forms.CheckBox();
            this.mainManu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainManu
            // 
            this.mainManu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainManu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingToolStripMenuItem});
            this.mainManu.Location = new System.Drawing.Point(0, 0);
            this.mainManu.Name = "mainManu";
            this.mainManu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mainManu.Size = new System.Drawing.Size(337, 28);
            this.mainManu.TabIndex = 0;
            this.mainManu.Text = "menuStrip1";
            // 
            // SettingToolStripMenuItem
            // 
            this.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem";
            this.SettingToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.SettingToolStripMenuItem.Text = "設定";
            this.SettingToolStripMenuItem.Click += new System.EventHandler(this.SettingToolStripMenuItem_Click);
            // 
            // scheduleRegistButton
            // 
            this.scheduleRegistButton.Location = new System.Drawing.Point(209, 60);
            this.scheduleRegistButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scheduleRegistButton.Name = "scheduleRegistButton";
            this.scheduleRegistButton.Size = new System.Drawing.Size(116, 30);
            this.scheduleRegistButton.TabIndex = 1;
            this.scheduleRegistButton.Text = "一括予定登録";
            this.scheduleRegistButton.UseVisualStyleBackColor = true;
            this.scheduleRegistButton.Click += new System.EventHandler(this.ScheduleRegisterButton_Click);
            // 
            // dateComb
            // 
            this.dateComb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dateComb.FormattingEnabled = true;
            this.dateComb.Location = new System.Drawing.Point(14, 65);
            this.dateComb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateComb.Name = "dateComb";
            this.dateComb.Size = new System.Drawing.Size(169, 23);
            this.dateComb.TabIndex = 3;
            // 
            // isClearCheck
            // 
            this.isClearCheck.AutoSize = true;
            this.isClearCheck.Location = new System.Drawing.Point(14, 36);
            this.isClearCheck.Name = "isClearCheck";
            this.isClearCheck.Size = new System.Drawing.Size(211, 19);
            this.isClearCheck.TabIndex = 4;
            this.isClearCheck.Text = "登録をクリアする？(ﾉД`)ｼｸｼｸ";
            this.isClearCheck.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 99);
            this.Controls.Add(this.isClearCheck);
            this.Controls.Add(this.dateComb);
            this.Controls.Add(this.scheduleRegistButton);
            this.Controls.Add(this.mainManu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainManu;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "予定をいれるのがめんどくさい(TдT)";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainManu.ResumeLayout(false);
            this.mainManu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainManu;
        private System.Windows.Forms.ToolStripMenuItem SettingToolStripMenuItem;
        private System.Windows.Forms.Button scheduleRegistButton;
        private System.Windows.Forms.ComboBox dateComb;
        private System.Windows.Forms.CheckBox isClearCheck;
    }
}

