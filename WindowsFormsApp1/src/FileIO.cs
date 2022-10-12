using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WindowsFormsApp1.model;
using System.IO;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    public class FileIO
    {
        private readonly string filePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "commands.dat";

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

            if (!File.Exists(filePath))
            {
                Logger.Info($"{filePath} file is not exist");

                return ""; 
            }

            return File.ReadAllText(filePath);
        }
    }
}
