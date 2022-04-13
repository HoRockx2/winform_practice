using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.model;
using System.IO;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    public class FileIO
    {
        private const string path = @"commands.dat";

        public FileIO()
        {
            Logger.Start();   
        }

        public Task SaveDataAsync(List<DetailModel> commandList)
        {
            Logger.Start();

            Task task = Task.Run(() =>
            {
                string output = JsonConvert.SerializeObject(commandList);
                Logger.Info(output);


                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.Write(output);
                }
            });

            return task;
        }
    }
}
