using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private bool isClickExitFromContextMenu = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            Logger.Info();

            if (isClickExitFromContextMenu)
            {
                e.Cancel = false;
            }

            e.Cancel = true;
            this.Visible = false;
        }

        private void OnItemsClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Logger.Info();

            switch(e.ClickedItem.Tag){
                case "CONTEXT_EXIT":
                    isClickExitFromContextMenu = true;
                    break;
                case "CONTEXT_OPEN":
                    Logger.Info("Clicked CONTEXT_OPEN");
                    break;
            }

            
        }
    }
}
