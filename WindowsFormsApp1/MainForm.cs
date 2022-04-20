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

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        private bool isNeedToExit = false;
        private KeyEventHandler keyEventHandler = null;
        private Fetch fetch;
        private List<DetailModel> commandList = new List<DetailModel>();
        private FileIO fileIO = new FileIO();

        public MainForm()
        {
            InitializeComponent();

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

        private void ShowWinForm()
        {
            Logger.Start();

            this.Visible = true;
            this.TopMost = true;
            this.TopMost = false;
            this.Focus();
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

        private void OnItemsClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Logger.Start();

            switch (e.ClickedItem.Tag){
                case "CONTEXT_EXIT":
                    isNeedToExit = true;
                    Environment.Exit(0); // it's not calling OnFormClosing... 
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
        }

        private void ShowAllCommandList()
        {
            Logger.Info();

            commandListBox.Items.Clear();
            
            foreach(var command in commandList)
            {
                commandListBox.Items.Add(command.Title);
            }
        }

        private void OnClick(object sender, EventArgs e)
        {
            Logger.Start();

            fetch.FetchData();
        }

        private void OnDetailPopupClick(object sender, EventArgs e)
        {
            Logger.Start();

            var detailPopup = new DetailPopup();
            DialogResult dialogResult = detailPopup.ShowDialog();

            if(dialogResult == DialogResult.OK)
            {
                Logger.Info("dialog result is ok");
                AddCommandList(detailPopup.ResultModel);
            }
            else if(dialogResult == DialogResult.Cancel)
            {
                Logger.Info("dialog result is cancel");
            }

            Logger.Info("do dispose popup");
            detailPopup.Dispose();
        }

        private void AddCommandList(DetailModel newModel)
        {
            Logger.Start();

            commandList.Add(newModel);
            fileIO.SaveDataAsync(commandList);

            //ResetMainFormUI();
            //UpdateDictionary();
        }
    }
}
