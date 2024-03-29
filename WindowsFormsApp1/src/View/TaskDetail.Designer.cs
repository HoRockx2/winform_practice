﻿namespace WindowsFormsApp1
{
    partial class TaskDetail
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.createDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.progressComboBox = new System.Windows.Forms.ComboBox();
            this.rateOfProgressTrackBar = new System.Windows.Forms.TrackBar();
            this.slideValueTextLabel = new System.Windows.Forms.Label();
            this.reportedCheckBox = new System.Windows.Forms.CheckBox();
            this.importantTrackBar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.optionalTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rateOfProgressTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importantTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // createDateTimePicker
            // 
            this.createDateTimePicker.Location = new System.Drawing.Point(419, 38);
            this.createDateTimePicker.Name = "createDateTimePicker";
            this.createDateTimePicker.Size = new System.Drawing.Size(200, 21);
            this.createDateTimePicker.TabIndex = 4;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(42, 38);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(301, 21);
            this.titleTextBox.TabIndex = 2;
            this.titleTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnTextBoxKeyDown);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(42, 119);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(719, 266);
            this.descriptionTextBox.TabIndex = 3;
            this.descriptionTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnTextBoxKeyDown);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(42, 401);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "&Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.OnSaveButtonClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Create Date";
            // 
            // progressComboBox
            // 
            this.progressComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.progressComboBox.FormattingEnabled = true;
            this.progressComboBox.Location = new System.Drawing.Point(420, 85);
            this.progressComboBox.Name = "progressComboBox";
            this.progressComboBox.Size = new System.Drawing.Size(212, 20);
            this.progressComboBox.TabIndex = 6;
            this.progressComboBox.SelectedIndexChanged += new System.EventHandler(this.OnComboBoxChanged);
            // 
            // rateOfProgressTrackBar
            // 
            this.rateOfProgressTrackBar.LargeChange = 1;
            this.rateOfProgressTrackBar.Location = new System.Drawing.Point(247, 401);
            this.rateOfProgressTrackBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rateOfProgressTrackBar.Name = "rateOfProgressTrackBar";
            this.rateOfProgressTrackBar.Size = new System.Drawing.Size(241, 45);
            this.rateOfProgressTrackBar.TabIndex = 8;
            this.rateOfProgressTrackBar.ValueChanged += new System.EventHandler(this.OnSlideValueChanged);
            // 
            // slideValueTextLabel
            // 
            this.slideValueTextLabel.AutoSize = true;
            this.slideValueTextLabel.Location = new System.Drawing.Point(501, 412);
            this.slideValueTextLabel.Name = "slideValueTextLabel";
            this.slideValueTextLabel.Size = new System.Drawing.Size(38, 12);
            this.slideValueTextLabel.TabIndex = 9;
            this.slideValueTextLabel.Text = "label4";
            // 
            // reportedCheckBox
            // 
            this.reportedCheckBox.AutoSize = true;
            this.reportedCheckBox.Location = new System.Drawing.Point(597, 411);
            this.reportedCheckBox.Name = "reportedCheckBox";
            this.reportedCheckBox.Size = new System.Drawing.Size(74, 16);
            this.reportedCheckBox.TabIndex = 10;
            this.reportedCheckBox.Text = "Reported";
            this.reportedCheckBox.UseVisualStyleBackColor = true;
            this.reportedCheckBox.CheckedChanged += new System.EventHandler(this.OnReportedCheckChanged);
            // 
            // importantTrackBar
            // 
            this.importantTrackBar.LargeChange = 1;
            this.importantTrackBar.Location = new System.Drawing.Point(247, 451);
            this.importantTrackBar.Name = "importantTrackBar";
            this.importantTrackBar.Size = new System.Drawing.Size(241, 45);
            this.importantTrackBar.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "진행도";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 462);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "중요도";
            // 
            // optionalTextBox
            // 
            this.optionalTextBox.Location = new System.Drawing.Point(158, 65);
            this.optionalTextBox.Name = "optionalTextBox";
            this.optionalTextBox.Size = new System.Drawing.Size(185, 21);
            this.optionalTextBox.TabIndex = 13;
            this.optionalTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnTextBoxKeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "Optional Text";
            // 
            // TaskDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.optionalTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.importantTrackBar);
            this.Controls.Add(this.reportedCheckBox);
            this.Controls.Add(this.slideValueTextLabel);
            this.Controls.Add(this.rateOfProgressTrackBar);
            this.Controls.Add(this.progressComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.createDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "TaskDetail";
            this.Text = "TaskDetail";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.rateOfProgressTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importantTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker createDateTimePicker;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox progressComboBox;
        private System.Windows.Forms.TrackBar rateOfProgressTrackBar;
        private System.Windows.Forms.Label slideValueTextLabel;
        private System.Windows.Forms.CheckBox reportedCheckBox;
        private System.Windows.Forms.TrackBar importantTrackBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox optionalTextBox;
        private System.Windows.Forms.Label label6;
    }
}