using System;
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
            slideValueTextLabel.Text = "0";
        }

        public TaskDetail(TaskModel existedTaskModel) : this()
        {
            Logger.Start();

            ResultModel = existedTaskModel;
            titleTextBox.Text = existedTaskModel?.Title ?? "";
            descriptionTextBox.Text = existedTaskModel?.Description ?? "";
            progressComboBox.SelectedItem = existedTaskModel?.Progress ?? TaskProgress.TODO;
            rateOfProgressTrackBar.Value = existedTaskModel?.RateOfProgress ?? 0;
            slideValueTextLabel.Text = (existedTaskModel?.RateOfProgress * 10).ToString() ?? "0";
            reportedCheckBox.Checked = existedTaskModel?.IsReported ?? false;

            if (ResultModel != null)
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
                RateOfProgress = rateOfProgressTrackBar.Value,
                IsReported = reportedCheckBox.Checked
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

        private void OnSlideValueChanged(object sender, EventArgs e)
        {
            Logger.Start();

            if(sender is TrackBar trackBar)
            {
                int adjustedValue = trackBar.Value * 10;
                slideValueTextLabel.Text = adjustedValue.ToString();
                var currentStatus = (TaskProgress)progressComboBox.SelectedItem;

                if (currentStatus != TaskProgress.BACK_LOG)
                {
                    progressComboBox.SelectedItem = adjustedValue switch
                    {
                        0 => TaskProgress.TODO,
                        100 => TaskProgress.DONE,
                        _ => TaskProgress.IN_PROGRESS
                    };
                }
            }
        }

        private void OnComboBoxChanged(object sender, EventArgs e)
        {
            Logger.Start();

            if(sender is ComboBox comboBox)
            {
                switch ((TaskProgress)comboBox.SelectedItem)
                {
                    case TaskProgress.TODO: 
                        rateOfProgressTrackBar.Value = 0;
                        break;
                    case TaskProgress.DONE:
                        rateOfProgressTrackBar.Value = 10;
                        break;
                }
            }
        }

        private void OnReportedCheckChanged(object sender, EventArgs e)
        {
            Logger.Start();

            if(sender is CheckBox checkBox)
            {

            }
        }
    }
}
