using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.model;

namespace WindowsFormsApp1
{
    public partial class DetailPopup : Form
    {
        private List<TextBox> commandTextBoxList = new List<TextBox>();

        public DetailModel ResultModel { get; private set; }

        public DetailPopup()
        {
            InitializeComponent();

            AddCommandTextBox();
        }

        private void AddCommandTextBox()
        {
            Logger.Start();

            var newCommandTextBox = new TextBox();
            newCommandTextBox.Tag = commandTextBoxList.Count;
            newCommandTextBox.Dock = DockStyle.Fill;

            commandTextBoxList.Add(newCommandTextBox);
            commandList.Controls.Add(newCommandTextBox);
        }

        private void OnPopupKeyDown(object sender, KeyEventArgs e)
        {
            Logger.Start();

            if(e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
                this.Hide();
            }
        }

        private void OnPlusCommandClick(object sender, EventArgs e)
        {
            Logger.Start();

            AddCommandTextBox();
        }

        private void OnClickOK(object sender, EventArgs e)
        {
            Logger.Start();

            ResultModel = new DetailModel(titleTextBox.Text, contentTextBox.Text);

        }
    }
}
