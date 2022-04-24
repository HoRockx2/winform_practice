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
            Logger.Start();
            InitializeComponent();

            AddCommandTextBox();
        }

        public DetailPopup(DetailModel detailModel)
        {
            Logger.Start();

            InitializeComponent();

            titleTextBox.Text = detailModel.Title;
            contentTextBox.Text = detailModel.Description;

            foreach(var command in detailModel.Commands)
            {
                AddCommandTextBox(command);
            }
        }

        private void AddCommandTextBox()
        {
            Logger.Start();

            CreatenewCommandTextBox();
        }

        private void AddCommandTextBox(string predefinedCommand)
        {
            Logger.Start();

            var newCommandTextBox = CreatenewCommandTextBox();
            newCommandTextBox.Text = predefinedCommand;
        }

        private TextBox CreatenewCommandTextBox()
        {
            var newCommandTextBox = new TextBox();
            newCommandTextBox.Tag = commandTextBoxList.Count;
            newCommandTextBox.Dock = DockStyle.Fill;

            commandTextBoxList.Add(newCommandTextBox);
            commandList.Controls.Add(newCommandTextBox);

            return newCommandTextBox;
        }

        private void OnPopupKeyDown(object sender, KeyEventArgs e)
        {
            Logger.Start();

            if(e.KeyCode == Keys.Escape)
            {
                // TODO: it's good to make 'do you want exit?' popup
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

            var commandList = new List<string>();

            foreach(var commandTextBox in commandTextBoxList)
            {
                commandList.Add(commandTextBox.Text);
            }

            ResultModel = commandList.Count > 0 ? new DetailModel(titleTextBox.Text, contentTextBox.Text, commandList) :
                new DetailModel(titleTextBox.Text, contentTextBox.Text);
        }
    }
}
