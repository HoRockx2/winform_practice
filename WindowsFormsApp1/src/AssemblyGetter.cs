using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class AssemblyGetter
    {
        static public string GetTitle()
        {
            Logger.Start();

            var assm = Assembly.GetExecutingAssembly();
            var title = (AssemblyTitleAttribute)assm.GetCustomAttribute(typeof(AssemblyTitleAttribute));

            return title.Title;
        }

        static public string GetDescription()
        {
            Logger.Start();

            var assm = Assembly.GetExecutingAssembly();
            var desc = (AssemblyDescriptionAttribute)assm.GetCustomAttribute(typeof(AssemblyDescriptionAttribute));

            return desc.Description;
        }
    }
}
