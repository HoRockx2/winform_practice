
namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.textChangedDisplay = new System.Windows.Forms.Label();
            this.FetchTestBtn = new System.Windows.Forms.Button();
            this.CreateNewCommandBtn = new System.Windows.Forms.Button();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.commandsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openGithubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandNTipSearchInputField = new System.Windows.Forms.TextBox();
            this.commandListBox = new System.Windows.Forms.ListBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.commandAndTipTabPage = new System.Windows.Forms.TabPage();
            this.taskTabPage = new System.Windows.Forms.TabPage();
            this.taskListView = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Progress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.taskSearchInputField = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.addTask = new System.Windows.Forms.Button();
            this.goToArchive = new System.Windows.Forms.Button();
            this.showArchiveButton = new System.Windows.Forms.Button();
            this.contextMenuStrip.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.commandAndTipTabPage.SuspendLayout();
            this.taskTabPage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(117, 52);
            this.contextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OnItemsClicked);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.openToolStripMenuItem.Tag = "CONTEXT_OPEN";
            this.openToolStripMenuItem.Text = "Open";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.exitToolStripMenuItem.Tag = "CONTEXT_EXIT";
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnTrayMouseDoubleClick);
            // 
            // textChangedDisplay
            // 
            this.textChangedDisplay.AutoSize = true;
            this.textChangedDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.textChangedDisplay.Location = new System.Drawing.Point(14, 10);
            this.textChangedDisplay.Name = "textChangedDisplay";
            this.textChangedDisplay.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.textChangedDisplay.Size = new System.Drawing.Size(69, 41);
            this.textChangedDisplay.TabIndex = 2;
            this.textChangedDisplay.Text = "label1";
            // 
            // FetchTestBtn
            // 
            this.FetchTestBtn.Location = new System.Drawing.Point(504, 20);
            this.FetchTestBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FetchTestBtn.Name = "FetchTestBtn";
            this.FetchTestBtn.Size = new System.Drawing.Size(86, 29);
            this.FetchTestBtn.TabIndex = 4;
            this.FetchTestBtn.Text = "Test Fetch";
            this.FetchTestBtn.UseVisualStyleBackColor = true;
            this.FetchTestBtn.Click += new System.EventHandler(this.OnClick);
            // 
            // CreateNewCommandBtn
            // 
            this.CreateNewCommandBtn.Location = new System.Drawing.Point(313, 20);
            this.CreateNewCommandBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CreateNewCommandBtn.Name = "CreateNewCommandBtn";
            this.CreateNewCommandBtn.Size = new System.Drawing.Size(184, 29);
            this.CreateNewCommandBtn.TabIndex = 3;
            this.CreateNewCommandBtn.Text = "&Create new command";
            this.CreateNewCommandBtn.UseVisualStyleBackColor = true;
            this.CreateNewCommandBtn.Click += new System.EventHandler(this.OnDetailPopupButtonClick);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.groupBox2);
            this.bottomPanel.Controls.Add(this.groupBox1);
            this.bottomPanel.Controls.Add(this.panel1);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(3, 332);
            this.bottomPanel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1037, 308);
            this.bottomPanel.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.commandsPanel);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 84);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1037, 160);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Commands";
            // 
            // commandsPanel
            // 
            this.commandsPanel.AutoScroll = true;
            this.commandsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1009F));
            this.commandsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandsPanel.Location = new System.Drawing.Point(3, 22);
            this.commandsPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.commandsPanel.Name = "commandsPanel";
            this.commandsPanel.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.commandsPanel.Size = new System.Drawing.Size(1031, 134);
            this.commandsPanel.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.descriptionTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1037, 84);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Description";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.descriptionTextBox.Location = new System.Drawing.Point(3, 22);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(1031, 58);
            this.descriptionTextBox.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CreateNewCommandBtn);
            this.panel1.Controls.Add(this.textChangedDisplay);
            this.panel1.Controls.Add(this.FetchTestBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 244);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1037, 64);
            this.panel1.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1051, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(63, 26);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.importToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.OnExitMenuClick);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.openGithubToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OnAboutClick);
            // 
            // openGithubToolStripMenuItem
            // 
            this.openGithubToolStripMenuItem.Name = "openGithubToolStripMenuItem";
            this.openGithubToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.openGithubToolStripMenuItem.Text = "Open Github";
            this.openGithubToolStripMenuItem.Click += new System.EventHandler(this.OnClickOpenGithub);
            // 
            // commandNTipSearchInputField
            // 
            this.commandNTipSearchInputField.Dock = System.Windows.Forms.DockStyle.Top;
            this.commandNTipSearchInputField.Location = new System.Drawing.Point(3, 4);
            this.commandNTipSearchInputField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.commandNTipSearchInputField.Name = "commandNTipSearchInputField";
            this.commandNTipSearchInputField.Size = new System.Drawing.Size(1037, 25);
            this.commandNTipSearchInputField.TabIndex = 7;
            this.commandNTipSearchInputField.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // commandListBox
            // 
            this.commandListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandListBox.FormattingEnabled = true;
            this.commandListBox.ItemHeight = 15;
            this.commandListBox.Location = new System.Drawing.Point(3, 29);
            this.commandListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.commandListBox.Name = "commandListBox";
            this.commandListBox.Size = new System.Drawing.Size(1037, 303);
            this.commandListBox.TabIndex = 8;
            this.commandListBox.SelectedIndexChanged += new System.EventHandler(this.OnCommandListBoxSelectedIndexChanged);
            this.commandListBox.DoubleClick += new System.EventHandler(this.OnCommandListBoxDoubleClick);
            this.commandListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnCommandListBoxKeyDown);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.commandAndTipTabPage);
            this.tabControl.Controls.Add(this.taskTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 30);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1051, 671);
            this.tabControl.TabIndex = 9;
            // 
            // commandAndTipTabPage
            // 
            this.commandAndTipTabPage.Controls.Add(this.commandListBox);
            this.commandAndTipTabPage.Controls.Add(this.commandNTipSearchInputField);
            this.commandAndTipTabPage.Controls.Add(this.bottomPanel);
            this.commandAndTipTabPage.Location = new System.Drawing.Point(4, 25);
            this.commandAndTipTabPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.commandAndTipTabPage.Name = "commandAndTipTabPage";
            this.commandAndTipTabPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.commandAndTipTabPage.Size = new System.Drawing.Size(1043, 644);
            this.commandAndTipTabPage.TabIndex = 0;
            this.commandAndTipTabPage.Text = "Commands&Tip";
            this.commandAndTipTabPage.UseVisualStyleBackColor = true;
            // 
            // taskTabPage
            // 
            this.taskTabPage.Controls.Add(this.taskListView);
            this.taskTabPage.Controls.Add(this.taskSearchInputField);
            this.taskTabPage.Controls.Add(this.groupBox3);
            this.taskTabPage.Location = new System.Drawing.Point(4, 25);
            this.taskTabPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.taskTabPage.Name = "taskTabPage";
            this.taskTabPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.taskTabPage.Size = new System.Drawing.Size(1043, 642);
            this.taskTabPage.TabIndex = 1;
            this.taskTabPage.Text = "Tasks";
            this.taskTabPage.UseVisualStyleBackColor = true;
            this.taskTabPage.Enter += new System.EventHandler(this.OnEnterTasksTabPage);
            // 
            // taskListView
            // 
            this.taskListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Progress,
            this.StartDate});
            this.taskListView.FullRowSelect = true;
            this.taskListView.GridLines = true;
            this.taskListView.HideSelection = false;
            this.taskListView.Location = new System.Drawing.Point(8, 72);
            this.taskListView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.taskListView.Name = "taskListView";
            this.taskListView.Size = new System.Drawing.Size(1027, 435);
            this.taskListView.TabIndex = 2;
            this.taskListView.UseCompatibleStateImageBehavior = false;
            this.taskListView.View = System.Windows.Forms.View.Details;
            this.taskListView.DoubleClick += new System.EventHandler(this.OnTaskListDoubleClick);
            this.taskListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnTaskListViewKeyDown);
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
            // taskSearchInputField
            // 
            this.taskSearchInputField.Location = new System.Drawing.Point(382, 21);
            this.taskSearchInputField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.taskSearchInputField.Name = "taskSearchInputField";
            this.taskSearchInputField.Size = new System.Drawing.Size(245, 25);
            this.taskSearchInputField.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.showArchiveButton);
            this.groupBox3.Controls.Add(this.goToArchive);
            this.groupBox3.Controls.Add(this.addTask);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(3, 513);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(1037, 125);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Control Panel";
            // 
            // addTask
            // 
            this.addTask.Location = new System.Drawing.Point(6, 26);
            this.addTask.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addTask.Name = "addTask";
            this.addTask.Size = new System.Drawing.Size(86, 29);
            this.addTask.TabIndex = 0;
            this.addTask.Text = "&Add Task";
            this.addTask.UseVisualStyleBackColor = true;
            this.addTask.Click += new System.EventHandler(this.OnAddTaskButton);
            // 
            // goToArchive
            // 
            this.goToArchive.Location = new System.Drawing.Point(210, 32);
            this.goToArchive.Name = "goToArchive";
            this.goToArchive.Size = new System.Drawing.Size(120, 23);
            this.goToArchive.TabIndex = 1;
            this.goToArchive.Text = "Go to Archive";
            this.goToArchive.UseVisualStyleBackColor = true;
            this.goToArchive.Click += new System.EventHandler(this.OnGoToArchive);
            // 
            // showArchiveButton
            // 
            this.showArchiveButton.Location = new System.Drawing.Point(379, 32);
            this.showArchiveButton.Name = "showArchiveButton";
            this.showArchiveButton.Size = new System.Drawing.Size(117, 23);
            this.showArchiveButton.TabIndex = 2;
            this.showArchiveButton.Text = "Show Archive";
            this.showArchiveButton.UseVisualStyleBackColor = true;
            this.showArchiveButton.Click += new System.EventHandler(this.OnShowArchiveButton);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 701);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Title";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnFormKeyDown);
            this.contextMenuStrip.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.commandAndTipTabPage.ResumeLayout(false);
            this.commandAndTipTabPage.PerformLayout();
            this.taskTabPage.ResumeLayout(false);
            this.taskTabPage.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Label textChangedDisplay;
        private System.Windows.Forms.Button FetchTestBtn;
        private System.Windows.Forms.Button CreateNewCommandBtn;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TableLayoutPanel commandsPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox commandNTipSearchInputField;
        private System.Windows.Forms.ListBox commandListBox;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage commandAndTipTabPage;
        private System.Windows.Forms.TabPage taskTabPage;
        private System.Windows.Forms.TextBox taskSearchInputField;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button addTask;
        private System.Windows.Forms.ListView taskListView;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Progress;
        private System.Windows.Forms.ColumnHeader StartDate;
        private System.Windows.Forms.ToolStripMenuItem openGithubToolStripMenuItem;
        private System.Windows.Forms.Button goToArchive;
        private System.Windows.Forms.Button showArchiveButton;
    }
}

