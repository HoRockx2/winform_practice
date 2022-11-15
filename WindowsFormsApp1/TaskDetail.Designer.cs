namespace WindowsFormsApp1
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // createDateTimePicker
            // 
            this.createDateTimePicker.Location = new System.Drawing.Point(479, 48);
            this.createDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createDateTimePicker.Name = "createDateTimePicker";
            this.createDateTimePicker.Size = new System.Drawing.Size(228, 25);
            this.createDateTimePicker.TabIndex = 4;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(48, 48);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(259, 25);
            this.titleTextBox.TabIndex = 2;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(48, 149);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(821, 331);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(49, 488);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(86, 29);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "&Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.OnSaveButtonClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Create Date";
            // 
            // progressComboBox
            // 
            this.progressComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.progressComboBox.FormattingEnabled = true;
            this.progressComboBox.Location = new System.Drawing.Point(480, 106);
            this.progressComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressComboBox.Name = "progressComboBox";
            this.progressComboBox.Size = new System.Drawing.Size(242, 23);
            this.progressComboBox.TabIndex = 6;
            // 
            // TaskDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.Controls.Add(this.progressComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.createDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TaskDetail";
            this.Text = "TaskDetail";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
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
    }
}