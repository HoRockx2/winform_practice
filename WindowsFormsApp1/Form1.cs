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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private bool isNeedToExit = false;
        private KeyEventHandler keyEventHandler = null;
        private Fetch fetch;

        public Form1()
        {
            InitializeComponent();

            keyEventHandler = new KeyEventHandler();
            RegisterHotKey();

            fetch = new Fetch();

            Application.ApplicationExit += Application_ApplicationExit;
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

            label1.Text = (sender as TextBox).Text;
        }

        private void OnClick(object sender, EventArgs e)
        {
            Logger.Start();

            fetch.FetchData();
        }
    }
}
