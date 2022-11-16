using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public TaskProgress Progress {get; set;}
        public DateTime StartDate { get; set; }

        [JsonIgnore]
        public string StartDateStr
        { 
            get
            {
                return StartDate.ToShortDateString() ?? "no data";
            }
        }

        public override string ToString()
        {
            //var builder = new StringBuilder($"Title : {Title} | Desc : {Description} \nProgress : {Progress} | StartDate: {StartDate.ToShortDateString()}");
            return $"Title : {Title} | Desc : {Description} \nProgress : {Progress} | StartDate: {StartDate.ToShortDateString()}";
        }
    }
}
