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
using WindowsFormsApp1.viewModel;

namespace WindowsFormsApp1
{
    public partial class TaskArchiveListView : Form
    {
        private TaskViewModel viewModel;

        public TaskArchiveListView(TaskViewModel viewModel)
        {
            this.viewModel = viewModel;
            this.viewModel.OnTaskListChanged += ViewModel_OnTaskListChanged;

            InitializeComponent();
            UpdateListView();
        }

        private void ViewModel_OnTaskListChanged(object sender, EventArgs e)
        {
            Logger.Start();

            UpdateListView();
        }

        private void UpdateListView()
        {
            Logger.Start();

            archiveListView.Items.Clear();

            ListViewItem[] items = viewModel.ArchiveViewItemArr;

            archiveListView.Items.AddRange(items);

        }
        private void OnBackToTaskList(object sender, EventArgs e)
        {
            Logger.Start();

            var indices = archiveListView.SelectedIndices;

            if(indices.Count <= 0)
            {
                return;
            }

            viewModel.Restore(indices.Cast<int>().ToList());
        }

        private void OnFormKeyDown(object sender, KeyEventArgs e)
        {
            Logger.Start();

            if (e.KeyCode == Keys.Escape)
            {
                // TODO: it's good to make 'do you want exit?' popup
                DialogResult = DialogResult.Cancel;
                this.Hide();
            }
        }



        private void ShowTaskDetailFromTaskList()
        {
            Logger.Info();

            var indices = archiveListView.SelectedIndices;

            if(indices.Count == 1)
            {
                var taskDetail = viewModel.GetTaskAt(indices[0]);
                using(var taskDetailPopup = new TaskDetail(taskDetail))
                {
                    var ret = taskDetailPopup.ShowDialog();

                    switch (ret)
                    {
                        case DialogResult.OK:
                            Logger.Info("task detail dialog result is ok");
                            viewModel.OnOKResultOfTaskDetailPopup(taskDetail, indices[0]);
                            break;
                    }
                }
            }
        }

        private void OnArchiveTaskListDoubleClick(object sender, EventArgs e)
        {
            Logger.Info();

            ShowTaskDetailFromTaskList();
        }

        private void OnArchiveTaskListKeyDown(object sender, KeyEventArgs e)
        {
            Logger.Info();

            ShowTaskDetailFromTaskList();
        }
    }
}
