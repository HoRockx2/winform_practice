using Newtonsoft.Json;
using System;

namespace WindowsFormsApp1.model
{
    public enum TaskProgress
    {
        TODO,
        IN_PROGRESS,
        DONE,
        BACK_LOG
    }

    public class TaskModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public TaskProgress Progress { get; set; }
        public DateTime StartDate { get; set; }

        public string additionalText { get; set; }

        public bool IsReported { get; set; } = false;

        private int rateOfProgress;

        public int RateOfProgress
        {
            get => rateOfProgress;
            set
            {
                if (value < 0 || 10 < value)
                {
                    throw new Exception($"unexpected value incoming [{value}]");
                }

                rateOfProgress = value;
            }
        }

        public int RateOfImportant { get; set; }

        [JsonIgnore]
        public string StartDateStr
        { 
            get
            {
                return StartDate.ToShortDateString() ?? "no data";
            }
        }

        public override string ToString() =>
            $"Title : {Title} | Desc : {Description} \nProgress : {Progress} | StartDate: {StartDate.ToShortDateString()}";
    }
}
