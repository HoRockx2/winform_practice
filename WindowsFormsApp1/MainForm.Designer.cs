
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
            this.searchInputField = new System.Windows.Forms.TextBox();
            this.commandListBox = new System.Windows.Forms.ListBox();
            this.contextMenuStrip.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(104, 48);
            this.contextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OnItemsClicked);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Tag = "CONTEXT_OPEN";
            this.openToolStripMenuItem.Text = "Open";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
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
            this.textChangedDisplay.Location = new System.Drawing.Point(12, 8);
            this.textChangedDisplay.Name = "textChangedDisplay";
            this.textChangedDisplay.Padding = new System.Windows.Forms.Padding(10);
            this.textChangedDisplay.Size = new System.Drawing.Size(60, 34);
            this.textChangedDisplay.TabIndex = 2;
            this.textChangedDisplay.Text = "label1";
            // 
            // FetchTestBtn
            // 
            this.FetchTestBtn.Location = new System.Drawing.Point(441, 16);
            this.FetchTestBtn.Name = "FetchTestBtn";
            this.FetchTestBtn.Size = new System.Drawing.Size(75, 23);
            this.FetchTestBtn.TabIndex = 4;
            this.FetchTestBtn.Text = "Test Fetch";
            this.FetchTestBtn.UseVisualStyleBackColor = true;
            this.FetchTestBtn.Click += new System.EventHandler(this.OnClick);
            // 
            // CreateNewCommandBtn
            // 
            this.CreateNewCommandBtn.Location = new System.Drawing.Point(274, 16);
            this.CreateNewCommandBtn.Name = "CreateNewCommandBtn";
            this.CreateNewCommandBtn.Size = new System.Drawing.Size(161, 23);
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
            this.bottomPanel.Location = new System.Drawing.Point(0, 171);
            this.bottomPanel.Margin = new System.Windows.Forms.Padding(5);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(706, 246);
            this.bottomPanel.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.commandsPanel);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(706, 128);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Commands";
            // 
            // commandsPanel
            // 
            this.commandsPanel.AutoScroll = true;
            this.commandsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 686F));
            this.commandsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandsPanel.Location = new System.Drawing.Point(3, 17);
            this.commandsPanel.Name = "commandsPanel";
            this.commandsPanel.Padding = new System.Windows.Forms.Padding(10);
            this.commandsPanel.Size = new System.Drawing.Size(700, 108);
            this.commandsPanel.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.descriptionTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 67);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Description";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.descriptionTextBox.Location = new System.Drawing.Point(3, 17);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(700, 47);
            this.descriptionTextBox.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CreateNewCommandBtn);
            this.panel1.Controls.Add(this.textChangedDisplay);
            this.panel1.Controls.Add(this.FetchTestBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 51);
            this.panel1.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(706, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.importToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.OnExitMenuClick);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OnAboutClick);
            // 
            // searchInputField
            // 
            this.searchInputField.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchInputField.Location = new System.Drawing.Point(0, 24);
            this.searchInputField.Name = "searchInputField";
            this.searchInputField.Size = new System.Drawing.Size(706, 21);
            this.searchInputField.TabIndex = 7;
            this.searchInputField.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // commandListBox
            // 
            this.commandListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandListBox.FormattingEnabled = true;
            this.commandListBox.ItemHeight = 12;
            this.commandListBox.Location = new System.Drawing.Point(0, 45);
            this.commandListBox.Name = "commandListBox";
            this.commandListBox.Size = new System.Drawing.Size(706, 126);
            this.commandListBox.TabIndex = 8;
            this.commandListBox.SelectedIndexChanged += new System.EventHandler(this.OnCommandListBoxSelectedIndexChanged);
            this.commandListBox.DoubleClick += new System.EventHandler(this.OnCommandListBoxDoubleClick);
            this.commandListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnCommandListBoxKeyDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 417);
            this.Controls.Add(this.commandListBox);
            this.Controls.Add(this.searchInputField);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.bottomPanel);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Title";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.TextBox searchInputField;
        private System.Windows.Forms.ListBox commandListBox;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
    }
}

