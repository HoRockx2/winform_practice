using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.model
{
    public class DetailModel
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public List<string> Commands { get; private set; } = new List<string>();

        public DetailModel()
        {

        }

        public DetailModel(string title, string description)
        {
            Logger.Start($"Title: {title} | desc : {description}");

            Title = title;
            Description = description;

        }

        public DetailModel(string title, string description, List<string> commands)
        {
            Logger.Start($"Title: {title} | desc : {description} | number of commands : {commands.Count}");

            Title = title;
            Description = description;
            Commands = commands;
        }

        public void AddCommands(string newCommand)
        {
            Logger.Start();

            Commands.Add(newCommand);
        }
    }
}
