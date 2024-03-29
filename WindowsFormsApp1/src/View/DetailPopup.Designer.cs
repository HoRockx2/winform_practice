﻿
namespace WindowsFormsApp1
{
    partial class DetailPopup
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
            this.Content = new System.Windows.Forms.Label();
            this.contentTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.commandList = new System.Windows.Forms.TableLayoutPanel();
            this.DetailOKButton = new System.Windows.Forms.Button();
            this.AddCommandListButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Content
            // 
            this.Content.AutoSize = true;
            this.Content.Location = new System.Drawing.Point(12, 58);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(48, 12);
            this.Content.TabIndex = 1;
            this.Content.Text = "Content";
            // 
            // contentTextBox
            // 
            this.contentTextBox.Location = new System.Drawing.Point(12, 77);
            this.contentTextBox.Multiline = true;
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.Size = new System.Drawing.Size(501, 89);
            this.contentTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Title";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(13, 29);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(100, 21);
            this.titleTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Commands";
            // 
            // commandList
            // 
            this.commandList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 501F));
            this.commandList.Location = new System.Drawing.Point(12, 200);
            this.commandList.Name = "commandList";
            this.commandList.Size = new System.Drawing.Size(501, 100);
            this.commandList.TabIndex = 6;
            // 
            // DetailOKButton
            // 
            this.DetailOKButton.Location = new System.Drawing.Point(12, 313);
            this.DetailOKButton.Name = "DetailOKButton";
            this.DetailOKButton.Size = new System.Drawing.Size(75, 23);
            this.DetailOKButton.TabIndex = 4;
            this.DetailOKButton.Text = "&OK";
            this.DetailOKButton.UseVisualStyleBackColor = true;
            this.DetailOKButton.Click += new System.EventHandler(this.OnClickOK);
            // 
            // AddCommandListButton
            // 
            this.AddCommandListButton.Location = new System.Drawing.Point(83, 175);
            this.AddCommandListButton.Name = "AddCommandListButton";
            this.AddCommandListButton.Size = new System.Drawing.Size(22, 21);
            this.AddCommandListButton.TabIndex = 3;
            this.AddCommandListButton.Text = "&+";
            this.AddCommandListButton.UseVisualStyleBackColor = true;
            this.AddCommandListButton.Click += new System.EventHandler(this.OnPlusCommandClick);
            // 
            // DetailPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 348);
            this.Controls.Add(this.AddCommandListButton);
            this.Controls.Add(this.DetailOKButton);
            this.Controls.Add(this.commandList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contentTextBox);
            this.Controls.Add(this.Content);
            this.KeyPreview = true;
            this.Name = "DetailPopup";
            this.Text = "DetailPopup";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnPopupKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Content;
        private System.Windows.Forms.TextBox contentTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel commandList;
        private System.Windows.Forms.Button DetailOKButton;
        private System.Windows.Forms.Button AddCommandListButton;
    }
}