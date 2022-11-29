using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp1.interop;
using WindowsFormsApp1.model;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using UtilityModule;
using System.Reflection;
using System.Diagnostics;
using WindowsFormsApp1.viewModel;
using System.Linq;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        private bool isNeedToExit = false;
        private UtilityModule.KeyEventHandler keyEventHandler = null;
        private Fetch fetch;
        private List<DetailModel> commandList = new List<DetailModel>();
        private List<Tuple<int, string>> searchResult = new List<Tuple<int, string>>();
        private FileIO<DetailModel> fileIO = new FileIO<DetailModel>(Assembly.GetExecutingAssembly().GetName().Name, "commands.dat");
        private List<TableLayoutPanel> commandTextLayoutList = new List<TableLayoutPanel>();
        private List<TextBox> commandTextBoxList = new List<TextBox>();
        private const string COMMAND_CONTROL_NAME_PREFIX = "command";
        private IntPtr topWindowHandler = IntPtr.Zero;
        delegate void DetailPopupOKResultHandelr(DetailModel result);

        private TaskViewModel taskViewModel;

        public MainForm()
        {
            InitializeComponent();

            this.Text = AssemblyGetter.GetTitle();

            keyEventHandler = new UtilityModule.KeyEventHandler();
            RegisterHotKey();

            fetch = new Fetch();
            taskViewModel = new TaskViewModel();
            taskViewModel.OnTaskListChanged += OnTaskListChanged;

            LoadData();
            PrintCommandList();


            Application.ApplicationExit += Application_ApplicationExit;
        }

        private void SetTopWindow(IntPtr handle)
        {
            Logger.Start();

            topWindowHandler = handle;
        }

        protected override void OnShown(EventArgs e)
        {
            Logger.Start();

            base.OnShown(e);

            if(commandNTipSearchInputField.Text.Length == 0)
            {
                ShowAllCommandList();
            }

            SetTopWindow(this.Handle);
        }

        private void LoadData()
        {
            Logger.Start();

            var stringData = fileIO.LoadData();

            if (!string.IsNullOrWhiteSpace(stringData))
            {
                commandList = JsonConvert.DeserializeObject<List<DetailModel>>(stringData);
            }

            taskViewModel.LoadData();
        }

        private void PrintCommandList()
        {
            var strBuilder = new StringBuilder();

            strBuilder.AppendLine($"{commandList.Count} commands are exist!");

            foreach(var detailModel in commandList)
            {
                strBuilder.AppendLine(JsonConvert.SerializeObject(detailModel));
            }

            Logger.Info(strBuilder.ToString());
        }

        private void Application_ApplicationExit(object sender, EventArgs e) // it seems that it's not invoked when Envrinment.Exit(0)
        {
            Logger.Start();

            keyEventHandler.UnregisterHotKey(this);
            notifyIcon.Dispose();
        }

        private void RegisterHotKey()
        {
            Logger.Start();

            Keys key = Keys.Space | Keys.Control | Keys.Shift;
            keyEventHandler.RegisterHotKey(this, key);
        }

        protected override void WndProc(ref Message m)
        {
            if(m.Msg == InteropUser32.WM_QUERYENDSESSION)
            {
                Logger.Info("m.Msg is InteropUser32.WM_QUERYENDSESSION");
                isNeedToExit = true;
            }
            else if(m.Msg == InteropUser32.WM_HOTKEY)
            {
                ProcessHotKey(m);
            }

            base.WndProc(ref m);
        }

        private void ProcessHotKey(Message m)
        {
            Logger.Start();

            int keyCode = Utils.HIWORD(m.LParam);

            if ((InteropUser32.MOD_CONTROL | InteropUser32.MOD_SHIFT) == Utils.LOWORD(m.LParam))
            {
                if ((int)Keys.Space == keyCode)
                {
                    Logger.Info("Catch HotKey!");
                    HotKeyHandler();
                }
            }
        }

        private void HotKeyHandler()
        {
            Logger.Start();

            if (!Utils.IsForeground(topWindowHandler))
            {
                SetTopWindowAsForeground();
            }
        }

        private void OnTrayMouseDoubleClick(object sender, MouseEventArgs e)
        {
            Logger.Start();

            if(!Utils.IsForeground(this.Handle)) // is it always true?
            {
                SetTopWindowAsForeground();
            }
        }

        private void SetTopWindowAsForeground()
        {
            Logger.Start();

            this.Visible = true;
            this.TopMost = true;
            this.TopMost = false;

            InteropUser32.SetForegroundWindow(topWindowHandler);

            if(topWindowHandler == this.Handle)
            {
                // TODO: 
                var selectedTab = tabControl.SelectedTab;
                if (selectedTab == commandAndTipTabPage)
                {
                    commandNTipSearchInputField.Focus();

                }
                else if(selectedTab == taskTabPage)
                {

                }
            }
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            Logger.Start();

            if (isNeedToExit)
            {
                Logger.Info("Exit application");
                e.Cancel = false;
            }

            Logger.Info("Just hide");
            e.Cancel = true;
            this.Visible = false;
        }

        private void ExitProgram()
        {
            Logger.Start();

            isNeedToExit = true;
            Environment.Exit(0); // it's not calling OnFormClosing... 
        }

        private void OnItemsClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Logger.Start();

            switch (e.ClickedItem.Tag){
                case "CONTEXT_EXIT":
                    ExitProgram();
                    break;
                case "CONTEXT_OPEN":
                    SetTopWindowAsForeground();
                    break;
            }
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            Logger.Info((sender is TextBox).ToString());

            string searchText = (sender as TextBox).Text;

            textChangedDisplay.Text = searchText;

            if(searchText.Length == 0)
            {
                ShowAllCommandList();
            }
            else
            {
                Regex rx = new Regex(searchText, RegexOptions.IgnoreCase | RegexOptions.Compiled);

                //var results = commandList.Where(s => rx.IsMatch(s.Title));
                commandListBox.Items.Clear();
                searchResult.Clear();

                for(int i = 0; i < commandList.Count; i++)
                {
                    if(rx.IsMatch( commandList[i].Title ))
                    {
                        searchResult.Add(new Tuple<int, string>(i, commandList[i].Title));
                    }
                }

                ReflectSearchResultToCommandListBox();
            }
        }

        private void ShowAllCommandList()
        {
            Logger.Info();

            commandListBox.Items.Clear();
            searchResult.Clear();

            int i = 0; 

            foreach(var command in commandList)
            {
                searchResult.Add(new Tuple<int, string> (i++, command.Title));
            }

            ReflectSearchResultToCommandListBox();
        }

        private void ReflectSearchResultToCommandListBox()
        {
            Logger.Info();

            foreach(var searchItem in searchResult)
            {
                commandListBox.Items.Add(searchItem.Item2);
            }
        }

        private void OnClick(object sender, EventArgs e)
        {
            Logger.Start("Block");

            fetch.FetchData();
        }

        private void ShowDetailPopup(DetailPopupOKResultHandelr retOKHandler, DetailModel existedDetailModel = null)
        {
            Logger.Start();

            using (var detailPopup = new DetailPopup(existedDetailModel))
            {
                SetTopWindow(detailPopup.Handle);
                DialogResult dialogResult = detailPopup.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    Logger.Info("dialog result is ok");
                    retOKHandler?.Invoke(detailPopup.ResultModel);
                }
                else if (dialogResult == DialogResult.Cancel)
                {
                    Logger.Info("dialog result is cancel");
                }

                SetTopWindow(this.Handle);
            }
        }

        private void ShowTaskDetailPopupWithModel(int index)
        {
            Logger.Start();

            var taskDetail = taskViewModel.GetTaskAt(index);
            ShowTaskDetailPopup((retModel) =>
            {
                taskViewModel.OnOKResultOfTaskDetailPopup(retModel, index);
            }, taskDetail);
        }

        private void ShowTaskDetailPopup(TaskDetailPopupOKResultHandler retOKhandler, TaskModel existedTaskModel = null)
        {
            Logger.Start();

            using(var taskDetailPopup = new TaskDetail(existedTaskModel))
            {
                SetTopWindow(taskDetailPopup.Handle);
                var ret = taskDetailPopup.ShowDialog();

                switch (ret) {
                    case DialogResult.OK:
                        Logger.Info("task detail dialog result is ok");
                        retOKhandler?.Invoke(taskDetailPopup.ResultModel);
                        break;
                }

                SetTopWindow(this.Handle);
            }
        }

        private void ShowCreateNewCommandPopup()
        {
            Logger.Start();

            ShowDetailPopup((retModel) =>
            {
                AddCommandList(retModel);
            });
        }

        private void OnDetailPopupButtonClick(object sender, EventArgs e)
        {
            Logger.Start();

            ShowCreateNewCommandPopup();
        }

        private void AddCommandList(DetailModel newModel)
        {
            Logger.Start();

            commandList.Add(newModel);
            NotifyCommandListChanged();

            //ResetMainFormUI();
            //UpdateDictionary();
        }

        private void ResetCommandsAndTipView()
        {
            Logger.Start();

            commandNTipSearchInputField.Text = "";
            ShowAllCommandList();

            descriptionTextBox.Text = "";
            commandsPanel.Controls.Clear();
        }

        private void NotifyCommandListChanged()
        {
            Logger.Start();

            fileIO.SaveDataAsync(commandList);

            ResetCommandsAndTipView();
        }

        private void OnTaskListChanged(object sender, EventArgs e)
        {
            Logger.Start();

            ResetTaskListView();
        }

        private void OnCommandListBoxKeyDown(object sender, KeyEventArgs e)
        {
            Logger.Start();

            if(e.KeyCode == Keys.Enter)
            {
                ShowDetailPopupWithDetailModel(commandListBox.SelectedIndex);
            }
        }

        private void OnTaskListViewKeyDown(object sender, KeyEventArgs e)
        {
            Logger.Start();

            if(e.KeyCode == Keys.Enter)
            {
                ShowTaskDetailFromTaskList();
            }
        }

        private void ShowDetailPopupWithDetailModel(int indexOfCommandListBox)
        {
            Logger.Start();

            if(indexOfCommandListBox < 0)
            {
                Logger.Info($"index error : [{indexOfCommandListBox}]");
                return;
            }

            int indexOfCommandList = searchResult[indexOfCommandListBox].Item1;

            ShowDetailPopup((retModel) =>
            {
                commandList[indexOfCommandList] = retModel;
                NotifyCommandListChanged();
            }, commandList[indexOfCommandList]);
        }

        private void OnCommandListBoxDoubleClick(object sender, EventArgs e)
        {
            Logger.Start();

            Point doubleClickPoint = (e as MouseEventArgs).Location;
            int clickedIndex = commandListBox.IndexFromPoint(doubleClickPoint);

            if(clickedIndex != -1)
            {
                ShowDetailPopupWithDetailModel(clickedIndex);
            }
        }

        private void OnTaskListDoubleClick(object sender, EventArgs e)
        {
            Logger.Start();

            ShowTaskDetailFromTaskList();
        }

        private void ShowTaskDetailFromTaskList()
        {
            Logger.Start();

            var indices = taskListView.SelectedIndices;

            if (indices.Count == 1)
            {
                ShowTaskDetailPopupWithModel(indices[0]);
            }
        }

        private void OnCommandListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            Logger.Start();

            if(commandListBox.SelectedIndex < 0)
            {
                return;
            }

            var commandModel = commandList[searchResult[commandListBox.SelectedIndex].Item1];

            descriptionTextBox.Text = commandModel.Description;


            commandTextBoxList.Clear(); // is it ok that included controls will be desctroy automatically?
            commandTextLayoutList.Clear();
            commandsPanel.Controls.Clear();

            if(commandModel.Commands.Count == 0)
            {
                return;
            }

            foreach(var command in commandModel.Commands)
            {
                var newCommandPanel = new TableLayoutPanel();
                newCommandPanel.Dock = DockStyle.Fill;
                newCommandPanel.ColumnCount = 2;
                newCommandPanel.AutoSize = true;
                newCommandPanel.Padding = new Padding(0, 0, 10, 0);

                var newCommandLabel = new Label();
                newCommandLabel.Text = (commandTextBoxList.Count + 1).ToString();
                newCommandLabel.Width = 20;
                //newCommandLabel.Dock = DockStyle.Left;

                var newCommandTextBox = new TextBox();
                newCommandTextBox.Name = COMMAND_CONTROL_NAME_PREFIX + commandTextBoxList.Count;
                newCommandTextBox.Dock = DockStyle.Fill;
                newCommandTextBox.Text = command;
                newCommandTextBox.ReadOnly = true;

                newCommandPanel.Controls.Add(newCommandLabel);
                newCommandPanel.Controls.Add(newCommandTextBox);

                commandTextLayoutList.Add(newCommandPanel);
                commandTextBoxList.Add(newCommandTextBox);
                commandsPanel.Controls.Add(newCommandPanel);
            }
        }

        private void OnFormKeyDown(object sender, KeyEventArgs e)
        {
            Logger.Start();

            if (e.Modifiers == Keys.Control && (Keys.D1 <= e.KeyCode && e.KeyCode <= Keys.D9))
            {
                Logger.Info(e.KeyCode.ToString());

                CopyCommand(e.KeyCode);
            }
            else if (e.KeyCode == Keys.Escape && this.ContainsFocus)
            {
                Logger.Info($"let's hide, focus:  {this.Focused} | foreground: {Utils.IsForeground(this.Handle)}");

                this.Hide();
            }
        }

        private void CopyCommand(Keys numberKey)
        {
            Logger.Start();

            int commandIndex = numberKey - Keys.D0;

            if (commandTextBoxList.Count < commandIndex)
            {
                return;
            }

            // copy to clipboard
            try
            {
                Clipboard.SetText(commandTextBoxList[commandIndex - 1].Text);
            }
            catch (Exception e)
            {
                Logger.Info(e.Message);
                Logger.Info(e.StackTrace);

                MessageBox.Show($"{e.Message} Exception happen on set text to clip board");
                return;
            }

            MessageBox.Show($"Command {commandIndex} is copy!", "Copy command");
        }


        private void OnAboutClick(object sender, EventArgs e)
        {
            Logger.Start();

            var aboutDialog = new About();
            aboutDialog.ShowDialog();
        }

        private void OnExitMenuClick(object sender, EventArgs e)
        {
            Logger.Start();

            ExitProgram();
        }

        private void OnAddTaskButton(object sender, EventArgs e)
        {
            Logger.Start();
            ShowTaskDetailPopup(retModel => taskViewModel.OnOKResultOfTaskDetailPopup(retModel));
        }

        private void OnEnterTasksTabPage(object sender, EventArgs e)
        {
            Logger.Start();

            ResetTaskListView();
        }

        private void ResetTaskListView()
        {
            Logger.Start();

            taskListView.Items.Clear();

            ListViewItem[] items = taskViewModel.TaskViewItemArr;

            taskListView.Items.AddRange(items);
        }

        private void OnEnterCommandAndTipTabPage(object sender, EventArgs e)
        {
            Logger.Start();

            ResetCommandsAndTipView();
        }

        private void OnClickOpenGithub(object sender, EventArgs e)
        {
            Logger.Start();

            const string githubURL = "https://github.com/HoRockx2/winform_practice";

            Process.Start(githubURL);
        }

        private void OnGoToArchive(object sender, EventArgs e)
        {
            Logger.Start();

            taskViewModel.Archiving(taskListView.SelectedIndices.Cast<int>().ToList());
        }

        private void OnShowArchiveButton(object sender, EventArgs e)
        {
            Logger.Start();

            using (var archiveListView = new TaskArchiveListView(taskViewModel))
            {
                SetTopWindow(archiveListView.Handle);
                DialogResult dialogResult = archiveListView.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    Logger.Info("dialog result is ok");
                }
                else if (dialogResult == DialogResult.Cancel)
                {
                    Logger.Info("dialog result is cancel");
                }

                SetTopWindow(this.Handle);
            }

        }
    }
}
