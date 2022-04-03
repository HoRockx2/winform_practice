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


        public Form1()
        {
            InitializeComponent();

            keyEventHandler = new KeyEventHandler();
            RegisterHotKey();
        }

        private void RegisterHotKey()
        {
            Logger.Start();

            Keys key = Keys.Space & Keys.Control & Keys.Shift;
            keyEventHandler.RegisterHotKey(this, key);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
                int keyCode = Utils.HIWORD(m.LParam);
                
                if((InteropUser32.MOD_CONTROL | InteropUser32.MOD_SHIFT) == Utils.LOWORD(m.LParam))
                {
                    if((int)Keys.Space == keyCode)
                    {
                        ShowWinForm();
                    }
                }
            }

            base.WndProc(ref m);
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

                keyEventHandler.UnregisterHotKey(this);
                notifyIcon.Dispose();
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
    }
}
