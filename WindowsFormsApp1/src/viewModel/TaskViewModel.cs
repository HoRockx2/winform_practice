using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using UtilityModule;
using WindowsFormsApp1.model;

namespace WindowsFormsApp1.viewModel
{
    delegate void TaskDetailPopupOKResultHandler(TaskModel retModel);

    public class TaskViewModel
    {
        private FileIO<TaskModel> taskFileIO = new FileIO<TaskModel>(Assembly.GetExecutingAssembly().GetName().Name, "tasks.dat");
        private ObservableCollection<TaskModel> taskList = new ObservableCollection<TaskModel>();
        private List<ListViewItem> viewItemList;
        private bool isTaskListUpdated;

        public event EventHandler OnTaskListChanged;

        public ListViewItem[] TaskViewItemArr
        {
            get
            {
                Logger.Start();

                if (isTaskListUpdated || viewItemList == null)
                {
                    isTaskListUpdated = false;
                    UpdateViewItemList();
                }

                return viewItemList.ToArray();
            }
        }

        public TaskViewModel()
        {
            Logger.Start();

            viewItemList = null;
        }

        private void TaskList_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            Logger.Start();
            isTaskListUpdated = true;
        }
            
        private void UpdateViewItemList()
        {
            Logger.Start();

            viewItemList = new List<ListViewItem>();

            foreach(var task in taskList)
            {
                string[] row = { task.Title, task.Progress.ToString(), task.StartDateStr };
                var newListViewItem = new ListViewItem(row);
                newListViewItem.SubItems[1].BackColor = task.Progress switch
                {
                    TaskProgress.TODO => Color.White,
                    TaskProgress.IN_PROGRESS => Color.Yellow,
                    TaskProgress.DONE => Color.Green,
                    TaskProgress.BACK_LOG => Color.LightBlue,
                    _ => throw new Exception("wrong TaskProgress was input")
                };
                newListViewItem.UseItemStyleForSubItems = false;

                viewItemList.Add(newListViewItem);
            }
        }

        public TaskModel GetTaskAt(int index)
        {
            Logger.Start();

            if (index < 0 || taskList.Count <= index)
            {
                throw new Exception($"index is wrong: [{index}]");
            }

            return taskList[index];
        }

        public void LoadData()
        {
            Logger.Start();

            var stringData = taskFileIO.LoadData();

            if (string.IsNullOrWhiteSpace(stringData))
            {
                return;
            }

            taskList = JsonConvert.DeserializeObject<ObservableCollection<TaskModel>>(stringData);
            taskList.CollectionChanged += TaskList_CollectionChanged;
        }

        public void OnOKResultOfTaskDetailPopup(TaskModel retModel)
        {
            Logger.Start(retModel.ToString());

            taskList.Add(retModel);
            isTaskListUpdated = true;
            NotifyTaskListChanged();
        }

        public void OnOKResultOfTaskDetailPopup(TaskModel retModel, int index)
        {
            Logger.Start(retModel.ToString());

            taskList[index] = retModel;
            isTaskListUpdated = true;
            NotifyTaskListChanged();
        }

        private void NotifyTaskListChanged()
        {
            Logger.Start();

            taskFileIO.SaveDataAsync(taskList.ToList());
            OnTaskListChanged?.Invoke(this, null);
        }
    }
}
