using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilityModule;
using WindowsFormsApp1.model;

namespace WindowsFormsApp1
{
    public partial class TaskDetail : Form
    {
        public TaskModel ResultModel { get; private set; }

        public TaskDetail()
        {
            InitializeComponent();
        }



        private void OnSaveButtonClick(object sender, EventArgs e)
        {
            Logger.Start();

            if (string.IsNullOrEmpty(titleTextBox.Text))
            {
                Logger.Info("No Title");
                return;
            }

            ResultModel = new TaskModel
            {
                Title = titleTextBox.Text,
                Description = descriptionTextBox.Text,
                Progress = TaskProgress.TODO,
                StartDate = createDateTimePicker.Value.Date
            };

            this.DialogResult = DialogResult.OK;
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            Logger.Start();

            if(e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Hide();
            }
        }
    }
}
