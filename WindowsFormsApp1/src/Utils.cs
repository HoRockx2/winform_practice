using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Utils
    {
        public static int LOWORD(IntPtr param) 
        {
            uint uLParam = unchecked(IntPtr.Size == 8 ? (uint)param.ToInt64() : (uint)param.ToInt32());
            int nLowValue = unchecked((short)uLParam);
            return nLowValue;
        }

        public static int HIWORD(IntPtr param) 
        {
            uint uWParam = unchecked(IntPtr.Size == 8 ? (uint)param.ToInt64() : (uint)param.ToInt32());
            int nHighValue = unchecked((short)(uWParam >> 16));
            return nHighValue;
        }
    }
}
