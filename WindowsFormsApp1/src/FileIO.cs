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
        private const string filePath = @"commands.dat";

        public FileIO()
        {
            Logger.Start();   
        }

        public async void SaveDataAsync(List<DetailModel> commandList)
        {
            Logger.Start();

            await Task.Run(() =>
            {
                string output = JsonConvert.SerializeObject(commandList);
                Logger.Info(output);

                using (StreamWriter sw = File.CreateText(filePath))
                {
                    sw.Write(output);
                }
            });
        }

        public string LoadData()
        {
            Logger.Start();

            return File.ReadAllText(filePath);
        }
    }
}
