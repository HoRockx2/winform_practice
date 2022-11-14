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

            progressComboBox.DataSource = Enum.GetValues(typeof(TaskProgress));
        }

        public TaskDetail(TaskModel existedTaskModel) : this()
        {
            Logger.Start();

            ResultModel = existedTaskModel;
            titleTextBox.Text = existedTaskModel?.Title ?? "";
            descriptionTextBox.Text = existedTaskModel?.Description ?? "";
            
            if(ResultModel != null)
            {
                createDateTimePicker.Value = ResultModel.StartDate;
            }
        }

        private void OnSaveButtonClick(object sender, EventArgs e)
        {
            Logger.Start();

            if (string.IsNullOrEmpty(titleTextBox.Text))
            {
                Logger.Info("No Title");
                return;
            }

            //var progress = (TaskProgress)Enum.Parse(typeof(TaskProgress), progressComboBox.SelectedText, true);

            ResultModel = new TaskModel
            {
                Title = titleTextBox.Text,
                Description = descriptionTextBox.Text,
                Progress = (TaskProgress)progressComboBox.SelectedItem,
                StartDate = createDateTimePicker.Value.Date,
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

        private void OnProgressComboBoxIndexChanged(object sender, EventArgs e)
        {
            Logger.Start();

            if(sender is ComboBox cb)
            {
                if(Enum.TryParse<TaskProgress>(cb.SelectedText, out TaskProgress progress))
                {

                }
                else
                {
                    throw new Exception($"wrong selected Text : [{cb.SelectedText}]");
                }
            }
        }
    }
}
