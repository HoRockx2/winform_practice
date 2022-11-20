namespace WindowsFormsApp1
{
    partial class TaskArchiveListView
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
            this.archiveListView = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Progress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backToTaskListButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // archiveListView
            // 
            this.archiveListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Progress,
            this.StartDate});
            this.archiveListView.FullRowSelect = true;
            this.archiveListView.GridLines = true;
            this.archiveListView.HideSelection = false;
            this.archiveListView.Location = new System.Drawing.Point(12, 12);
            this.archiveListView.Name = "archiveListView";
            this.archiveListView.Size = new System.Drawing.Size(776, 233);
            this.archiveListView.TabIndex = 0;
            this.archiveListView.UseCompatibleStateImageBehavior = false;
            this.archiveListView.View = System.Windows.Forms.View.Details;
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 400;
            // 
            // Progress
            // 
            this.Progress.Text = "Progress";
            this.Progress.Width = 96;
            // 
            // StartDate
            // 
            this.StartDate.Text = "StartDate";
            this.StartDate.Width = 177;
            // 
            // backToTaskListButton
            // 
            this.backToTaskListButton.Location = new System.Drawing.Point(12, 271);
            this.backToTaskListButton.Name = "backToTaskListButton";
            this.backToTaskListButton.Size = new System.Drawing.Size(155, 23);
            this.backToTaskListButton.TabIndex = 1;
            this.backToTaskListButton.Text = "Back To Task List";
            this.backToTaskListButton.UseVisualStyleBackColor = true;
            this.backToTaskListButton.Click += new System.EventHandler(this.OnBackToTaskList);
            // 
            // TaskArchiveListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backToTaskListButton);
            this.Controls.Add(this.archiveListView);
            this.KeyPreview = true;
            this.Name = "TaskArchiveListView";
            this.Text = "TaskArchiveListView";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnFormKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView archiveListView;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Progress;
        private System.Windows.Forms.ColumnHeader StartDate;
        private System.Windows.Forms.Button backToTaskListButton;
    }
}