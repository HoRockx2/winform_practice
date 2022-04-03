using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace WindowsFormsApp1
{
    public class Logger
    {
        static public void Info(string log = "", [CallerMemberName] string caller = "", [CallerLineNumber] int line = 0)
        {
            Debug.WriteLine($"[{caller}] ({line}): {log}");
        }

        static public void Start([CallerMemberName] string caller = "", [CallerLineNumber] int line = 0)
        {
            Debug.WriteLine($"[{caller}] ({line}): Start");
        }
    }
}
