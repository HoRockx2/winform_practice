using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.interop;
using WindowsFormsApp1.model;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using WindowsFormsApp1.interop;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        private bool isNeedToExit = false;
        private KeyEventHandler keyEventHandler = null;
        private Fetch fetch;
        private List<DetailModel> commandList = new List<DetailModel>();
        private List<Tuple<int, string>> searchResult = new List<Tuple<int, string>>();
        private FileIO fileIO = new FileIO();
        private List<TableLayoutPanel> commandTextLayoutList = new List<TableLayoutPanel>();
        private List<TextBox> commandTextBoxList = new List<TextBox>();
        private const string COMMAND_CONTROL_NAME_PREFIX = "command";

        public MainForm()
        {
            InitializeComponent();

            this.Text = AssemblyGetter.GetTitle();

            keyEventHandler = new KeyEventHandler();
            RegisterHotKey();

            fetch = new Fetch();
            LoadData();
            PrintCommandList();


            Application.ApplicationExit += Application_ApplicationExit;
        }

        protected override void OnShown(EventArgs e)
        {
            Logger.Start();

            base.OnShown(e);

            if(searchInputField.Text.Length == 0)
            {
                ShowAllCommandList();
            }
        }

        private void LoadData()
        {
            Logger.Start();

            var stringData = fileIO.LoadData();

            if (string.IsNullOrWhiteSpace(stringData))
            {
                return;
            }

            commandList = JsonConvert.DeserializeObject<List<DetailModel>>(stringData);
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

        private void Form1_Load(object sender, EventArgs e)
        {
            searchInputField.Select();
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

                    ShowWinForm();
                }
            }
        }

        private void OnTrayMouseDoubleClick(object sender, MouseEventArgs e)
        {
            Logger.Start();

            if(this.Handle != InteropUser32.GetForegroundWindow())
            {
                ShowWinForm();
            }
        }

        private void ShowWinForm()
        {
            Logger.Start();

            this.Visible = true;
            this.TopMost = true;
            this.TopMost = false;

            InteropUser32.SetForegroundWindow(this.Handle);
            searchInputField.Focus();
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
                    ShowWinForm();
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

        private void OnDetailPopupClick(object sender, EventArgs e)
        {
            Logger.Start();

            using (var detailPopup = new DetailPopup())
            {
                DialogResult dialogResult = detailPopup.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    Logger.Info("dialog result is ok");
                    AddCommandList(detailPopup.ResultModel);
                }
                else if (dialogResult == DialogResult.Cancel)
                {
                    Logger.Info("dialog result is cancel");
                }
            }
        }

        private void AddCommandList(DetailModel newModel)
        {
            Logger.Start();

            commandList.Add(newModel);
            NotifyCommandListChanged();

            //ResetMainFormUI();
            //UpdateDictionary();
        }

        private void NotifyCommandListChanged()
        {
            Logger.Start();

            fileIO.SaveDataAsync(commandList);

            searchInputField.Text = "";
            ShowAllCommandList();

            descriptionTextBox.Text = "";
            commandsPanel.Controls.Clear();
        }

        private void OnCommandListBoxKeyDown(object sender, KeyEventArgs e)
        {
            Logger.Start();

            if(e.KeyCode == Keys.Enter)
            {
                ShowDetailPopupWithDetailModel(commandListBox.SelectedIndex);
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

            using (var detailPopup = new DetailPopup(commandList[indexOfCommandList]))
            {
                DialogResult dialogResult = detailPopup.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    // update command
                    commandList[indexOfCommandList] = detailPopup.ResultModel;
                    NotifyCommandListChanged();
                }
                else if (DialogResult == DialogResult.Cancel)
                {
                    Logger.Info("dialog result is cancel");
                }
            }
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

            if(e.Modifiers == Keys.Control && (Keys.D1 <= e.KeyCode && e.KeyCode <= Keys.D9))
            {
                Logger.Info(e.KeyCode.ToString());

                int commandIndex = e.KeyCode - Keys.D0;

                if(commandTextBoxList.Count < commandIndex )
                {
                    return;
                }

                // show dialog
                MessageBox.Show($"Command {commandIndex} is copy!", "Copy command");
                // copy to clipboard
                Clipboard.SetText(commandTextBoxList[commandIndex - 1].Text);
            }
            else if (e.KeyCode == Keys.Escape && this.ContainsFocus)
            {
                Logger.Info("let's hide");

                this.Hide();
            }
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
    }
}
