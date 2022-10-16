using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WindowsFormsApp1.model;
using System.IO;
using Newtonsoft.Json;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace WindowsFormsApp1
{
    public class FileIO
    {
        private static string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), Assembly.GetExecutingAssembly().GetName().Name);
        private readonly string fullPath;

        public static string FilePath => filePath;

        public FileIO()
        {
            Logger.Start();

            fullPath = Path.Combine(filePath, "commands.dat");
            
            Directory.CreateDirectory(filePath);
        }

        public async void SaveDataAsync(List<DetailModel> commandList)
        {
            Logger.Start();

            await Task.Run(() =>
            {
                string output = JsonConvert.SerializeObject(commandList);
                Logger.Info(output);

                using (StreamWriter sw = File.CreateText(fullPath))
                {
                    sw.Write(output);
                }
            });
        }

        public string LoadData()
        {
            Logger.Start();

            if (!File.Exists(fullPath))
            {
                Logger.Info($"{fullPath} file is not exist");

                return ""; 
            }

            return File.ReadAllText(fullPath);
        }
    }
}
