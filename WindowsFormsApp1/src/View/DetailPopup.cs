﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp1.model;
using UtilityModule;

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

            if(detailModel == null)
            {
                InitializeComponent();
                AddCommandTextBox();

                return;
            }

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

            CreateNewCommandTextBox();
        }

        private void AddCommandTextBox(string predefinedCommand)
        {
            Logger.Start();

            var newCommandTextBox = CreateNewCommandTextBox();
            newCommandTextBox.Text = predefinedCommand;
        }

        private TextBox CreateNewCommandTextBox()
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

            if(string.IsNullOrEmpty(titleTextBox.Text) || string.IsNullOrEmpty(contentTextBox.Text))
            {
                MessageBox.Show("Title or Content is empty!");
                return;
            }

            var commandList = new List<string>();

            foreach(var commandTextBox in commandTextBoxList)
            {
                commandList.Add(commandTextBox.Text);
            }

            ResultModel = commandList.Count > 0 ? new DetailModel(titleTextBox.Text, contentTextBox.Text, commandList) :
                new DetailModel(titleTextBox.Text, contentTextBox.Text);

            this.DialogResult = DialogResult.OK;
        }
    }
}
