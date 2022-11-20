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
        private FileIO<TaskModel> archiveFileIO = new FileIO<TaskModel>(Assembly.GetExecutingAssembly().GetName().Name, "taskArchiving.dat");
        //private ObservableCollection<TaskModel> taskList = new ObservableCollection<TaskModel>();
        private List<TaskModel> taskList = new List<TaskModel>();
        private List<TaskModel> archiveList = new List<TaskModel>();
        private List<ListViewItem> taskViewItemList;
        private List<ListViewItem> archiveViewItemList;
        private bool isTaskListUpdated;
        private bool isArchiveListUpdated;

        public event EventHandler OnTaskListChanged;

        public ListViewItem[] ArchiveViewItemArr
        {
            get
            {
                Logger.Start();

                if(isArchiveListUpdated || archiveViewItemList == null)
                {
                    isArchiveListUpdated = false;
                    UpdateViewItemList(ref archiveViewItemList, archiveList);
                }

                return archiveViewItemList.ToArray();
            }
        }

        public ListViewItem[] TaskViewItemArr
        {
            get
            {
                Logger.Start();

                if (isTaskListUpdated || taskViewItemList == null)
                {
                    isTaskListUpdated = false;
                    UpdateViewItemList(ref taskViewItemList, taskList.ToList());
                }

                return taskViewItemList.ToArray();
            }
        }

        public TaskViewModel()
        {
            Logger.Start();

            taskViewItemList = null;
            archiveViewItemList = null;
        }

        private void TaskList_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            Logger.Start();
            isTaskListUpdated = true;
        }
         
        

        private void UpdateViewItemList(ref List<ListViewItem> viewItemList, List<TaskModel> originList)
        {
            Logger.Start();

            viewItemList = new List<ListViewItem>();

            foreach(var task in originList)
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

            var taskListData = taskFileIO.LoadData();

            if (string.IsNullOrWhiteSpace(taskListData))
            {
                return;
            }

            //taskList = JsonConvert.DeserializeObject<ObservableCollection<TaskModel>>(taskListData);
            //taskList.CollectionChanged += TaskList_CollectionChanged;

            taskList = JsonConvert.DeserializeObject<List<TaskModel>>(taskListData);

            var archivingListData = archiveFileIO.LoadData();

            if (string.IsNullOrWhiteSpace(archivingListData))
            {
                return;
            }

            archiveList = JsonConvert.DeserializeObject<List<TaskModel>>(archivingListData);

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
            archiveFileIO.SaveDataAsync(archiveList.ToList());
            OnTaskListChanged?.Invoke(this, null);
        }
        
        private void MoveModels(ref List<TaskModel> from, ref List<TaskModel> to, List<int> indices)
        {
            Logger.Start();

            var movingList = new List<TaskModel>();

            foreach(var index in indices)
            {
                var task = from[index];
                movingList.Add(task);
                to.Add(task);
            }

            foreach(var moving in movingList)
            {
                from.Remove(moving);
            }
        }

        public void Archiving(List<int> indices)
        {
            Logger.Start();

            MoveModels(ref taskList, ref archiveList, indices);

            isArchiveListUpdated = true;
            isTaskListUpdated = true;

            NotifyTaskListChanged();
        }

        public void Restore(List<int> indices)
        {
            Logger.Start();

            MoveModels(ref archiveList, ref taskList, indices);

            isArchiveListUpdated = true;
            isTaskListUpdated = true;

            NotifyTaskListChanged();
        }
    }
}
