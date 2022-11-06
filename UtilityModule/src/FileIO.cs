using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace UtilityModule
{
    public class FileIO<T>
    {
        //private static string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), Assembly.GetExecutingAssembly().GetName().Name);
        private readonly string fullPath;

        public static string FilePath => Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

        public FileIO(string applicationName, string fileName)
        {
            Logger.Start();

            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), applicationName);
            fullPath = Path.Combine(filePath, fileName);
            
            Directory.CreateDirectory(filePath);
        }

        public async void SaveDataAsync(List<T> commandList)
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
