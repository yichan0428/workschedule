﻿namespace Work_Schedule
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.QuationMarkButton = new System.Windows.Forms.Button();
            this.MadeTime = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.QuationMark = new System.Windows.Forms.Button();
            this.SalaryButton = new System.Windows.Forms.Button();
            this.TimeButton = new System.Windows.Forms.Button();
            this.ScheduleButton = new System.Windows.Forms.Button();
            this.SettingButton = new System.Windows.Forms.Button();
            this.DesktopPanel = new System.Windows.Forms.Panel();
            this.MinimumButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.SubTitle = new System.Windows.Forms.Label();
            this.home1 = new Work_Schedule.Controls.Home();
            this.scheduleControl1 = new Work_Schedule.ScheduleControl();
            this.settingControl1 = new Work_Schedule.SettingControl();
            this.salaryControl1 = new Work_Schedule.SalaryControl();
            this.timeControl1 = new Work_Schedule.TimeControl();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.DesktopPanel.SuspendLayout();
            this.TitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.QuationMarkButton);
            this.MenuPanel.Controls.Add(this.MadeTime);
            this.MenuPanel.Controls.Add(this.Title);
            this.MenuPanel.Controls.Add(this.pictureBox1);
            this.MenuPanel.Controls.Add(this.SidePanel);
            this.MenuPanel.Controls.Add(this.QuationMark);
            this.MenuPanel.Controls.Add(this.SalaryButton);
            this.MenuPanel.Controls.Add(this.TimeButton);
            this.MenuPanel.Controls.Add(this.ScheduleButton);
            this.MenuPanel.Controls.Add(this.SettingButton);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(150, 851);
            this.MenuPanel.TabIndex = 0;
            // 
            // QuationMarkButton
            // 
            this.QuationMarkButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.QuationMarkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.QuationMarkButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.QuationMarkButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.QuationMarkButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.QuationMarkButton.FlatAppearance.BorderSize = 0;
            this.QuationMarkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuationMarkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuationMarkButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.QuationMarkButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.QuationMarkButton.Location = new System.Drawing.Point(12, 811);
            this.QuationMarkButton.Name = "QuationMarkButton";
            this.QuationMarkButton.Size = new System.Drawing.Size(28, 28);
            this.QuationMarkButton.TabIndex = 1;
            this.QuationMarkButton.Text = "?";
            this.QuationMarkButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.QuationMarkButton.UseVisualStyleBackColor = false;
            this.QuationMarkButton.Click += new System.EventHandler(this.QuationMarkButton_Click);
            // 
            // MadeTime
            // 
            this.MadeTime.AutoSize = true;
            this.MadeTime.Font = new System.Drawing.Font("標楷體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MadeTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.MadeTime.Location = new System.Drawing.Point(80, 141);
            this.MadeTime.Name = "MadeTime";
            this.MadeTime.Size = new System.Drawing.Size(70, 13);
            this.MadeTime.TabIndex = 3;
            this.MadeTime.Text = "ver.1.1.1";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.Title.Location = new System.Drawing.Point(18, 104);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(106, 24);
            this.Title.TabIndex = 0;
            this.Title.Text = "排班系統";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(117)))));
            this.SidePanel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SidePanel.Location = new System.Drawing.Point(143, 230);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(6, 64);
            this.SidePanel.TabIndex = 0;
            // 
            // QuationMark
            // 
            this.QuationMark.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.QuationMark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.QuationMark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.QuationMark.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.QuationMark.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.QuationMark.FlatAppearance.BorderSize = 0;
            this.QuationMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuationMark.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuationMark.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.QuationMark.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.QuationMark.Location = new System.Drawing.Point(12, 888);
            this.QuationMark.Name = "QuationMark";
            this.QuationMark.Size = new System.Drawing.Size(33, 34);
            this.QuationMark.TabIndex = 3;
            this.QuationMark.Text = "?";
            this.QuationMark.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.QuationMark.UseVisualStyleBackColor = false;
            this.QuationMark.Click += new System.EventHandler(this.QuationMark_Click);
            // 
            // SalaryButton
            // 
            this.SalaryButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SalaryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.SalaryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SalaryButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SalaryButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.SalaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalaryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SalaryButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SalaryButton.Image = ((System.Drawing.Image)(resources.GetObject("SalaryButton.Image")));
            this.SalaryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SalaryButton.Location = new System.Drawing.Point(2, 478);
            this.SalaryButton.Name = "SalaryButton";
            this.SalaryButton.Size = new System.Drawing.Size(142, 64);
            this.SalaryButton.TabIndex = 0;
            this.SalaryButton.Text = " 薪資";
            this.SalaryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SalaryButton.UseVisualStyleBackColor = false;
            this.SalaryButton.Click += new System.EventHandler(this.SalaryButton_Click);
            // 
            // TimeButton
            // 
            this.TimeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TimeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.TimeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TimeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.TimeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.TimeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TimeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TimeButton.Image = ((System.Drawing.Image)(resources.GetObject("TimeButton.Image")));
            this.TimeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TimeButton.Location = new System.Drawing.Point(2, 395);
            this.TimeButton.Name = "TimeButton";
            this.TimeButton.Size = new System.Drawing.Size(142, 64);
            this.TimeButton.TabIndex = 0;
            this.TimeButton.Text = " 時間表";
            this.TimeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TimeButton.UseVisualStyleBackColor = false;
            this.TimeButton.Click += new System.EventHandler(this.TimeButton_Click);
            // 
            // ScheduleButton
            // 
            this.ScheduleButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ScheduleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ScheduleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ScheduleButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ScheduleButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ScheduleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScheduleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ScheduleButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ScheduleButton.Image = ((System.Drawing.Image)(resources.GetObject("ScheduleButton.Image")));
            this.ScheduleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ScheduleButton.Location = new System.Drawing.Point(2, 311);
            this.ScheduleButton.Name = "ScheduleButton";
            this.ScheduleButton.Size = new System.Drawing.Size(142, 64);
            this.ScheduleButton.TabIndex = 0;
            this.ScheduleButton.Text = " 班表";
            this.ScheduleButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ScheduleButton.UseVisualStyleBackColor = false;
            this.ScheduleButton.Click += new System.EventHandler(this.ScheduleButton_Click);
            // 
            // SettingButton
            // 
            this.SettingButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SettingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.SettingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SettingButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SettingButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.SettingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SettingButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SettingButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingButton.Image")));
            this.SettingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingButton.Location = new System.Drawing.Point(2, 229);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(142, 64);
            this.SettingButton.TabIndex = 0;
            this.SettingButton.Text = " 勞基法設定";
            this.SettingButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SettingButton.UseVisualStyleBackColor = false;
            this.SettingButton.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // DesktopPanel
            // 
            this.DesktopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.DesktopPanel.Controls.Add(this.home1);
            this.DesktopPanel.Controls.Add(this.scheduleControl1);
            this.DesktopPanel.Controls.Add(this.settingControl1);
            this.DesktopPanel.Controls.Add(this.salaryControl1);
            this.DesktopPanel.Controls.Add(this.timeControl1);
            this.DesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DesktopPanel.Location = new System.Drawing.Point(150, 101);
            this.DesktopPanel.Name = "DesktopPanel";
            this.DesktopPanel.Size = new System.Drawing.Size(1060, 750);
            this.DesktopPanel.TabIndex = 2;
            // 
            // MinimumButton
            // 
            this.MinimumButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MinimumButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.MinimumButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MinimumButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.MinimumButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.MinimumButton.FlatAppearance.BorderSize = 0;
            this.MinimumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MinimumButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MinimumButton.Image = ((System.Drawing.Image)(resources.GetObject("MinimumButton.Image")));
            this.MinimumButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MinimumButton.Location = new System.Drawing.Point(978, 26);
            this.MinimumButton.Name = "MinimumButton";
            this.MinimumButton.Size = new System.Drawing.Size(28, 28);
            this.MinimumButton.TabIndex = 0;
            this.MinimumButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MinimumButton.UseVisualStyleBackColor = false;
            this.MinimumButton.Click += new System.EventHandler(this.MinimumButton_Click);
            // 
            // button5
            // 
            this.button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(1011, 26);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(28, 28);
            this.button5.TabIndex = 0;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.TitlePanel.Controls.Add(this.SubTitle);
            this.TitlePanel.Controls.Add(this.button5);
            this.TitlePanel.Controls.Add(this.MinimumButton);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.Location = new System.Drawing.Point(150, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(1060, 101);
            this.TitlePanel.TabIndex = 1;
            this.TitlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitlePanel_MouseDown);
            this.TitlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitlePanel_MouseMove);
            this.TitlePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitlePanel_MouseUp);
            // 
            // SubTitle
            // 
            this.SubTitle.AutoSize = true;
            this.SubTitle.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(117)))));
            this.SubTitle.Location = new System.Drawing.Point(414, 36);
            this.SubTitle.Name = "SubTitle";
            this.SubTitle.Size = new System.Drawing.Size(31, 32);
            this.SubTitle.TabIndex = 0;
            this.SubTitle.Text = " ";
            this.SubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // home1
            // 
            this.home1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.home1.Location = new System.Drawing.Point(0, 0);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(1060, 814);
            this.home1.TabIndex = 4;
            // 
            // scheduleControl1
            // 
            this.scheduleControl1.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.scheduleControl1.Location = new System.Drawing.Point(0, 0);
            this.scheduleControl1.Name = "scheduleControl1";
            this.scheduleControl1.Size = new System.Drawing.Size(1060, 814);
            this.scheduleControl1.TabIndex = 3;
            // 
            // settingControl1
            // 
            this.settingControl1.Location = new System.Drawing.Point(0, 0);
            this.settingControl1.Name = "settingControl1";
            this.settingControl1.Size = new System.Drawing.Size(1060, 814);
            this.settingControl1.TabIndex = 2;
            // 
            // salaryControl1
            // 
            this.salaryControl1.Location = new System.Drawing.Point(0, 0);
            this.salaryControl1.Name = "salaryControl1";
            this.salaryControl1.Size = new System.Drawing.Size(1060, 814);
            this.salaryControl1.TabIndex = 1;
            // 
            // timeControl1
            // 
            this.timeControl1.Location = new System.Drawing.Point(-161, 0);
            this.timeControl1.Name = "timeControl1";
            this.timeControl1.Size = new System.Drawing.Size(1221, 814);
            this.timeControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1210, 851);
            this.Controls.Add(this.DesktopPanel);
            this.Controls.Add(this.TitlePanel);
            this.Controls.Add(this.MenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.DesktopPanel.ResumeLayout(false);
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button SettingButton;
        private System.Windows.Forms.Panel DesktopPanel;
        private System.Windows.Forms.Button SalaryButton;
        private System.Windows.Forms.Button TimeButton;
        private System.Windows.Forms.Button ScheduleButton;
        private System.Windows.Forms.Button QuationMark;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button MinimumButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel TitlePanel;
        private TimeControl timeControl1;
        private ScheduleControl scheduleControl1;
        private SettingControl settingControl1;
        private System.Windows.Forms.Label MadeTime;
        private System.Windows.Forms.Label SubTitle;
        private System.Windows.Forms.Button QuationMarkButton;
        private Controls.Home home1;
        private SalaryControl salaryControl1;
    }
}

